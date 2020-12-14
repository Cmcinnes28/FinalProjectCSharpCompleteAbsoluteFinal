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
    public partial class QuoteDraft : Form
    {
        public static String SetValueForFirstName = "";
        public static String SetValueForLastName = "";
        public static String SetValueForPhoneNumber = "";
        public static String SetValueForYear = "";
        public static String SetValueForMake = "";
        public static String SetValueForModel = "";
        public static String SetValueForMileage = "";
        public static String SetValueForQuoteNo = "";
        public static String SetValueForDate = "";
        public static String SetValueForComments = "";
        public static String SetValueForTaxExempt = "";
        public static int DraftCount;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt_QuoteDrafts = new DataTable();
        DataGridTableStyle ts = new DataGridTableStyle();
        public QuoteDraft()
        {
            InitializeComponent();
        }
       // This method will assign our connection string to a variable which we will use to execute a new SqlConnection.We will then
        // use a DataReader to parse the data from our SqlCommand into our DataTable and load it onto our GridViewer so we can see all the
        // enteries within our database.
        private DataTable getQuoteDraftTable()
        {
            // DataTable dt_InvoiceDrafts = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT quote_number 'Quote Number', date 'Date', first_name 'First Name', last_name 'Last Name', phone_number 'Phone Number', v_year 'Vehicle Year', v_make 'Vehicle Make', v_model 'Vehicle Model', mileage 'Vehicle Mileage', comments 'Comments' FROM tbl_quote_draft", con))
                {
                    
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt_QuoteDrafts.Load(reader);
                }
            }

            return dt_QuoteDrafts;
        }
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT invoice_number 'Invoice Number', date 'Date', first_name 'First Name', last_name 'Last Name', phone_number 'Phone Number', v_year 'Vehicle Year', v_make 'Vehicle Make', v_model 'Vehicle Model', mileage 'Vehicle Mileage', comments 'Comments' FROM tbl_invoice_draft", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv_QuoteDrafts.DataSource = dt;
        }
        private void hideColumns()
        {
            dgv_QuoteDrafts.Columns["phone number"].Visible = false;
            dgv_QuoteDrafts.Columns["Vehicle Year"].Visible = false;
            dgv_QuoteDrafts.Columns["Vehicle Mileage"].Visible = false;
            dgv_QuoteDrafts.Columns["comments"].Visible = false;
            //this.dgv_QuoteDrafts.Columns["tax_exempt"].Visible = false;
        }
        public void ClearData()
        {
            quote_txt.Text = "";

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void dgv_QuoteDrafts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_QuoteDrafts.Rows[e.RowIndex];
                quote_txt.Text = row.Cells[0].Value.ToString();
            }
        }

        private void QuoteDraft_Load(object sender, EventArgs e)
        {
            dgv_QuoteDrafts.DataSource = getQuoteDraftTable();
            hideColumns();
        }

        // When user clicks delete button a message pops up to confirm user wants to delete selection. if so then the selected row is deleted
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // if statement which checks to see if user selected a invoice to delete first
            if (quote_txt.Text == "")
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
                    cmd = new SqlCommand("DELETE FROM tbl_quote_draft WHERE quote_number = @quoteNumber", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@quoteNumber", quote_txt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully");
                    con.Close();
                    // refreshdata();
                    ClearData();
                }
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            Quote quote = new Quote();
            //takes information from row selected and pre-populates invoice.cs with these values
            hideColumns();
            /*quote.txt_QuoteNo.Text = dgv_QuoteDrafts.CurrentRow.Cells[0].Value.ToString();
            quote.txt_Date.Text = dgv_QuoteDrafts.CurrentRow.Cells[1].Value.ToString();
            quote.txt_Year.Text = dgv_QuoteDrafts.CurrentRow.Cells[5].Value.ToString();
            quote.txt_Make.Text = dgv_QuoteDrafts.CurrentRow.Cells[6].Value.ToString();
            quote.txt_Model.Text = dgv_QuoteDrafts.CurrentRow.Cells[7].Value.ToString();
            quote.txt_Mileage.Text = dgv_QuoteDrafts.CurrentRow.Cells[8].Value.ToString();
            quote.txt_FirstName.Text = dgv_QuoteDrafts.CurrentRow.Cells[2].Value.ToString();
            quote.txt_LastName.Text = dgv_QuoteDrafts.CurrentRow.Cells[3].Value.ToString();
            quote.txt_PhoneNumber.Text = dgv_QuoteDrafts.CurrentRow.Cells[4].Value.ToString();
            quote.txt_Comments.Text = dgv_QuoteDrafts.CurrentRow.Cells[9].Value.ToString();*/
            quote.DraftCount = 1;

            SetValueForQuoteNo = dgv_QuoteDrafts.CurrentRow.Cells[0].Value.ToString();
            SetValueForDate = dgv_QuoteDrafts.CurrentRow.Cells[1].Value.ToString();
            SetValueForFirstName = dgv_QuoteDrafts.CurrentRow.Cells[2].Value.ToString();
            SetValueForLastName = dgv_QuoteDrafts.CurrentRow.Cells[3].Value.ToString();
            SetValueForPhoneNumber = dgv_QuoteDrafts.CurrentRow.Cells[4].Value.ToString();
            SetValueForYear = dgv_QuoteDrafts.CurrentRow.Cells[5].Value.ToString();
            SetValueForMake = dgv_QuoteDrafts.CurrentRow.Cells[6].Value.ToString();
            SetValueForModel = dgv_QuoteDrafts.CurrentRow.Cells[7].Value.ToString();
            SetValueForMileage = dgv_QuoteDrafts.CurrentRow.Cells[8].Value.ToString();
            SetValueForComments = dgv_QuoteDrafts.CurrentRow.Cells[9].Value.ToString();
            // invoice.cb_TaxExempt.SelectedIndex = dgv_InvoiceDrafts.CurrentRow.Cells[9].Value.ToString();
            // Here we have the delete function to delete the draft when it is opened again

            cmd = new SqlCommand("DELETE FROM tbl_quote_draft WHERE quote_number = @quoteNumber", con);
            con.Open();
            cmd.Parameters.AddWithValue("@quoteNumber", quote_txt.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            quote.Show();
            this.Hide();
        }
    }
}
