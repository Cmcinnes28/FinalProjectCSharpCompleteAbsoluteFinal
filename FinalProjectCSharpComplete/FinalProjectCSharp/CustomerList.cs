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
    public partial class CustomerList : Form
    {

        // Setting our connection string, and a few variables to hold our commands and adapters.
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;

        public CustomerList()
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
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_PhoneNumber.Text = "";
            txt_StreetAddress.Text = "";
            txt_City.Text = "";
            txt_Province.Text = "";
            txt_PostalCode.Text = "";
            txt_CustomerNumber.Text = "";        
        }

        // This method will execute a new SQL command that will fetch all the data from the database, which will repopulate the table
        // within grid viewer so that we can see the updates in realtime.
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT customer_number AS 'Customer#', first_name AS 'First Name', last_name AS 'Last Name', phone_number AS 'Phone#', street_address AS 'Street', city AS 'City', province AS 'Province', postal_code AS 'Postal Code' FROM tbl_customers", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv_CustomersList.DataSource = dt;
        }

        // ON LOAD -- we will load the DataGridViewer by calling our GetCustomerList() method, and hide the button controls in our GroupBox
        private void CustomerList_Load(object sender, EventArgs e)
        {
            dgv_CustomersList.DataSource = GetCustomerList();
            dgv_CustomersList.DataSource = this.CustomerSearch();
            gb_Information.Hide();
        }

        // ADD BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Add Customer" and change the
        // button to say "ADD" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Add Customer";
            btn_AddNew.Text = "ADD";
            ClearData();
        }

        // EDIT BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Update Customer" and change the
        // button to say "UPDATE" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Update Customer";
            btn_AddNew.Text = "UPDATE";
            ClearData();
        }

        // DELETE BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Delete Customer" and change the
        // button to say "DELETE" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Delete Customer";
            btn_AddNew.Text = "DELETE";
            ClearData();
        }

        // EXIT -- This will terminate the current window, and open a new main window
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if(InvoiceCustomerSearch.returnToCustomerSearch == 1)
            {
                InvoiceCustomerSearch inCusSearch = new InvoiceCustomerSearch();
                inCusSearch.Refresh();
                inCusSearch.Show();
                this.Hide();
            }
            else
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }


        }

        // When a row on the DataGridViewer is selected the values will be assigned to the corresponding TextBoxes according to the row.Cells
        private void dgv_CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_CustomersList.Rows[e.RowIndex];
                txt_CustomerNumber.Text = row.Cells[0].Value.ToString();
                txt_FirstName.Text = row.Cells[1].Value.ToString();
                txt_LastName.Text = row.Cells[2].Value.ToString();
                txt_PhoneNumber.Text = row.Cells[3].Value.ToString();
                txt_StreetAddress.Text = row.Cells[4].Value.ToString();
                txt_City.Text = row.Cells[5].Value.ToString();
                txt_Province.Text = row.Cells[6].Value.ToString();
                txt_PostalCode.Text = row.Cells[7].Value.ToString();               
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            // If the text of the button is equal to DELETE and the txt_CustomerNumber textbox is not empty, we will execute a query command to 
            // delete the entry selected using the txt_CustomerNumber which will prompt us with a message box to confirm we want to delete the entry,
            // and if we select yes then it will be deleted from out database. We will then refresh the GridViewer so we can see our revisions,
            // and clear the data of the textboxes for additional queries.
            if (btn_AddNew.Text == "DELETE")
            {
                if (txt_CustomerNumber.Text != "")
                {
                    string message = "Are you sure you want to delete?";
                    string title = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM tbl_customers WHERE customer_number = @custNum", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@custNum", txt_CustomerNumber.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully");
                        con.Close();
                        refreshdata();
                        ClearData();
                    }
                }
            }

            // If the text of the button is equal to UPDATE, we will execute a query command to update all the fields using the tbl_customers
            // which if successful will give us a message box indicating the update was successful. It will then refresh the GridViewer showing
            // us the update and will clear all the text boxes for additional queries.
            if (btn_AddNew.Text == "UPDATE")
            {
                cmd = new SqlCommand("UPDATE tbl_customers SET first_name = @fname, last_name = @lname, phone_number = @phnum, street_address = @stadd, " +
                    "city = @city, province = @prov, postal_code = @postCod WHERE customer_number = @custNum", con);
                con.Open();
                cmd.Parameters.AddWithValue("@custNum", txt_CustomerNumber.Text);
                cmd.Parameters.AddWithValue("@fname", txt_FirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txt_LastName.Text);
                cmd.Parameters.AddWithValue("@phnum", txt_PhoneNumber.Text);
                cmd.Parameters.AddWithValue("@stadd", txt_StreetAddress.Text);
                cmd.Parameters.AddWithValue("@city", txt_City.Text);
                cmd.Parameters.AddWithValue("@prov", txt_Province.Text);
                cmd.Parameters.AddWithValue("@postCod", txt_PostalCode.Text);               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                refreshdata();
                ClearData();
            }

            // If the text of the button is equal to ADD, we will execute a query command to insert all the fields using the tbl_customers
            // which if successful will give us a message box indicating the insert was successful. It will then refresh the GridViewer showing
            // us the updated records and will clear all the text boxes for additional queries.
            if (btn_AddNew.Text == "ADD")
            {
                cmd = new SqlCommand("INSERT INTO tbl_customers (first_name, last_name, phone_number, street_address, city, province, postal_code, vehicle_year, vehicle_make, vehicle_model, vehicle_mileage)  " +
                                        "VALUES (@fname, @lname, @phnum, @stadd, @city, @prov, @postCod, @year, @make, @model, @mileage)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fname", txt_FirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txt_LastName.Text);
                cmd.Parameters.AddWithValue("@phnum", txt_PhoneNumber.Text);
                cmd.Parameters.AddWithValue("@stadd", txt_StreetAddress.Text);
                cmd.Parameters.AddWithValue("@city", txt_City.Text);
                cmd.Parameters.AddWithValue("@prov", txt_Province.Text);
                cmd.Parameters.AddWithValue("@postCod", txt_PostalCode.Text);              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                con.Close();
                refreshdata();
                ClearData();
            }

        }

        // This function will create a query to search all of our database fields for a match related to our text entered within txt_Search. 
        // And show us the results in our DataGridViewer.
        private DataTable CustomerSearch()
        {
            string query = "SELECT customer_number AS 'Customer#', first_name AS 'First Name', last_name AS 'Last Name', phone_number AS 'Phone#', street_address AS 'Street', city AS 'City', province AS 'Province', postal_code AS 'Postal Code' FROM tbl_customers";
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
            dgv_CustomersList.DataSource = this.CustomerSearch();
        }

        // CLEAR BUTTON -- Will reset the search button and the DataGridViewer.
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            dgv_CustomersList.DataSource = this.CustomerSearch();
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

        private void btn_BackupData_Click(object sender, EventArgs e)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "CustomerListBackup" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xls";

            // Create the EXCEL Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // Create a new Workbook inside the EXCEL Application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Create a new Excel Sheet inside the Workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // Make the Excel Sheet visible behind the Application
            app.Visible = true;
            // Taking the default reference of "Sheet1" from EXCEL and storing it to the WorkSheet
            worksheet = workbook.Sheets["Sheet1"];
            // Changing the name of our active WorkSheet
            worksheet.Name = "Customer List Backup";
            // Storing the Header names inside the EXCEL Application
            for (int i = 1; i < dgv_CustomersList.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_CustomersList.Columns[i - 1].HeaderText;
            }
            // Storing each of the rows, and columns data within our EXCEL Application
            for (int i = 0; i < dgv_CustomersList.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_CustomersList.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_CustomersList.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Now we are going to save the file
            workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing);
        }

        private void gb_Information_Enter(object sender, EventArgs e)
        {

        }
    }
}
