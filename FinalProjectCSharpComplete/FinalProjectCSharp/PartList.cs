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
    public partial class PartList : Form
    {
        // Setting our connection string, and a few variables to hold our commands and adapters.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InvoiceProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;

        public PartList()
        {
            InitializeComponent();
        }

        // This method will assign our connection string to a variable which we will use to execute a new SqlConnection. We will then
        // use a DataReader to parse the data from our SqlCommand into our DataTable and load it onto our GridViewer so we can see all the
        // enteries within our database.
        private DataTable GetPartsList()
        {
            DataTable dtPartsList = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["FinalProjectCSharp.Properties.Settings.InvoiceProjectConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_parts", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtPartsList.Load(reader);
                }
            }

            return dtPartsList;
        }

        // This Method will set all the text boxes to empty strings
        public void ClearData()
        {
            txt_PartNumber.Text = "";
            txt_Description.Text = "";
            txt_PartId.Text = "";
            
        }

        // This method will execute a new SQL command that will fetch all the data from the database, which will repopulate the table
        // within grid viewer so that we can see the updates in realtime.
        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_parts", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv_PartList.DataSource = dt;
        }


        // ON LOAD -- we will load the DataGridViewer by calling our GetPartsList() method, and hide the button controls in our GroupBox
        private void PartList_Load(object sender, EventArgs e)
        {
            dgv_PartList.DataSource = GetPartsList();
            gb_Information.Hide();
            dgv_PartList.DataSource = this.PartSearch();
        }

        // ADD BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Add Part" and change the
        // button to say "ADD" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Add Part";
            btn_AddNew.Text = "ADD";
            ClearData();
        }

        // EDIT BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Update Part" and change the
        // button to say "U[DATE" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Update Part";
            btn_AddNew.Text = "UPDATE";
            ClearData();
        }

        // DELETE BUTTON -- We will show the controls in our GroupBox as well as change the name of the GroupBox to "Delete Part" and change the
        // button to say "DELETE" then we will run our ClearData() method to make sure the boxes are empty by default.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gb_Information.Show();
            gb_Information.Text = "Delete Part";
            btn_AddNew.Text = "DELETE";
            ClearData();
        }

        // EXIT -- This will terminate the current window, and open a new main window
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // When a row on the DataGridViewer is selected the values will be assigned to the corresponding TextBoxes according to the row.Cells
        private void dgv_PartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row
            {
                DataGridViewRow row = dgv_PartList.Rows[e.RowIndex];
                txt_PartId.Text = row.Cells[0].Value.ToString();
                txt_PartNumber.Text = row.Cells[1].Value.ToString();
                txt_Description.Text = row.Cells[2].Value.ToString();               
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            // If the text of the button is equal to DELETE and the txt_PartNumber textbox is not empty, we will execute a query command to 
            // delete the entry selected using the txt_PartNumber which will prompt us with a message box to confirm we want to delete the entry,
            // and if we select yes then it will be deleted from out database. We will then refresh the GridViewer so we can see our revisions,
            // and clear the data of the textboxes for additional queries.
            if (btn_AddNew.Text == "DELETE")
            {
                if (txt_PartNumber.Text != "")
                {
                    string message = "Are you sure you want to delete?";
                    string title = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM tbl_parts WHERE part_id = @partID", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@partID", txt_PartId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully");
                        con.Close();
                        refreshdata();
                        ClearData();
                    }
                }
            }

            // If the text of the button is equal to UPDATE, we will execute a query command to update all the fields using the tbl_parts
            // which if successful will give us a message box indicating the update was successful. It will then refresh the GridViewer showing
            // us the update and will clear all the text boxes for additional queries.
            if (btn_AddNew.Text == "UPDATE")
            {
                cmd = new SqlCommand("UPDATE tbl_parts SET part_number = @partNum, part_description = @partDesc " +
                                        "WHERE part_id = @partId", con);
                con.Open();
                cmd.Parameters.AddWithValue("@partId", txt_PartId.Text);
                cmd.Parameters.AddWithValue("@partNum", txt_PartNumber.Text);
                cmd.Parameters.AddWithValue("@partDesc", txt_Description.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                refreshdata();
                ClearData();
            }

            // If the text of the button is equal to ADD, we will execute a query command to insert all the fields using the tbl_parts
            // which if successful will give us a message box indicating the insert was successful. It will then refresh the GridViewer showing
            // us the updated records and will clear all the text boxes for additional queries.
            if (btn_AddNew.Text == "ADD")
            {
                cmd = new SqlCommand("INSERT INTO tbl_parts (part_number, part_description)  VALUES (@partNum, @partDesc)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@partNum", txt_PartNumber.Text);
                cmd.Parameters.AddWithValue("@partDesc", txt_Description.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                con.Close();
                refreshdata();
                ClearData();
            }
        }

        // This function will create a query to search all of our database fields for a match related to our text entered within txt_Search. 
        // And show us the results in our DataGridViewer.
        private DataTable PartSearch()
        {
            string query = "SELECT part_id, part_number, part_description FROM tbl_parts";
            query += " WHERE part_id LIKE '%' + @SearchTerm + '%'";
            query += " OR part_number LIKE '%' + @SearchTerm + '%'";
            query += " OR part_description LIKE '%' + @SearchTerm + '%'";
            query += " OR @SearchTerm = ''";
                      
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

        // CLEAR BUTTON -- Will reset the search button and the DataGridViewer.
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            dgv_PartList.DataSource = this.PartSearch();
        }

        // SEARCH BUTTON -- will return the results of your search query using our PartSearch() method.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_PartList.DataSource = this.PartSearch();
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

        // Here we are going to generate an EXCEL Application to store our backup information.
        private void btn_BackupData_Click(object sender, EventArgs e)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "PartsListBackup" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xls";

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
            worksheet.Name = "Part's List Backup";
            // Storing the Header names inside the EXCEL Application
            for (int i = 1; i < dgv_PartList.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_PartList.Columns[i - 1].HeaderText;
            }
            // Storing each of the rows, and columns data within our EXCEL Application
            for (int i = 0; i < dgv_PartList.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_PartList.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_PartList.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Now we are going to save the file
            workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing);
        }

    }
}
