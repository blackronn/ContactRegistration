using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ENES;Initial Catalog=ContactDb;Integrated Security=True;TrustServerCertificate=True");
        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Contacts", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void clear()
        {
            txtName.Text = txtSurname.Text = txtPhone.Text = txtMail.Text = "";
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            List();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Contacts (Name,Surname,[Phone Number],Mail) values (@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", txtPhone.Text);
            cmd.Parameters.AddWithValue("@p4", txtMail.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Contact Added");
            List();
            clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Contacts set Name=@p1,Surname=@p2,[Phone Number]=@p3,Mail=@p4 where Id=@p5", con);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", txtPhone.Text);
            cmd.Parameters.AddWithValue("@p4", txtMail.Text);
            cmd.Parameters.AddWithValue("@p5", txtId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Contact Updated");
            List();
            clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Contacts where Id=@p1", con);
            cmd.Parameters.AddWithValue("@p1", txtId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Contact Deleted");
            List();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();


        }
    }
}
//Data Source = ENES; Initial Catalog = ContactDb; Integrated Security = True; Trust Server Certificate=True