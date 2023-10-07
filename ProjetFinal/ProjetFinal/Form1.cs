using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class Form1 : Form
    {

        private RegistreContacts registre;
        private ContactDao contactDao;

        public Form1()
        {
            InitializeComponent();

            registre = new RegistreContacts();
            contactDao = new ContactDao();
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();

            // Vérifier si les champs obligatoires sont vides
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de saisie");
                return;
            }

            if (Regex.IsMatch(txtNom.Text, @"^\d+$"))
            {
                MessageBox.Show("Le champ Nom ne peut pas être numérique.");
                return;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("Le courriel n'est pas valide.");
                return;
            }

            // Vérifier si le contact existe déjà dans le registre
            if (contactDao.ExisteContact(txtEmail.Text))
            {
               MessageBox.Show("Ce contact existe déjà dans le registre.", "Erreur de saisie");
                return;
            }

            // Ajouter le contact
            Contact nouveauContact = new Contact(txtNom.Text, txtEmail.Text);
            contactDao.AjouterContact(nouveauContact);
            registre.AjouterContact(nouveauContact);

            MessageBox.Show("Le contact a été ajouté avec succès.");


            // Effacer les TextBox pour une nouvelle saisie
            txtNom.Clear();
            txtEmail.Clear();

        }

        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
            // Vérifier si les champs obligatoires sont vides
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de saisie");
                return;
            }

            if (Regex.IsMatch(txtNom.Text, @"^\d+$"))
            {
                MessageBox.Show("Le champ Nom ne peut pas être numérique.");
                return;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("Le courriel n'est pas valide.");
                return;
            }


            if (!double.TryParse(txtScn.Text, out _))
            {
                MessageBox.Show("Le code scn doit être un nombre.");
                return;
            }

            // Vérifier si le contact existe déjà dans le registre
            if (contactDao.ExisteContact(txtEmail.Text))
            {
                MessageBox.Show("Ce fournisseur existe déjà dans le registre.", "Erreur de saisie");
                return;
            }
            Fournisseur nouveauFournisseur = new Fournisseur(txtNom.Text, txtEmail.Text, txtScn.Text);
            // Ajoute et enregistre le contact
            contactDao.AjouterContact(nouveauFournisseur);
            registre.AjouterContact(nouveauFournisseur);


            MessageBox.Show("Le fournisseur a été ajouté avec succès.");

            // Efface les TextBox pour une nouvelle saisie
            txtNom.Clear();
            txtEmail.Clear();
            txtScn.Clear();





        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();

            List<Contact> contacts = contactDao.TousLesContacts();

            if (contacts.Count == 0)
            {
                MessageBox.Show("Il n'y a pas de contacts à afficher.");
                return;
            }

            foreach (var contact in contacts)
            {
                string displayText = contact.Nom + " - " + contact.Email;

                if (contact is Fournisseur fournisseur)
                {
                    displayText += " - " + fournisseur.CodeScn;
                }

                listBoxContacts.Items.Add(displayText);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            {
                string nomRecherche = txtNom.Text; // Récupérer le nom à rechercher depuis un contrôle TextBox (ici, txtNomRecherche)

                Contact contact = contactDao.RechercherContact(nomRecherche);

                if (contact != null)
                {
                    // Afficher les détails du contact recherché
                    string detailsContact = "Nom : " + contact.Nom + Environment.NewLine +
                                            "Email : " + contact.Email + Environment.NewLine +
                                            "Type : " + contact.Type;

                    MessageBox.Show(detailsContact, "Détails du contact");
                }
                else
                {
                    MessageBox.Show("Contact non trouvé", "Erreur");
                }
            }
        }

        private void btnRegistre_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();

            List<Contact> contacts = registre.GetContacts();

            if (contacts.Count == 0)
            {
                MessageBox.Show("Il n'y a pas de contacts à afficher.");
                return;
            }

            foreach (var contact in contacts)
            {
                string displayText = contact.Nom + " - " + contact.Email;

                if (contact is Fournisseur fournisseur)
                {
                    displayText += " - " + fournisseur.CodeScn;
                }

                listBoxContacts.Items.Add(displayText);
            }

        }

        private void btnRechercheRegistre_Click(object sender, EventArgs e)
        {
            {
                string nomRecherche = txtNom.Text; // Récupérer le nom à rechercher depuis un contrôle TextBox (ici, txtNomRecherche)

                Contact contact = registre.RechercherContact(nomRecherche);

                if (contact != null)
                {
                    // Afficher les détails du contact recherché
                    string detailsContact = "Nom : " + contact.Nom + Environment.NewLine +
                                            "Email : " + contact.Email + Environment.NewLine +
                                            "Type : " + contact.Type;

                    MessageBox.Show(detailsContact, "Détails du contact");
                }
                else
                {
                    MessageBox.Show("Contact non trouvé", "Erreur");
                }
            }
        }
    }
}




