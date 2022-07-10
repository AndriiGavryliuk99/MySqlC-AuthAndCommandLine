using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection("Server=sql11.freemysqlhosting.net;Database=sql11505376;User Id=sql11505376;Password=9T8D6rwd7Z;"))
            {
                mySqlConnection.Open();
                MessageBox.Show("OK");
              
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (richTextBox1.Lines[richTextBox1.Lines.Length - 1] == "/start") ;
            {
                
            } */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
