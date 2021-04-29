using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDataBase
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

            


            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                //create list from database with the properties you need (using select)
                var peopleInTheDataBase = context.People
                    .Select(p => new    //select transform each element in the data base set(collection)
                    {
                        Id = p.id,
                        Naam = p.voornaam + " " + p.achternaam,
                        Leeftijd = p.leeftijd
                    }).ToList(); //tolist is method of IEnumerable(a collection)

                cbNaam.DataSource = peopleInTheDataBase;
                cbNaam.DisplayMember = "Naam";
                cbNaam.ValueMember = "Id";
            }
           

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                context.People.Add(new Person()
                {
                    voornaam = txt_voornaam.Text,
                    achternaam = txt_achternaam.Text,
                    leeftijd = Convert.ToInt32(num_leeftijd.Value)
                });
                context.SaveChanges();

                txt_voornaam.Clear();
                txt_achternaam.Clear();
                num_leeftijd.Value = 0;

               var peopleInTheDataBase = context.People
                   .Select(p => new
                   {
                       Id = p.id,
                       Naam = p.voornaam + " " + p.achternaam,
                       Leeftijd = p.leeftijd
                   }).ToList();

                cbNaam.DataSource = null;
                cbNaam.DataSource = peopleInTheDataBase;
                cbNaam.DisplayMember = "Naam";
                cbNaam.ValueMember = "Id";
            }
        }

       

        private void btn_verwijder_Click(object sender, EventArgs e)
        {
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                int selectedID = Convert.ToInt32(cbNaam.SelectedValue);
                var selectedPerson = context.People.FirstOrDefault(p => p.id == selectedID);
                context.People.Remove(selectedPerson);
                context.SaveChanges();
                var peopleInTheDataBase = context.People
                  .Select(p => new
                  {
                      Id = p.id,
                      Naam = p.voornaam + " " + p.achternaam,
                      Leeftijd = p.leeftijd
                  }).ToList();
                cbNaam.DataSource = null;
                cbNaam.DataSource = peopleInTheDataBase;
                cbNaam.DisplayMember = "Naam";
                cbNaam.ValueMember = "Id";
            }
        }

        private void btn_edit_existing_Click(object sender, EventArgs e)
        {
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                int selectedID = Convert.ToInt32(cbNaam.SelectedValue);
                var selectedPerson = context.People.FirstOrDefault(p => p.id == selectedID);
                selectedPerson.voornaam = txt_newname.Text;
                selectedPerson.achternaam = txt_newlastname.Text;
                selectedPerson.leeftijd = Convert.ToInt32(num_newage.Value);
                context.SaveChanges();

                var peopleInTheDataBase = context.People
                  .Select(p => new
                  {
                      Id = p.id,
                      Naam = p.voornaam + " " + p.achternaam,
                      Leeftijd = p.leeftijd
                  }).ToList();
                cbNaam.DataSource = null;
                cbNaam.DataSource = peopleInTheDataBase;
                cbNaam.DisplayMember = "Naam";
                cbNaam.ValueMember = "Id";

            }
        }
    }
}
