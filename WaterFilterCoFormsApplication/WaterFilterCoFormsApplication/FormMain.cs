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
            int custId = get_custID(); 
            string custName = textBox_customerName.Text;
            string phoneNum = textBox_phoneNumber.Text;
            string address = textBox_address.Text;

            // supply data to the customer table
            fill_CustomerTable(custId, custName, phoneNum);
        }

        private void button_customerRecord_Click(object sender, EventArgs e)
        {
            // when button click; open a new form to record all customer details
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

        private void label_customerId_Click(object sender, EventArgs e)
        {

        }

        // This method retrieves the last 'customer id' in the 'customer table'
        private int get_custID()
        {
            SqlConnection a = new SqlConnection("Data Source=TMS-LAPTOP;Initial Catalog=FilterCompany;Integrated Security = True");
            a.Open();
            SqlCommand b = new SqlCommand("select max(customer_id) from customer_table", a);
            SqlDataReader c = b.ExecuteReader();
            int custId = 0;
            while (c.Read())
            {
                custId = c.GetInt32(0);
            }
            b.Dispose();
            a.Close();
            return custId;
        }

        private void fill_CustomerTable(int custId, string custName, string phoneNum)
        {
            // 'connetionString' defines the SQL database that will be passed to the SqlConnection class 
            string connetionString = "Data Source=TMS-LAPTOP;Initial Catalog=FilterCompany;Integrated Security = True";
            
            /* 'sql' defines the SQL query that will be passed to the SqlCommand class
             * @name is the parameter to be replaced with user input in the textBox_customerName
             * @phone is the parameter to be replaced with user input in the textBox_phoneNumber
             */
            string sql = "insert into customer_table (customer_id, customer_name, customer_phone_number) values (@id, @name, @phone)";
            
            // The next line is just for making sure the passed query is correct, should be removed in the final code
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
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@id";
                paramId.Value = custId + 1;
                command.Parameters.Add(paramId);
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
    }
}
