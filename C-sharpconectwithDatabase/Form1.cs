using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace C_sharpconectwithDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        

       public void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conns = 
                ConfigurationManager.ConnectionStrings["HadasConection"];

            // Connection string ====> Server Name and database Name
            string strconn = conns.ConnectionString;

            conn= new SqlConnection(strconn);
            conn.Open();

            SqlCommand comm = new
                SqlCommand("select * from Department", conn);

            SqlDataAdapter data = new
                SqlDataAdapter(comm);

            DataTable data1 = new DataTable();
            data.Fill(data1);

            CMBDepartment.DataSource = data1;
            CMBDepartment.DisplayMember = "DepartmentName";
            CMBDepartment.ValueMember = "DepartmentId";
            CMBDepartment.SelectedItem = null;
            CMBDepartment.SelectedText = "--Select Department";



        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            
            SqlCommand comm = new SqlCommand("Select * from Student", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            dataGridView.DataSource = data1;
        }

        private void BtnFaculty_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Faculty", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            dataGridView.DataSource = data1;
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Department", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            dataGridView.DataSource = data1;
        }


        private void BtnSerchByName_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Student where FName = @FName or LName = @LName", conn);

            // parameters 
            comm.Parameters.AddWithValue("@FName", TxtName.Text);
            comm.Parameters.AddWithValue("@LName", TxtName.Text);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            dataGridView.DataSource = data1;
        }

        private void BtnSerchByDepartment_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Student where DepartmentId = @DepartmentId ", conn);

            // parameters 
            comm.Parameters.AddWithValue("@DepartmentId", CMBDepartment.SelectedValue);


            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            dataGridView.DataSource = data1;
        }
    }
}
