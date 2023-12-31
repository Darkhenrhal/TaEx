using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Group_11___COSC_31112
{
    public partial class frmAddNewSubT : Form
    {
        //create list for the items

        List<string> AccountNames = new List<string>();
        public frmAddNewSubT()
        {
            InitializeComponent();
        }

        private void frmAddNewSubT_Load(object sender, EventArgs e)
        {
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
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Set the DataSource property of the ComboBox to the DataTable
                            cmbAccounts.DataSource = dataTable;
                            cmbAccounts.DisplayMember = "Account_name";
                            cmbAccounts.ValueMember = "Account_name";
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


        private void subNewSubT_Click_1(object sender, EventArgs e)
        {
            if (txtNewSubT.Text == "" || txtNewSubDesc.Text == "" || cmbSubTCat.SelectedItem == null || txtAmount.Text == "")
            {
                MessageBox.Show("Please fill all items", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRowView selectedRow = (DataRowView)cmbAccounts.SelectedItem;
                string accountName = selectedRow["Account_name"].ToString();
                string subtask_name = txtNewSubT.Text;
                string subtask_desc = txtNewSubDesc.Text;
                string subtask_cat = cmbSubTCat.SelectedItem.ToString();
                int acc_id = GetAccountId(accountName);
                decimal amount_money = decimal.Parse(txtAmount.Text);

                /* string some = cmbAccounts.SelectedItem.ToString();
                 MessageBox.Show("Account Name :" + some);*/



                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        if (cmbSubTCat.SelectedItem == "Income")
                        {
                            string sqlquery = "INSERT INTO Subtask (Subtask_name, Subtask_expence, Subtask_income, Account_id, Subtask_description, Subtask_catagory) VALUES (@Subtask_name, @Subtask_expence, @Subtask_income, @Account_id, @Subtask_description, @Subtask_catagory)";

                            using (SqlCommand command = new SqlCommand(sqlquery, connection))
                            {
                                command.Parameters.AddWithValue("@Subtask_name", subtask_name);
                                command.Parameters.AddWithValue("@Subtask_description", subtask_desc);
                                command.Parameters.AddWithValue("@Subtask_catagory", subtask_cat);
                                command.Parameters.AddWithValue("@Subtask_income", amount_money);
                                command.Parameters.AddWithValue("@Subtask_expence", "0.00");
                                command.Parameters.AddWithValue("@Account_id", acc_id);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Data inserted to the Subtask successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear input fields after successful submission if desired
                                txtNewSubT.Text = string.Empty;
                                txtNewSubDesc.Text = string.Empty;
                                txtAmount.Text = string.Empty;
                                cmbSubTCat.SelectedItem = null;

                                connection.Close();//end the connection with database
                            }
                        }
                        else
                        {

                            string sqlquery = "INSERT INTO Subtask (Subtask_name, Subtask_expence, Subtask_income, Account_id, Subtask_description, Subtask_catagory) VALUES (@Subtask_name, @Subtask_expence, @Subtask_income, @Account_id, @Subtask_description, @Subtask_catagory)";


                            using (SqlCommand command = new SqlCommand(sqlquery, connection))
                            {
                                command.Parameters.AddWithValue("@Subtask_name", subtask_name);
                                command.Parameters.AddWithValue("@Subtask_description", subtask_desc);
                                command.Parameters.AddWithValue("@Subtask_catagory", subtask_cat);
                                command.Parameters.AddWithValue("@Subtask_income", "0.00");
                                command.Parameters.AddWithValue("@Subtask_expence", amount_money);
                                command.Parameters.AddWithValue("@Account_id", acc_id);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Data inserted to the Subtask successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear input fields after successful submission if desired
                                txtNewSubT.Text = string.Empty;
                                txtNewSubDesc.Text = string.Empty;
                                txtAmount.Text = string.Empty;
                                cmbSubTCat.SelectedItem = null;

                                connection.Close();//end the connection with database
                            }
                        }
                        connection.Open();
                        // Get current account balance
                        decimal currentIncome = GetAccountIncome(connection, acc_id);
                        decimal currentExpence = GetAccountExpence(connection, acc_id);
                        decimal currentBalance = GetCurrentAccountBalance(connection, acc_id);

                        // Calculate new balance after adding the subtask amount
                        decimal newBalance = subtask_cat == "Income" ? currentBalance + amount_money : currentBalance - amount_money;
                        decimal newIncome = subtask_cat == "Income" ? currentIncome + amount_money : currentIncome + 0;
                        decimal newExpence = subtask_cat == "Expence" ? currentExpence + amount_money : currentExpence + 0;

                       // MessageBox.Show("currentIn :" + currentIncome + "\n curE    " + currentExpence + "\n CURRBAL :" + currentBalance + "\n" + newIncome + "\n" + newExpence + "\n" + newBalance);

                        // Update the Account table with the new balance
                        UpdateAccountBalance(connection, acc_id, newBalance, newIncome, newExpence);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in Database(Subtask) Ocured " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private int GetAccountId(string accountName)
        {
            int accId = 0;
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Account_id FROM Account WHERE Account_name = @accountName", connection))
                {
                    cmd.Parameters.AddWithValue("@accountName", accountName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        accId = Convert.ToInt32(result);
                    }
                }
            }
            //MessageBox.Show("The Account Id is" + accId);
            return accId;
        }


        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form2 = new Home();
            form2.Show();
        }

        private void editAcc_Click(object sender, EventArgs e)
        {

        }

        private void newAcc_Click(object sender, EventArgs e)
        {
            this.Hide();

            addNewAcc form3 = new addNewAcc();
            form3.Show();

        }

        private decimal GetCurrentAccountBalance(SqlConnection connection, int accountId)
        {

            try
            {
                string query = "SELECT Balance FROM Account WHERE Account_id = @accountId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
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

        private decimal GetAccountIncome(SqlConnection connection, int accountId)
        {
            try
            {
                string query = "SELECT Income FROM Account WHERE Account_id=@accountID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
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

        private decimal GetAccountExpence(SqlConnection connection, int accountId)
        {
            try
            {
                string query = "SELECT Expence FROM Account WHERE Account_id=@accountID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
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

        private void UpdateAccountBalance(SqlConnection connection, int accountId, decimal newBalance, decimal newIncome, decimal newExpence)
        {
            SqlTransaction transaction = null;

            try
            {

                transaction = connection.BeginTransaction();

                string queryBalance = "UPDATE Account SET Balance = @newBalance, Income = @newIncome, Expence = @newExpence WHERE Account_id = @accountId";

                using (SqlCommand cmd = new SqlCommand(queryBalance, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@newBalance", newBalance);
                    cmd.Parameters.AddWithValue("@newIncome", newIncome);
                    cmd.Parameters.AddWithValue("@newExpence", newExpence);
                    cmd.Parameters.AddWithValue("@accountId", accountId);

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Account balance updated successfully.");
            }
            catch (Exception e)
            {
                transaction?.Rollback();
                MessageBox.Show("Error occured in UpdateAccountbalance() method : " + e.ToString());
            }
            finally
            {
                transaction?.Dispose();

            }
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

        private void getDetailedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form2 = new Home();
            form2.Show();
        }

        private void btnAddNewSubT_Click(object sender, EventArgs e)
        {
            txtNewSubT.Text = null;
            txtAmount.Text = null;
            txtNewSubDesc.Text = null;
        }

        private void frmAddNewSubT_Load_1(object sender, EventArgs e)
        {

        }

        private void getDetailedReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddNewSubT_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

