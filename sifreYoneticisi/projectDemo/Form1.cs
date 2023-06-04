using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projectDemo
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pwmanagerdemo;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        string autoLogin; 

        public Form1()
        {
            InitializeComponent();
        }

        void fetchTheData() // veri getirici method
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM pwmtable", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fetchTheData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                websiteNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                websiteURLTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // url tiklayinca acilsin

                //websiteIcon  = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                string autoLoginVariable = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                if (autoLoginVariable == "1")
                {
                    etkinRadioButton.Checked = true;
                }
                else
                {
                    devreDisiRadioButton.Checked = true;
                }

                usernameTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                passwordTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                // bu ikisinde kopyalama ikonu olsun
            }
            catch
            {

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string addQuery = "Insert into pwmtable (id,websiteName,websiteURL,websiteAutoLogin,username,password) values (@id,@websiteName,@websiteURL,@websiteAutoLogin,@username,@password)";
            cmd = new MySqlCommand(addQuery, conn);
            // addQuery : ekleme sorgusu

            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Parameters.AddWithValue("@websiteName", websiteNameTextBox.Text);
            cmd.Parameters.AddWithValue("@websiteURL", websiteURLTextBox.Text);
            //cmd.Parameters.AddWithValue("@websiteIcon", websiteIcon); // ?
            cmd.Parameters.AddWithValue("@websiteAutoLogin", autoLogin);
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fetchTheData();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void etkinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoLogin = "1";
        }

        private void devreDisiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoLogin= "0";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string deleteQuery = "Delete From pwmtable Where id=@id";
            cmd = new MySqlCommand(deleteQuery, conn);
            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fetchTheData();
            MessageBox.Show("Kayıt silindi.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE pwmtable " +
                "SET id=@id,websiteName=@websiteName,websiteURL=@websiteURL,websiteAutoLogin=@websiteAutoLogin,username=@username,password=@password" +
                " WHERE id=@id";
            cmd = new MySqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Parameters.AddWithValue("@websiteName", websiteNameTextBox.Text);
            cmd.Parameters.AddWithValue("@websiteURL", websiteURLTextBox.Text);
            cmd.Parameters.AddWithValue("@websiteautoLogin", autoLogin);
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fetchTheData();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "websiteName LIKE '" + searchTextBox.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void createPasswordButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
