using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11___COSC_31112
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            //Load the database
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlquery = "SELECT Account_name FROM Account";

                    using (SqlCommand command = new SqlCommand(sqlquery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Load data into a DataTable
                            DataTable dataTableAccount = new DataTable();
                            DataTable dataTableSubtask = new DataTable();
                            dataTableAccount.Load(reader);

                            // Set the DataSource  of the ComboBox to the DataTable
                            cmbAccount.DataSource = dataTableAccount;
                            cmbAccount.DisplayMember = "Account_name";
                            cmbAccount.ValueMember = "Account_name";

                        }
                    }
                    connection.Close(); // Close the connection with the database
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void incomelbl_Click(object sender, EventArgs e)
        {

        }

        private void editAccontsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            addNewAcc form3 = new addNewAcc();
            form3.Show();
        }

        private void addSubTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddNewSubT form4 = new frmAddNewSubT();
            form4.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            deleteAcc form5 = new deleteAcc();
            form5.Show();
        }

        private void deleteSubtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 form6 = new Form6();
            form6.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            
        }

        private decimal GetCurrentAccountBalance(SqlConnection connection, string accName)
        {

            try
            {
                string query = "SELECT Balance FROM Account WHERE Account_name = @accountName";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountName", accName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in GetAccountbalance() method : " + e.ToString());
            }

            return 0.00m;

        }

        private decimal GetAccountIncome(SqlConnection connection, string accName)
        {
            try
            {
                string query = "SELECT Income FROM Account WHERE Account_name=@accountName";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountName", accName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in GetAccountIncome() method : " + e.Message.ToString());

            }
            return 0.00m;

        }

        private decimal GetAccountExpence(SqlConnection connection, string accName)
        {
            try
            {
                string query = "SELECT Expence FROM Account WHERE Account_name=@accountID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountID", accName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in GetAccountExpence() method : " + e.Message.ToString());

            }
            return 0.00m;

        }

        private string GetAccountDescription(SqlConnection connection, string accName)
        {
            try
            {
                string query = "SELECT Account_description FROM Account WHERE Account_name=@accountName";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountName", accName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToString(result);
                    }


                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in GetAccountIncome() method : " + e.Message.ToString());

            }
            return string.Empty;


        }

        



        private void btnSummary_Click_1(object sender, EventArgs e)
        {
            // Form7 Form = new Form7();
            // Form.Show();
        }

        private void btnSubTask_Click(object sender, EventArgs e)
        {
            // Form8 Form = new Form8();
            // Form.Show();
        }

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cmbAccount.SelectedItem;
            string accName = selectedRow["Account_name"].ToString();




            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                // Get current account balance, income, and expenses
                decimal currentIncome = GetAccountIncome(connection, accName);
                decimal currentExpence = GetAccountExpence(connection, accName);
                decimal currentBalance = GetCurrentAccountBalance(connection, accName);
                string accDesc = GetAccountDescription(connection, accName);
                lblAccIncome.Text = currentIncome.ToString();
                lblAccBalance.Text = currentBalance.ToString();
                lblAccExpence.Text = currentExpence.ToString();
                lblAccDec.Text = "Account Description :";

                if (lblAccDescription.Text == "")
                {
                    lblAccDescription.Text = "No Description";
                    lblAccDescription.Text = accDesc.ToString();

                }
                else
                {
                    lblAccDescription.Text = accDesc.ToString();

                }





                connection.Close();
            }
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            lblAccIncome.Text = string.Empty;
            lblAccBalance.Text = string.Empty;
            lblAccExpence.Text = string.Empty;
            lblAccDec.Text = string.Empty;
            lblAccDescription.Text = string.Empty;
        }

        private void btnAccSum_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form=new Form7();
            form.Show();
        }
    }
}

