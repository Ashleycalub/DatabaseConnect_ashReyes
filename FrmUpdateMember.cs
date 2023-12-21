using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DatabaseConnect_ashReyes
{
    public partial class FrmUpdateMember : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource BindingSource;
        
        private string connectionString;

        ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();

            clubRegistrationQuery = new ClubRegistrationQuery();
            connectionString = @"Data Source=DESKTOP-H32JL8H\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            BindingSource = new BindingSource();
            dataTable = new DataTable();
        }

        private void FrmUpdateMember_Load_1(object sender, EventArgs e)
        {
            StudIdcb();
        }
        public bool StudIdcb()
        {
            sqlAdapter = new SqlDataAdapter("SELECT StudentId FROM ClubMembers", sqlConnection);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            StudID.DataSource = dataTable;
            StudID.DisplayMember = "ClubMembers";
            StudID.ValueMember = "StudentId";
            return true;
        }
        public bool displayStudent()
        {
            if (StudID != null)
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE CAST(StudentID AS VARCHAR) = '" + StudID.Text + "'", sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Firstname.Text = reader.GetValue(0).ToString();
                    Middlename.Text = reader.GetValue(1).ToString();
                    Lastname.Text = reader.GetValue(2).ToString();
                    Age.Text = reader.GetValue(3).ToString();
                    Gender.Text = reader.GetValue(4).ToString();
                    Program.Text = reader.GetValue(5).ToString();

                }

                sqlConnection.Close();
            }

            return true;
        }

        private void StudID_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStudent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.updateStudent(int.Parse(StudID.Text), Firstname.Text, Middlename.Text, Lastname.Text, int.Parse(Age.Text), Gender.Text, Program.Text);
            MessageBox.Show("Succesfully Updated.");
        }
    }
}
