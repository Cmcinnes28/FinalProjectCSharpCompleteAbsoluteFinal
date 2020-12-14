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

    public partial class InvoiceDraft : Form
    {
        public static String SetValueForFirstName = "";
        public static String SetValueForLastName = "";
        public static String SetValueForPhoneNumber = "";
        public static String SetValueForYear = "";
        public static String SetValueForMake = "";
        public static String SetValueForModel = "";
        public static String SetValueForMileage = "";
        public static String SetValueForInvoiceNo = "";
        public static String SetValueForDate = "";
        public static String SetValueForComments = "";
        public static String SetValueForTaxExempt = "";
        public static int DraftCount;
        // Setting our connection string, and a few variables to hold our commands and adapters.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt_InvoiceDrafts = new DataTable();
        DataGridTableStyle ts = new DataGridTableStyle();
        public InvoiceDraft()
        {
            InitializeComponent();
        }

        // This method will assign our connection string to a variable which we will use to execute a new SqlConnection. We will then
        // use a DataReader to parse the data from our SqlCommand into our DataTable and load it onto our GridViewer so we can see all the
        // enteries within our database.
        private DataTable getInvoiceDraftTable()
        {
            // DataTable dt_InvoiceDrafts = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT invoice_number 'Invoice Number', date 'Date', first_name 'First Name', last_name 'Last Name', phone_number 'Phone Number', v_year 'Vehicle Year', v_make 'Vehicle Make', v_model 'Vehicle Model', mileage 'Vehicle Mileage', comments 'Comments',tax_exempt 'Tax Exempt' FROM tbl_invoice_draft", con))
                    {
                        //  "SELECT invoice_number as 'Invoice Number', date, concat(' ',first_name,' ',last_name) as 'Customer Name'
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt_InvoiceDrafts.Load(reader);
                    }
                } catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to the Database.");
                }
            }

            return dt_InvoiceDrafts;
        }
        // This method will execute a new SQL command that will fetch all the data from the database, which will repopulate the table
        // within grid viewer so that we can see the updates in realtime.
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT invoice_number 'Invoice Number', date 'Date', first_name 'First Name', last_name 'Last Name', phone_number 'Phone Number', v_year 'Vehicle Year', v_make 'Vehicle Make', v_model 'Vehicle Model', mileage 'Vehicle Mileage', comments 'Comments', tax_exempt 'Tax Exempt' FROM tbl_invoice_draft", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv_InvoiceDrafts.DataSource = dt;
        }
        private void hideColumns()
        {
            dgv_InvoiceDrafts.Columns["phone number"].Visible = false;
            dgv_InvoiceDrafts.Columns["Vehicle Year"].Visible = false;
            dgv_InvoiceDrafts.Columns["Vehicle Mileage"].Visible = false;
            dgv_InvoiceDrafts.Columns["comments"].Visible = false;
            // dgv_InvoiceDrafts.Columns["tax_exempt"].Visible = false;
        }
        public void ClearData()
        {
            invoice_txt.Text = "";

        }

        // ON LOAD -- we will load the DataGridViewer by calling our GetPartsList() method, and hide the button controls in our GroupBox
        private void InvoiceDraft_Load(object sender, EventArgs e)
        {
            dgv_InvoiceDrafts.DataSource = getInvoiceDraftTable();
            hideColumns();
        }

        // EXIT
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // Displays in textbox which invoice is selected 
        private void dgv_InvoiceDrafts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_InvoiceDrafts.Rows[e.RowIndex];
                invoice_txt.Text = row.Cells[0].Value.ToString();
            }
        }
        private void dgv_InvoiceDrafts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // When user clicks delete button a message pops up to confirm user wants to delete selection. if so then the selected row is deleted
        

        private void lbl_PartNumber_Click(object sender, EventArgs e)
        {

        }

        private void btn_Open_Click_1(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            //takes information from row selected and pre-populates invoice.cs with these values
            hideColumns();
            SetValueForInvoiceNo = dgv_InvoiceDrafts.CurrentRow.Cells[0].Value.ToString();
            SetValueForDate = dgv_InvoiceDrafts.CurrentRow.Cells[1].Value.ToString();
            SetValueForFirstName = dgv_InvoiceDrafts.CurrentRow.Cells[2].Value.ToString();
            SetValueForLastName = dgv_InvoiceDrafts.CurrentRow.Cells[3].Value.ToString();
            SetValueForPhoneNumber = dgv_InvoiceDrafts.CurrentRow.Cells[4].Value.ToString();
            SetValueForYear = dgv_InvoiceDrafts.CurrentRow.Cells[5].Value.ToString();
            SetValueForMake = dgv_InvoiceDrafts.CurrentRow.Cells[6].Value.ToString();
            SetValueForModel = dgv_InvoiceDrafts.CurrentRow.Cells[7].Value.ToString();
            SetValueForMileage = dgv_InvoiceDrafts.CurrentRow.Cells[8].Value.ToString();
            SetValueForComments = dgv_InvoiceDrafts.CurrentRow.Cells[9].Value.ToString();

            /*invoice.txt_InvoiceNo.Text = dgv_InvoiceDrafts.CurrentRow.Cells[0].Value.ToString();
            invoice.txt_Date.Text = dgv_InvoiceDrafts.CurrentRow.Cells[1].Value.ToString();
            invoice.txt_Year.Text = dgv_InvoiceDrafts.CurrentRow.Cells[5].Value.ToString();
            invoice.txt_Make.Text = dgv_InvoiceDrafts.CurrentRow.Cells[6].Value.ToString();
            invoice.txt_Model.Text = dgv_InvoiceDrafts.CurrentRow.Cells[7].Value.ToString();
            invoice.txt_Mileage.Text = dgv_InvoiceDrafts.CurrentRow.Cells[8].Value.ToString();
            invoice.txt_FirstName.Text = dgv_InvoiceDrafts.CurrentRow.Cells[2].Value.ToString();
            invoice.txt_LastName.Text = dgv_InvoiceDrafts.CurrentRow.Cells[3].Value.ToString();
            invoice.txt_PhoneNumber.Text = dgv_InvoiceDrafts.CurrentRow.Cells[4].Value.ToString();
            invoice.txt_Comments.Text = dgv_InvoiceDrafts.CurrentRow.Cells[9].Value.ToString();*/
            if (dgv_InvoiceDrafts.CurrentRow.Cells[10].Value.ToString() == "Yes")
        {
           // SetValueForTaxExempt =
                    
        }
        else
        {
                // SetValueForTaxExempt = cb_TaxExempt.Items[1];
        }


        invoice.DraftCount = 1;
            // invoice.cb_TaxExempt.SelectedIndex = dgv_InvoiceDrafts.CurrentRow.Cells[9].Value.ToString();
            // Here we have the delete function to delete the draft when it is opened again
            
            cmd = new SqlCommand("DELETE FROM tbl_invoice_draft WHERE invoice_number = @invoiceNumber", con);
            con.Open();
            cmd.Parameters.AddWithValue("@invoiceNumber", invoice_txt.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            invoice.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            // if statement which checks to see if user selected a invoice to delete first
            if (invoice_txt.Text == "")
            {
                string message1 = "Please select an Invoice Number";

                string title1 = "Delete Record";
                DialogResult resul1t = MessageBox.Show(message1, title1);
            }
            else
            {
                string message = "Are you sure you want to delete?";
                string title = "Delete Record";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tbl_invoice_draft WHERE invoice_number = @invoiceNumber", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@invoiceNumber", invoice_txt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully");
                    con.Close();
                    refreshdata();
                    ClearData();
                }
            }
        }

        
        }
    }


