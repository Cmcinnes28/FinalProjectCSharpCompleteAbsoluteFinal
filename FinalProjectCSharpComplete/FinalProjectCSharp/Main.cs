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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Creating a variable to check if we are creating a new Invoice
        public static int newInvoice;

        // INVOICE DRAFTS
        private void btn_InvoiceDrafts_Click(object sender, EventArgs e)
        {
            InvoiceDraft invoicedraft = new InvoiceDraft();
            invoicedraft.Show();
            this.Hide();
        }

        // QUOTE DRAFTS
        private void btn_QuoteDrafts_Click(object sender, EventArgs e)
        {
            QuoteDraft quotedraft = new QuoteDraft();
            quotedraft.Show();
            this.Hide();
        }

        // EXIT
        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // NEW QUOTE
        private void btn_NewQuote_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString);
            SqlCommand cmd;

            cmd = new SqlCommand("INSERT INTO tbl_quote(first_name) VALUES(DEFAULT)", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Quote quote = new Quote();
            quote.Show();
            this.Hide();
        }

        // NEW INVOICE
        private void btn_NewInvoice_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString);
            SqlCommand cmd;
                            
            cmd = new SqlCommand("INSERT INTO tbl_invoice(first_name) VALUES(DEFAULT)", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Invoice invoice = new Invoice();
            invoice.Show();
            this.Hide();

        }

        // CUSTOMER LIST
        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerlist = new CustomerList();
            customerlist.Show();
            this.Hide();
        }

        // PART LIST
        private void btn_PartList_Click(object sender, EventArgs e)
        {
            PartList partlist = new PartList();
            partlist.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            newInvoice = 0;
        }

        private void btn_Audit_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit();
            audit.Show();
            this.Hide();
        }
    }
}
