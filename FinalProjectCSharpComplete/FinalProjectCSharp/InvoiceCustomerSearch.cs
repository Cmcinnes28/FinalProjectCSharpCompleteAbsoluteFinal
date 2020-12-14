using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectCSharp
{
    public partial class InvoiceCustomerSearch : Form
    {
        
        // Setting our connection string, and a few variables to hold our commands and adapters.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public static String SetValueForFirstName = "";
        public static String SetValueForLastName = "";
        public static String SetValueForPhoneNumber = "";
        public static String SetValueForYear = "";
        public static String SetValueForMake = "";
        public static String SetValueForModel = "";
        public static String SetValueForMileage = "";
        public static int returnToCustomerSearch = 0;
        public static int displayInfo = 0;


        public InvoiceCustomerSearch()
        {
            InitializeComponent();
        }

        // This method will assign our connection string to a variable which we will use to execute a new SqlConnection. We will then
        // use a DataReader to parse the data from our SqlCommand into our DataTable and load it onto our GridViewer so we can see all the
        // enteries within our database.
        private DataTable GetCustomerList()
        {
            DataTable dtCustomerList = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT customer_number, first_name, last_name, phone_number, street_address, city, postal_code FROM tbl_customers", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtCustomerList.Load(reader);
                }
            }

            return dtCustomerList;
        }

        // This Method will set all the text boxes to empty strings
        public void ClearData()
        {
            /*txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_PhoneNumber.Text = "";
            txt_StreetAddress.Text = "";
            txt_City.Text = "";
            txt_Province.Text = "";
            txt_PostalCode.Text = "";
            txt_CustomerNumber.Text = "";*/

        }

        // This method will execute a new SQL command that will fetch all the data from the database, which will repopulate the table
        // within grid viewer so that we can see the updates in realtime.
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT customer_number, first_name, last_name, phone_number, street_address, city, postal_code FROM tbl_customers", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv_CustomersList.DataSource = dt;
        }

        // ON LOAD -- we will load the DataGridViewer by calling our GetCustomerList() method, and hide the button controls in our GroupBox
        private void CustomerSearch_Load(object sender, EventArgs e)
        {
            dgv_CustomersList.DataSource = GetCustomerList();
            dgv_CustomersList.DataSource = this.SearchCustomer();
            Main.newInvoice = 1;
            returnToCustomerSearch = 0;

        }


        private void dgv_CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_CustomersList.Rows[e.RowIndex];
                SetValueForFirstName = row.Cells[1].Value.ToString();
                SetValueForLastName = row.Cells[2].Value.ToString();
                SetValueForPhoneNumber = row.Cells[3].Value.ToString();
                SetValueForYear = row.Cells[8].Value.ToString();
                SetValueForMake = row.Cells[9].Value.ToString();
                SetValueForModel = row.Cells[10].Value.ToString();
                SetValueForMileage = row.Cells[11].Value.ToString();
            }
        }

        // This function will create a query to search all of our database fields for a match related to our text entered within txt_Search. 
        // And show us the results in our DataGridViewer.
        private DataTable SearchCustomer()
        {
            string query = "SELECT customer_number AS 'Customer#', first_name AS 'First Name', last_name AS 'Last Name', phone_number AS 'Phone#', street_address AS 'Street', city AS 'City', province AS 'Province', postal_code AS 'Postal Code', vehicle_year AS 'Year', vehicle_make AS 'Make', vehicle_model AS 'Model', vehicle_mileage AS 'Mileage' FROM tbl_customers";
            query += " WHERE customer_number LIKE '%' + @SearchTerm + '%'";
            query += " OR first_name LIKE '%' + @SearchTerm + '%'";
            query += " OR last_name LIKE '%' + @SearchTerm + '%'";
            query += " OR phone_number LIKE '%' + @SearchTerm + '%'";
            query += " OR street_address LIKE '%' + @SearchTerm + '%'";
            query += " OR city LIKE '%' + @SearchTerm + '%'";
            query += " OR province LIKE '%' + @SearchTerm + '%'";
            query += " OR postal_code LIKE '%' + @SearchTerm + '%'";
            query += " OR @SearchTerm = ''";
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", txt_Search.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // SEARCH BUTTON -- will return the results of your search query using our CustomerSearch() method.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_CustomersList.DataSource = this.SearchCustomer();
        }

        // CLEAR BUTTON -- Will reset the search button and the DataGridViewer.
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            dgv_CustomersList.DataSource = this.SearchCustomer();
        }

        // Pressing enter while inside the txt_search will preform a search without clicking the button
        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_Search.PerformClick();
            }
        }

        // Pressing this button will return to Invoice Form or Quote Form
        private void btn_Select_Click(object sender, EventArgs e)
        {
            if(displayInfo == 0)
            {
                Invoice invoice = new Invoice();
                invoice.Show();
                this.Hide();
            }
            else if (displayInfo == 1)
            {
                Quote quote = new Quote();
                quote.Show();
                this.Hide();
            }
        }

        // Pressing this button will go to CustomerList Form to allow the user to add a new customer
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            CustomerList cusList = new CustomerList();
            cusList.Show();
            this.Hide();
            returnToCustomerSearch = 1;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if(displayInfo == 0)
            {
                SetValueForFirstName = "";
                SetValueForLastName = "";
                SetValueForPhoneNumber = "";
                SetValueForYear = "";
                SetValueForMake = "";
                SetValueForModel = "";
                SetValueForMileage = "";
                Invoice invoice = new Invoice();
                invoice.Show();
                this.Hide();
            }
            else if(displayInfo == 1)
            {
                SetValueForFirstName = "";
                SetValueForLastName = "";
                SetValueForPhoneNumber = "";
                SetValueForYear = "";
                SetValueForMake = "";
                SetValueForModel = "";
                SetValueForMileage = "";
                Quote quote = new Quote();
                quote.Show();
                this.Hide();
            }

        }

        private void dgv_CustomersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_CustomersList.Rows[e.RowIndex];
                SetValueForFirstName = row.Cells[1].Value.ToString();
                SetValueForLastName = row.Cells[2].Value.ToString();
                SetValueForPhoneNumber = row.Cells[3].Value.ToString();
                SetValueForYear = row.Cells[8].Value.ToString();
                SetValueForMake = row.Cells[9].Value.ToString();
                SetValueForModel = row.Cells[10].Value.ToString();
                SetValueForMileage = row.Cells[11].Value.ToString();
            }
        }
    }
}
