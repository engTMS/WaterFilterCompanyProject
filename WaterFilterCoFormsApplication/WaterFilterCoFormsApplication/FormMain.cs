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
            // declaring variables
            string custName = textBox_customerName.Text;
            string phoneNum = textBox_phoneNumber.Text;
            string address = textBox_address.Text;
            // 'connetionString' defines the SQL database that will be passed to the SqlConnection class 
            string connetionString = "Data Source=TMS-LAPTOP;Initial Catalog=FilterCompany;Integrated Security = True";
            /* 'sql' defines the SQL query that will be passed to the SqlCommand class
             * @name is the parameter to be replaced with user input in the textBox_customerName
             * @phone is the parameter to be replaced with user input in the textBox_phoneNumber
             */
            string sql = "insert into customer_table (customer_id, customer_name, customer_phone_number) values (23, @name, @phone)";
            // The next line is just for making sure the passes query is correct, should be removed in the final code
            MessageBox.Show(sql);

            // Creating the actual connection to the SQL Database
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command;
            //SqlDataReader dataReader;
            
            try
            {
                // Open connection to SQL server and define new instance of SqlCommand class
                connection.Open();
                command = new SqlCommand(sql, connection);
                
                // Define the previously mentioned parameters in 'sql' string
                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@name";
                paramName.Value = custName;
                command.Parameters.Add(paramName);
                SqlParameter paramPhone = new SqlParameter();
                paramPhone.ParameterName = "@phone";
                paramPhone.Value = phoneNum;
                command.Parameters.Add(paramPhone);

                // Close the connection to SQL server
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");  // Message to show in case of error
            }
        }

        private void button_customerRecord_Click(object sender, EventArgs e)
        {
            // when button click; open a new form to record all customer data
            FormCustomerRecord newRecord = new FormCustomerRecord();
            newRecord.Show();  
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox_accountData_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox_paymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_maintExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
