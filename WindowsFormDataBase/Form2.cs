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
    public partial class Form2 : Form
    {

        public int SelectedId { get; set; }

        public Form2()
        {
            InitializeComponent();
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {

                var peopleInTheDataBase = context.People
                            .Select(p => new
                            {
                                Id = p.id,
                                Naam = p.voornaam + " " + p.achternaam,
                                Leeftijd = p.leeftijd
                            }).ToList();

                cb_people.DataSource = peopleInTheDataBase;
                cb_people.DisplayMember = "Naam";
                cb_people.ValueMember = "Id";

            }
               
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (Form_Add form_Add = new Form_Add())
            {
                switch (form_Add.ShowDialog())
                {
                    case DialogResult.OK:
                        using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
                        {
                            var peopleInTheDataBase = context.People
                                .Select(p => new
                                {
                                    Id = p.id,
                                    Naam = p.voornaam + " " + p.achternaam,
                                    Leeftijd = p.leeftijd
                                }).ToList();
                            
                            cb_people.DataSource = null;
                            cb_people.DataSource = peopleInTheDataBase;
                            cb_people.DisplayMember = "Naam";
                            cb_people.ValueMember = "Id";
                        }
                        break;
                    case DialogResult.Cancel: // this is the x button
                        MessageBox.Show("No new person was added.");
                        break;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SelectedId = Convert.ToInt32(cb_people.SelectedValue);

            using (Form_Edit form_Edit = new Form_Edit(SelectedId))
            {
              
                switch (form_Edit.ShowDialog())
                {
                    
                    case DialogResult.OK:
                        using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
                        {
                            
                            var peopleInTheDataBase = context.People
                              .Select(p => new
                              {
                                  Id = p.id,
                                  Naam = p.voornaam + " " + p.achternaam,
                                  Leeftijd = p.leeftijd
                              }).ToList();
                            cb_people.DataSource = null;
                            cb_people.DataSource = peopleInTheDataBase;
                            cb_people.DisplayMember = "Naam";
                            cb_people.ValueMember = "Id";

                        }
                        break;

                    case DialogResult.Cancel:
                        break;

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SelectedId = Convert.ToInt32(cb_people.SelectedValue);

            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                Person person = context.People.FirstOrDefault(p => p.id == SelectedId);
                //Person person = context.People.Find(SelectedId);
                context.People.Remove(person);

                /*var newObjects = context.People.Join(context.Persons_badges,

                    p => p.id,
                    pb => pb.people_id,
                    (p, pb) => new
                    {
                        Person = (Person)p,
                        PersonsBadges = (Persons_badges)pb
                    }).Where(element => element.Person.id == SelectedId);
                

                var theirbadges = person.Persons_badges;
                foreach (var badge in theirbadges)
                {
                    context.Persons_badges.Remove(badge);
                }*/

                var removedPersonsBadges = context.Persons_badges.Where(pb => pb.people_id == SelectedId);
                foreach (var badge in removedPersonsBadges)
                {
                    context.Persons_badges.Remove(badge);
                }
                context.SaveChanges();

                MessageBox.Show($"{person.voornaam} {person.achternaam} has been deleted."); 
            }

            
        }

        private void btn_addBadges_Click(object sender, EventArgs e)
        {
            using(Form_NewBadge form_NewBadge = new Form_NewBadge())
            {
                form_NewBadge.ShowDialog();
              /*  if (form_NewBadge.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show($"{form_NewBadge.NewBadge} has been added");
                }*/
            }
        }
    }
}
