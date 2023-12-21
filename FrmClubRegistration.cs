using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnect_ashReyes
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;


        private long StudentId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdate = new FrmUpdateMember();
            frmUpdate.ShowDialog();
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        public void RefreshListofClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListofClubMembers();
        }

        public int RegistrationID()
        {
            return count++;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.RegisterStudent(RegistrationID(), int.Parse(tbStudID.Text), tbFirstname.Text, tbMiddlename.Text, tbLastname.Text, 
            int.Parse(tbAge.Text), cbGender.SelectedItem.ToString(), cbProgram.SelectedItem.ToString());       
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListofClubMembers();
        }

    }
}
