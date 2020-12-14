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
    public partial class Audit : Form
    {
        // Setting our connection string, and a few variables to hold our commands and adapters.
        SqlConnection con = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;

        public Audit()
        {
            InitializeComponent();
        }

        // This method will assign our connection string to a variable which we will use to execute a new SqlConnection. We will then
        // use a DataReader to parse the data from our SqlCommand into our DataTable and load it onto our GridViewer so we can see all the
        // enteries within our database.
        private DataTable GetCompletedInvoices()
        {
            DataTable dtCompletedInvoice = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT INV.invoice_number 'Invoice Number', INV.date_saved 'Date', INV.first_name 'First Name', INV.last_name 'Last Name', SUM(TPL.hst) 'HST', SUM(TPL.total) 'Total' " +
                                                            "FROM tbl_invoice INV INNER JOIN tbl_invoice_parts_labour TPL " +
                                                            "ON INV.invoice_number = TPL.invoice_number " +
                                                            "GROUP BY INV.invoice_number, INV.date_saved, INV.first_name, INV.last_name", con))
                                                            
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtCompletedInvoice.Load(reader);
                    }
                } catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to the Database." + "\n" + ex.Message);
                }
            }

            return dtCompletedInvoice;
        }

        private DataTable GetFilteredInvoices()
        {
            DataTable dtFilteredInvoice = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT INV.invoice_number 'Invoice Number', INV.date_saved 'Date', INV.first_name 'First Name', INV.last_name 'Last Name', SUM(TPL.hst) 'HST', SUM(TPL.total) 'Total' " +
                                                            "FROM tbl_invoice INV INNER JOIN tbl_invoice_parts_labour TPL " +
                                                            "ON INV.invoice_number = TPL.invoice_number " +
                                                            "WHERE INV.date_saved BETWEEN @dateOne AND @dateTwo " +
                                                            "GROUP BY INV.invoice_number, INV.date_saved, INV.first_name, INV.last_name", con))

                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@dateOne", mc_DateOne.SelectionStart.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@dateTwo", mc_DateTwo.SelectionStart.ToString("yyyy-MM-dd"));
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtFilteredInvoice.Load(reader);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to the Database." + "\n" + ex.Message);
                }
            }

            return dtFilteredInvoice;
        }

        private void Audit_Load(object sender, EventArgs e)
        {
            dgv_Audit.DataSource = GetCompletedInvoices();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {          
            dgv_Audit.DataSource = GetCompletedInvoices();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            dgv_Audit.DataSource = this.GetFilteredInvoices();
        }

        private void btn_PrintResults_Click(object sender, EventArgs e)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Monthly Audit" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xls";

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
            worksheet.Name = "Monthly Audit";
            // Storing the Header names inside the EXCEL Application
            for (int i = 1; i < dgv_Audit.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_Audit.Columns[i - 1].HeaderText;
            }
            // Storing each of the rows, and columns data within our EXCEL Application
            for (int i = 0; i < dgv_Audit.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_Audit.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_Audit.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Now we are going to save the file
            workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing);
        }

    }
}
