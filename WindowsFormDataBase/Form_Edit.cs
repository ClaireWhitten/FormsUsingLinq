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
    public partial class Form_Edit : Form
    {

        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }

        public int SelectedId { get; set; }

        public List<Badge> ExistingBadges { get; set; }

        public CheckedListBox ChkListBox { get; set; }


        public Form_Edit(int selectedID) //selected id(person) from main form passed through as parameter to the edit form in the constructor
        {
            InitializeComponent();
            SelectedId = selectedID; //selected id saved as property in on this class so can be accessed

          
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            {
                


                // create the badge checkboxes based on the badges that exist 
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


                //set the input fields of the edit form with the existing info of the person 
                Person selectedPerson = context.People.FirstOrDefault(p => p.id == SelectedId);
                txt_EditedName.Text = selectedPerson.voornaam;
                txt_EditedLastName.Text = selectedPerson.achternaam;
                num_EditedAge.Value = Convert.ToInt32(selectedPerson.leeftijd);


                var personAndBadges = context.People.Join(context.Persons_badges,
                    p => p.id,
                    pb => pb.people_id,
                    (p, pb) => new
                    {
                        p = p,
                        pb = pb
                    }).Join(context.Badges,
                    ppb => ppb.pb.badge_id,
                    b => b.id,
                    (ppb, b) => new
                    {
                        PersonId = ppb.p.id,
                        Name = ppb.p.voornaam + " " + ppb.p.achternaam,
                        BadgeId = b.id,
                        BadgeName = b.opschrijft
                    }).Where(p => p.PersonId == SelectedId);



             
                for (int i = 0; i < ChkListBox.Items.Count; i++)
                { 
                    foreach (var item in personAndBadges)
                    {

                        if (ChkListBox.Items[i].ToString() == item.BadgeName)
                        {
                            ChkListBox.SetItemChecked(i, true);
                        }
                    }
                    
                }

               
            }
        }

        private void btn_SaveEdits_Click(object sender, EventArgs e)
        {
            using (PeopleDatabaseEntities context = new PeopleDatabaseEntities())
            { 

                var selectedPerson = context.People.FirstOrDefault(p => p.id == SelectedId);
                selectedPerson.voornaam = txt_EditedName.Text;
                selectedPerson.achternaam = txt_EditedLastName.Text;
                selectedPerson.leeftijd = Convert.ToInt32(num_EditedAge.Value);


                var personAndBadges = context.People.Join(context.Persons_badges,
                    p => p.id,
                    pb => pb.people_id,
                    (p, pb) => new
                    {
                        p = p,
                        pb = pb
                    }).Join(context.Badges,
                    ppb => ppb.pb.badge_id,
                    b => b.id,
                    (ppb, b) => new
                    {
                        PersonId = ppb.p.id,
                        Name = ppb.p.voornaam + " " + ppb.p.achternaam,
                        BadgeId = b.id,
                        BadgeName = b.opschrijft
                    }).Where(p => p.PersonId == SelectedId);






                for (int i = 0; i < ChkListBox.Items.Count; i++)
                {
                    if (ChkListBox.GetItemChecked(i))
                    {
                        int idOfBadge = ExistingBadges[i].id;
                        if(context.Persons_badges.Find(SelectedId, idOfBadge) == null)
                        {
                            context.Persons_badges.Add(new Persons_badges()
                            {
                                people_id = SelectedId,
                                badge_id = idOfBadge
                            });
                        }
                    } else
                    {
                        int idOfBadge = ExistingBadges[i].id;
                        Persons_badges badgeToRemove = context.Persons_badges.Find(SelectedId, idOfBadge);
                        if (badgeToRemove != null)
                        {
                            context.Persons_badges.Remove(badgeToRemove);
                        }
                    }
                }
                

                context.SaveChanges();

            }
        }


      
    }
}
