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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
                            cmbAccNameofSub.DataSource = dataTableAccount;
                            cmbAccNameofSub.DisplayMember = "Account_name";
                            cmbAccNameofSub.ValueMember = "Account_name";

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

        //test
        private void cmbAccNameofSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataRowView selectedRow = (DataRowView)cmbAccNameofSub.SelectedItem;
                    string accountName = selectedRow["Account_name"].ToString();
                    int acc_id = GetAccountId(accountName);

                    connection.Open();
                    string loadSubtasksqlquery = "SELECT Subtask_name FROM Subtask WHERE Account_id=@accountId";

                    using (SqlCommand command = new SqlCommand(loadSubtasksqlquery, connection))
                    {
                        command.Parameters.AddWithValue("@accountId", acc_id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTableSubtask = new DataTable();
                            dataTableSubtask.Load(reader);
                            cmbSubName.DataSource = dataTableSubtask;
                            cmbSubName.DisplayMember = "Subtask_name";
                            cmbSubName.ValueMember = "Subtask_name";
                        }
                    }

                    connection.Close(); // Close the connection with the database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Indexchange" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string GetSubtaskCatagory(string subTaskName)
        {

            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";
            string subtask_cat = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Subtask_catagory FROM Subtask WHERE Subtask_name = @subtaskName", connection))
                {
                    cmd.Parameters.AddWithValue("@subtaskName", subTaskName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        subtask_cat = Convert.ToString(result);
                        return subtask_cat;
                    }
                }
            }
            MessageBox.Show("The Subtask catagory is" + subtask_cat);
            return subtask_cat;
        }

        private decimal GetSubtaskAmount(string subTaskName)
        {
            decimal subtask_Amount = 0;
            string subtask_cat = GetSubtaskCatagory(subTaskName);

            if (subtask_cat == "Income")
            {
                string query = "SELECT Subtask_income FROM Subtask WHERE Subtask_name = @subtaskName";
                subtask_Amount = ExecuteScalarDecimal(query, subTaskName);
            }
            else if (subtask_cat == "Expence")
            {
                string query = "SELECT Subtask_expence FROM Subtask WHERE Subtask_name = @subtaskName";
                subtask_Amount = ExecuteScalarDecimal(query, subTaskName);
            }

            return subtask_Amount;
        }

        private decimal ExecuteScalarDecimal(string query, string parameterValue)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@subtaskName", parameterValue);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            return 0;
        }


        private void deleteSubtask(string Subtask_name, SqlConnection connection)
        {
            SqlTransaction transaction = null;

            try
            {
                transaction = connection.BeginTransaction();

                string querySubtaskDelete = "DELETE FROM Subtask WHERE Subtask_name=@subtask_name";


                using (SqlCommand cmd = new SqlCommand(querySubtaskDelete, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@subtask_name", Subtask_name);

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Subtask Deleted successfully.", "Subtask Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                transaction?.Rollback();
                MessageBox.Show("Error occured in deleteSubtask() method : " + e.ToString());
            }
            finally
            {
                transaction?.Dispose();

            }
        }

        private void btnDelSub_Click(object sender, EventArgs e)
        {


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

        private void btnDelSub_Click_1(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cmbSubName.SelectedItem;
            string subTaskName = selectedRow["Subtask_name"].ToString();
            int acc_id = GetAccountIdbySubtask(subTaskName);
            string subTask_Cat = GetSubtaskCatagory(subTaskName);
            decimal subtask_Amount = GetSubtaskAmount(subTaskName);
            //MessageBox.Show("Account id :"+acc_id+"\n Subtask cat :"+subTask_Cat+ "\nSubtask Amount: "+subtask_Amount);

            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                // Get current account balance, income, and expenses
                decimal currentIncome = GetAccountIncome(connection, acc_id);
                decimal currentExpence = GetAccountExpence(connection, acc_id);
                decimal currentBalance = GetCurrentAccountBalance(connection, acc_id);
                //MessageBox.Show("Current Income :"+currentIncome+ "\nCurrent Expence :"+currentExpence+"\nCurrent Balance :"+currentBalance);
                // Calculate new balance, income, and expenses after removing the subtask
                decimal newBalance = subTask_Cat == "Income" ? currentBalance - subtask_Amount : currentBalance + subtask_Amount;
                decimal newIncome = subTask_Cat == "Income" ? currentIncome - subtask_Amount : currentIncome + 0;
                decimal newExpence = subTask_Cat == "Expence" ? currentExpence - subtask_Amount : currentExpence + 0;
                //MessageBox.Show("New Income :" + newIncome + "\n New Expence :" + newExpence + "\n New Balance :" + newBalance);

                // Update the Account table with the new balance, income, and expenses
                UpdateAccountBalance(connection, acc_id, newBalance, newIncome, newExpence);

                // Delete the subtask
                deleteSubtask(subTaskName, connection);

                connection.Close();
            }
        }

        private int GetAccountIdbySubtask(string subtaskName)
        {
            int accId = 0;
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Account_id FROM Subtask WHERE Subtask_name = @subtaskName", connection))
                {
                    cmd.Parameters.AddWithValue("@subtaskName", subtaskName);
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

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form2 = new Home();
            form2.Show();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void deleteSubtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            deleteAcc form5 = new deleteAcc();
            form5.Show();
        }

       

        private void getDetailedReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home form2 = new Home();
            form2.Show();
        }
    }
}

