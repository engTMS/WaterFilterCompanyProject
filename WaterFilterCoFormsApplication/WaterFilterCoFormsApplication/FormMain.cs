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

namespace WaterFilterCoFormsApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_dataEntry_Click(object sender, EventArgs e)
        {
            string name1 = textBox_firstName.Text;
            string name2 = textBox_lastName.Text;
            //int id = textBox_id.Text;
            string connetionString = "Data Source=TMS-LAPTOP;Initial Catalog=FilterCompany;Integrated Security = True";
            //string sql = "insert into customer_table (customer_id, customer_first_name, customer_last_name) values (18, 'name1', 'name2')";
            string sql = "insert into customer_table (customer_id, customer_first_name, customer_last_name) values (19,'"+ name1 + "','" + name2 + "')";

            MessageBox.Show(sql);

            SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;
            
            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
