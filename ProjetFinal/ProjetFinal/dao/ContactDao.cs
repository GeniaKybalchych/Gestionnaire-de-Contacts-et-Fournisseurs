using MySqlConnector;
using ProjetFinal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class ContactDao
{
    private MySqlConnection connection;

    public ContactDao()
    {
        string connStr = "server=localhost;user=root;pwd=gr007,,;database=RegistreContactsDB;port=3306;";
        connection = new MySqlConnection(connStr);
    }

    public void AjouterContact(Contact contact)
    {
        connection.Open();

        string codeScn = null;
        string typeContact;
        if (contact is Fournisseur)
        {
            codeScn = ((Fournisseur)contact).CodeScn;
            typeContact = "Fournisseur";
        }
        else
        {
            typeContact = "Contact";
        }

        string query = "INSERT INTO contacts (nom, email, CodeSCN, TypeContact) VALUES (@nom, @email, @CodeSCN, @TypeContact)";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", contact.Nom);
        cmd.Parameters.AddWithValue("@email", contact.Email);
        cmd.Parameters.AddWithValue("@CodeSCN", codeScn);
        cmd.Parameters.AddWithValue("@TypeContact", typeContact);

        cmd.ExecuteNonQuery();

        connection.Close();
    }

    public Contact RechercherContact(string nom)
    {
        connection.Open();

        string sql = "SELECT * FROM contacts WHERE nom = @nom";
        MySqlCommand cmd = new MySqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@nom", nom);
        MySqlDataReader rdr = cmd.ExecuteReader();

        Contact contact = null;
        if (rdr.Read())
        {
            nom = rdr["nom"].ToString();
            string email = rdr["email"].ToString();
            string typeContact = rdr["TypeContact"].ToString();

            if (typeContact == "Fournisseur")
            {
                contact = new Fournisseur(nom, email, typeContact);
            }
            else
            {
                contact = new Contact(nom, email);
            }
        }

        rdr.Close();
        connection.Close();

        return contact;
    }

    public List<Contact> TousLesContacts()
    {
        List<Contact> contacts = new List<Contact>();
        connection.Open();
        string sql = "SELECT Nom, Email, TypeContact FROM Contacts";

        MySqlCommand cmd = new MySqlCommand(sql, connection);
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string nom = (string)reader["Nom"];
            string email = (string)reader["Email"];
            string typeContact = (string)reader["TypeContact"];

            Contact contact;
            if (typeContact == "Fournisseur")
            {
                contact = new Fournisseur(nom, email, typeContact);
            }
            else
            {
                contact = new Contact(nom, email);
            }

            contacts.Add(contact);
        }

        reader.Close();
        connection.Close();
        return contacts;
    }

    public bool ExisteContact(string email)
    {
        connection.Open();

        string sql = "SELECT COUNT(*) FROM contacts WHERE email = @email";
        MySqlCommand cmd = new MySqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@email", email);
        int count = Convert.ToInt32(cmd.ExecuteScalar());

        connection.Close();

        return count > 0;
    }
}
