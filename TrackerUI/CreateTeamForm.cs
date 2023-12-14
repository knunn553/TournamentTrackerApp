using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        // We have two lists that we need to create for.
        // We have the pool of people that we are to choose from and we have the pool of people that have been chosen to play on a team.
        // Need two List<PersonModel> for this.
        private List<PersonModel> selectedTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();



        public CreateTeamForm()
        {
            InitializeComponent();
            // CreateSampleData();
            WireUpLists();

        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Kyle", LastName = "Nunn" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Ryan", LastName = "Scanlon" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Ben", LastName = "Goins" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropBox.DataSource = null;

            selectTeamMemberDropBox.DataSource = availableTeamMembers;
            selectTeamMemberDropBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void addNewTeamMemberButton_Click(object sender, EventArgs e)
        {
            // Need a method that Validates the information inputted into the form
            // We'll then clear the form. 
            // Making sure fields have some type of string - not very robust, but were doing it.
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = memberEmailValue.Text;
                p.CellphoneNumber = memberPhoneNumberValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                memberEmailValue.Text = "";
                memberPhoneNumberValue.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }

        }

        private bool ValidateForm()
        {
            // It's important to make sure validation is on point becuase we need high quality data.
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (memberEmailValue.Text.Length == 0)
            {
                return false;
            }
            if (memberPhoneNumberValue.Text.Length == 0)
            {
                return false;
            }
            return true;

        }

        private void selectTeamMemberDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                WireUpLists();
            }


        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);
        }
    }
}
