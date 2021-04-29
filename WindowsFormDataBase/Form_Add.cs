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
    public partial class Form_Add : Form
    {
        public string FirstName { get; set; }

        public string LastName  { get; set; }
        public int Age { get; set; }

        public List<Badge> ExistingBadges { get; set; }

        public CheckedListBox ChkListBox { get; set; }

        public Form_Add()
        {
            InitializeComponent();
             using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
             {
                ExistingBadges = new List<Badge>();
                ExistingBadges = context.Badges.ToList();

                ChkListBox = new CheckedListBox()
                {
                    Location = new Point(70, 220)
                };
                Controls.Add(ChkListBox);
                foreach (var badge in ExistingBadges)
                {
                    ChkListBox.Items.Add(badge.opschrijft);
                }
             }
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                Person newPerson = new Person()
                {
                    voornaam = txtName.Text,
                    achternaam = txtLastName.Text,
                    leeftijd = Convert.ToInt32(txtAge.Text)

                };
                context.People.Add(newPerson);


                foreach (var checkedIndex in ChkListBox.CheckedIndices)
                {

                    int chosenIndex = Convert.ToInt32(checkedIndex);
                    int idOfBadge = ExistingBadges[chosenIndex].id;
                   
                    
                    context.Persons_badges.Add(new Persons_badges()
                    {
                        people_id = newPerson.id,
                        badge_id = idOfBadge
                    });

                }
                context.SaveChanges();
            }
       
        }

       
    } 
} 
