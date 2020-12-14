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
    public partial class Quote : Form
    {
        public int DraftCount;
        public Quote()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString);
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter sda;

        //Retrieve the data for the parts and labour table
        private DataTable GetPartAndLabourList()
        {
            DataTable dtPartAndLabour = new DataTable();
            //dgv_QuotePartsAndLabour.ColumnCount = 8;

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT quantity AS 'Qty/Hrs', part_number AS 'Part#', part_name AS 'Part Name', price AS 'Price', discount AS 'Discount', hst AS 'HST(13%)', VAT, total AS 'Total' FROM tbl_quote_parts_labour WHERE quote_number LIKE @quoteNo", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@quoteNo", txt_QuoteNo.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtPartAndLabour.Load(reader);
                }
            }

            return dtPartAndLabour;
        }

        //On page load
        private void Quote_Load(object sender, EventArgs e)
        {

            dgv_QuotePartsAndLabour.DataSource = GetPartAndLabourList();

            //DATE FUNCTION - Setting todays date to today and then setting txt_Date to show only todays date
            DateTime todaysDate = DateTime.Today;
            txt_Date.Text = todaysDate.Date.ToString("M/d/yyyy");

            //INVOICE NUMBER FUNCTION - Setting the invoice number to display the newest invoice number from the table
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand cmd = new SqlCommand("SELECT quote_number FROM tbl_quote", con);

            myReader = cmd.ExecuteReader();
            if (DraftCount == 0)
            {
                while (myReader.Read())
                {
                    txt_QuoteNo.Text = (myReader["quote_number"].ToString());
                }
            }
            con.Close();

            if (Main.newInvoice == 1)
            {
                txt_FirstName.Text = InvoiceCustomerSearch.SetValueForFirstName;
                txt_LastName.Text = InvoiceCustomerSearch.SetValueForLastName;
                txt_PhoneNumber.Text = InvoiceCustomerSearch.SetValueForPhoneNumber;
                txt_Year.Text = InvoiceCustomerSearch.SetValueForYear;
                txt_Make.Text = InvoiceCustomerSearch.SetValueForMake;
                txt_Model.Text = InvoiceCustomerSearch.SetValueForModel;
                txt_Mileage.Text = InvoiceCustomerSearch.SetValueForMileage;
                this.Refresh();
            }

            /*  if(DraftCount ==0)
             // {
                  ClearData();
             }*/

            // IF LOADING A DRAFT THAT IS EXISTING 
            if (DraftCount == 1)
            {
 
                txt_QuoteNo.Text = QuoteDraft.SetValueForQuoteNo;
                txt_Comments.Text = QuoteDraft.SetValueForComments;
                txt_Date.Text = todaysDate.Date.ToString("M/d/yyyy");
                // cb_TaxExempt.Text = InvoiceDraft.se;
                txt_FirstName.Text = QuoteDraft.SetValueForFirstName;
                txt_LastName.Text = QuoteDraft.SetValueForLastName;
                txt_PhoneNumber.Text = QuoteDraft.SetValueForPhoneNumber;
                txt_Year.Text = QuoteDraft.SetValueForYear;
                txt_Make.Text = QuoteDraft.SetValueForMake;
                txt_Model.Text = QuoteDraft.SetValueForModel;
                txt_Mileage.Text = QuoteDraft.SetValueForMileage;
                this.Refresh();

                dgv_QuotePartsAndLabour.DataSource = GetPartAndLabourList();
                //refreshdata();

                //Display the SUBTOTAL
                double subTotal = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum();

                txt_Subtotal.Text = Math.Round(subTotal / 1.13, 2).ToString();

                //Display the TOTAL purchase amount and HST
                if (cb_TaxExempt.Text == "Yes")
                {
                    double grandTotal = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                         where row.Cells[7].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum();

                    txt_Total.Text = Math.Round(grandTotal / 1.13, 2).ToString();
                    txt_Hst.Text = "0.00";
                }
                else
                {
                    txt_Total.Text = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                      where row.Cells[7].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

                    txt_Hst.Text = Math.Round(double.Parse(txt_Subtotal.Text) * 0.13, 2).ToString();
                }
                // DraftCount = 0;
            }
        }

        //CLEAR DATA
        public void ClearData()
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_PhoneNumber.Text = "";
            txt_Year.Text = "";
            txt_Make.Text = "";
            txt_Model.Text = "";
            txt_Mileage.Text = "";
        }

        //REFRESH TABLE
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT quantity AS 'Qty/Hrs', part_number AS 'Part#', part_name AS 'Part Name', price AS 'Price', discount AS 'Discount', hst AS 'HST(13%)', VAT, total AS 'Total' FROM tbl_quote_parts_labour WHERE quote_number LIKE @quoteNo", con);
            con.Open();
            cmd.Parameters.AddWithValue("@quoteNo", txt_QuoteNo.Text);
            sda = new SqlDataAdapter(cmd);
            DataTable dtPartAndLabour = new DataTable();
            sda.Fill(dtPartAndLabour);
            con.Close();
            dgv_QuotePartsAndLabour.DataSource = dtPartAndLabour;
        }

        /**************************************************************************** CUSTOMER INFO **********************************************************************/
        private void btn_Save_Click(object sender, EventArgs e)
        {

            /********************* Quote Data ******************************/

            //Quote number validation
            if (txt_QuoteNo.Text == "")
            {
                MessageBox.Show("Please Enter an Invoice Number");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_QuoteNo.Text, "^[0-9 ]"))
            {
                txt_QuoteNo.Clear();
                MessageBox.Show("Please Enter a Valid Invoice Number");
            }

            //Date validation
            else if (txt_Date.Text == "")
            {
                MessageBox.Show("Please enter a Date");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Date.Text, "^[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]"))
            {
                MessageBox.Show("Please Enter a Valid Date (MM-DD-YYYY)");
            }

            /********************* Customer Data ******************************/

            //Customer First Name Validation
            else if (txt_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter a First Name");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_FirstName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter a Valid First Name");
            }

            //Customer Last Name Validation
            else if (txt_LastName.Text == "")
            {
                MessageBox.Show("Please Enter a Last Name");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_LastName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter a Valid Last Name");
            }

            //Customer Phone Number Validation
            else if (txt_PhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter an Phone Number");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_PhoneNumber.Text, "^[0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Phone Number");
            }

            /********************* Vehicle Data ******************************/

            //Year validation
            else if (txt_Year.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Year");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Year.Text, "^[0-9][0-9][0-9][0-9]"))
            {
                MessageBox.Show("Please Enter a Valid Year (YYYY)");
            }

            //Make validation
            else if (txt_Make.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Make");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Make.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Make");
            }

            //Model validation
            else if (txt_Model.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Model");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Model.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Model");
            }

            //Milage validation
            else if (txt_Mileage.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Mileage");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Mileage.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Mileage");
            }

            /********************* Parts and Labour Data ******************************/
            else if (txt_Total.Text == "0.00")
            {
                MessageBox.Show("Please Enter an Item");
            }

            if (txt_QuoteNo.Text != "" && txt_Date.Text != "" && txt_Model.Text != "" && txt_Make.Text != "" && txt_Year.Text != "" && txt_Mileage.Text != "" && txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_PhoneNumber.Text != "" && txt_Total.Text != "0.00")
            {
                cmd = new SqlCommand("UPDATE tbl_quote SET date_saved = @date, first_Name = @firstName, last_Name = @lastName, phone_number = @phNumber, vehicle_year = @year, vehicle_make = @make, vehicle_model = @model, vehicle_mileage =  @mileage WHERE quote_number = @quoteNumber", con);
                con.Open();
                cmd.Parameters.AddWithValue("@quoteNumber", txt_QuoteNo.Text);
                cmd.Parameters.AddWithValue("@date", txt_Date.Text);
                cmd.Parameters.AddWithValue("@firstName", txt_FirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txt_LastName.Text);
                cmd.Parameters.AddWithValue("@phNumber", txt_PhoneNumber.Text);
                cmd.Parameters.AddWithValue("@year", txt_Year.Text);
                cmd.Parameters.AddWithValue("@make", txt_Make.Text);
                cmd.Parameters.AddWithValue("@model", txt_Model.Text);
                cmd.Parameters.AddWithValue("@mileage", txt_Mileage.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Quote Saved");
                Main main = new Main();
                main.Show();
                this.Hide();

            }
        }

        // EXIT
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Exit? All progress will be lost.";
            string title = "Exit Quote";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM tbl_quote_parts_labour WHERE quote_number = @quoteNum", con);
                con.Open();
                cmd.Parameters.AddWithValue("@quoteNum", txt_QuoteNo.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("DELETE FROM tbl_quote WHERE quote_number = @quoteNum", con);
                con.Open();
                cmd.Parameters.AddWithValue("@quoteNum", txt_QuoteNo.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearData();

                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        //Search for Customer in Customer Table in Database
        private void btn_Search_Click(object sender, EventArgs e)
        {
            InvoiceCustomerSearch cusSearch = new InvoiceCustomerSearch();
            cusSearch.Show();
            this.Hide();
            InvoiceCustomerSearch.displayInfo = 1;
        }

        /**************************************************************************** PARTS AND LABOUR **********************************************************************/

        public void ClearPartsLabourData()
        {
            txt_QuantityHours.Clear();
            txt_Price.Clear();
            txt_PartName.Clear();
            txt_PartNumber.Clear();
            txt_Discount.Clear();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            /********************* Quote Data ******************************/

            //Quote number validation
            if (txt_QuoteNo.Text == "")
            {
                MessageBox.Show("Please Enter an Invoice Number");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_QuoteNo.Text, "^[0-9 ]"))
            {
                txt_QuoteNo.Clear();
                MessageBox.Show("Please Enter a Valid Invoice Number");
            }

            //Date validation
            else if (txt_Date.Text == "")
            {
                MessageBox.Show("Please enter a Date");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Date.Text, "^[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]"))
            {
                MessageBox.Show("Please Enter a Valid Date (MM-DD-YYYY)");
            }

            /********************* Customer Data ******************************/

            //Customer First Name Validation
            else if (txt_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter a First Name");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_FirstName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter a Valid First Name");
            }

            //Customer Last Name Validation
            else if (txt_LastName.Text == "")
            {
                MessageBox.Show("Please Enter a Last Name");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_LastName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter a Valid Last Name");
            }

            //Customer Phone Number Validation
            else if (txt_PhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter an Phone Number");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_PhoneNumber.Text, "^[0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Phone Number");
            }

            /********************* Vehicle Data ******************************/

            //Year validation
            else if (txt_Year.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Year");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Year.Text, "^[0-9][0-9][0-9][0-9]"))
            {
                MessageBox.Show("Please Enter a Valid Year (YYYY)");
            }

            //Make validation
            else if (txt_Make.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Make");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Make.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Make");
            }

            //Model validation
            else if (txt_Model.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Model");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Model.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Model");
            }

            //Milage validation
            else if (txt_Mileage.Text == "")
            {
                MessageBox.Show("Please Enter a Vehicle Mileage");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Mileage.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Please Enter a Valid Mileage");
            }

            /********************* Parts and Labour Data ******************************/

            //Quantity Validation
            else if (txt_QuantityHours.Text == "")
            {
                MessageBox.Show("Please Enter a Quantity/Hours");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_QuantityHours.Text, "^[0-9-.]*$"))
            {
                txt_QuantityHours.Clear();
                MessageBox.Show("Please Enter a Valid Quantity/Hours");
            }

            //Part Number Validation
            else if (txt_PartNumber.Text == "")
            {
                MessageBox.Show("Please Enter a Part Number");
            }

            //Part Name Validation
            else if (txt_PartName.Text == "")
            {
                MessageBox.Show("Please Enter a Part Name");
            }

            //Price Validation
            else if (txt_Price.Text == "")
            {
                MessageBox.Show("Please Enter a Price");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Price.Text, "^[0-9-.]*$"))
            {
                txt_Price.Clear();
                MessageBox.Show("Please Enter a Valid Price");
            }

            //Discount Validation
            else if (txt_Discount.Text == "")
            {
                MessageBox.Show("Please Enter a Discount");
            }
            else if (double.Parse(txt_Discount.Text) > 101)
            {
                txt_Discount.Clear();
                MessageBox.Show("Discount must be less than 100%");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Discount.Text, "^[0-9-.]*$"))
            {
                txt_Discount.Clear();
                MessageBox.Show("Please Enter a Valid Discount");
            }

            //Inserting the Data into the datable, as long as the following text boxes have text
            if (txt_QuoteNo.Text != "" && txt_Date.Text != "" && txt_Model.Text != "" && txt_Make.Text != "" && txt_Year.Text != "" && txt_Mileage.Text != "" && txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_PhoneNumber.Text != "" && txt_QuantityHours.Text != "" && txt_PartNumber.Text != "" && txt_PartName.Text != "" && txt_Price.Text != "" && txt_Discount.Text != "")
            {
                //Get the part Name, Number, Price, Quantity and if any discount is to be applied.
                double quantityHours = double.Parse(txt_QuantityHours.Text);
                string partNumber = txt_PartNumber.Text;
                string partName = txt_PartName.Text;
                double price = Math.Round(double.Parse(txt_Price.Text), 2);
                double discount = double.Parse(txt_Discount.Text);
                string VAT = "0";

                double discountAmount = Math.Round((price * quantityHours) * (discount / 100));
                double HST = Math.Round(((price * quantityHours - discountAmount) * 0.13), 2);
                double Total = Math.Round(((price * quantityHours)-((price * quantityHours)*(discount/100)))+HST, 2);

                cmd = new SqlCommand("INSERT INTO tbl_quote_parts_labour (quote_number, quantity, part_number, part_name, price, discount, hst, VAT, total) VALUES (@quoteNo, @quantity, @partNo, @partName, @price, @discount, @hst, @VAT, @total)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@quoteNo", txt_QuoteNo.Text);
                cmd.Parameters.AddWithValue("@quantity", txt_QuantityHours.Text);
                cmd.Parameters.AddWithValue("@partNo", txt_PartNumber.Text);
                cmd.Parameters.AddWithValue("@partName", txt_PartName.Text);
                cmd.Parameters.AddWithValue("@price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@discount", discountAmount);
                cmd.Parameters.AddWithValue("@hst", HST);
                cmd.Parameters.AddWithValue("@VAT", VAT);
                cmd.Parameters.AddWithValue("@total", Total);
                cmd.ExecuteNonQuery();
                con.Close();
                refreshdata();
                ClearPartsLabourData();

                //Display the SUBTOTAL
                double subTotal = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum();

                txt_Subtotal.Text = Math.Round(subTotal / 1.13, 2).ToString();

                //Display the TOTAL purchase amount and HST
                if (cb_TaxExempt.Text == "Yes")
                {
                    double grandTotal = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                         where row.Cells[7].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum();

                    txt_Total.Text = Math.Round(grandTotal / 1.13, 2).ToString();
                    txt_Hst.Text = "0.00";
                }
                else
                {
                    txt_Total.Text = (from DataGridViewRow row in dgv_QuotePartsAndLabour.Rows
                                      where row.Cells[7].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

                    txt_Hst.Text = Math.Round(double.Parse(txt_Subtotal.Text) * 0.13, 2).ToString();
                }


            }


        }

        private void btn_SaveAsDraft_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO tbl_quote_draft(quote_number, date, first_name, last_name, phone_number , v_year , v_make , v_model , mileage, comments, tax_exempt) VALUES  (@quoteNumber, @date, @firstName, @lastName, @phNumber, @year, @make, @model, @mileage, @comments, @taxExempt)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@quoteNumber", txt_QuoteNo.Text);
            cmd.Parameters.AddWithValue("@date", txt_Date.Text);
            cmd.Parameters.AddWithValue("@firstName", txt_FirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", txt_LastName.Text);
            cmd.Parameters.AddWithValue("@phNumber", txt_PhoneNumber.Text);
            cmd.Parameters.AddWithValue("@year", txt_Year.Text);
            cmd.Parameters.AddWithValue("@make", txt_Make.Text);
            cmd.Parameters.AddWithValue("@model", txt_Model.Text);
            cmd.Parameters.AddWithValue("@mileage", txt_Mileage.Text);
            cmd.Parameters.AddWithValue("@comments", txt_Comments.Text);
            cmd.Parameters.AddWithValue("@taxExempt", cb_TaxExempt.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Draft Saved");
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
