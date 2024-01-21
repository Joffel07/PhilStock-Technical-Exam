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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=CRUD;Trusted_Connection=True; ");
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.std_info_insert '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            LoadAllRecords();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }


        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.Std_all_info", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.std_info_update '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Update");
            LoadAllRecords();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.std_info_delete '" + int.Parse(textBox1.Text) + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
            LoadAllRecords();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.Std_info_search'"+ int.Parse(textBox1.Text) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
