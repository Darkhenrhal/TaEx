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
    public partial class deleteAcc : Form
    {
        public deleteAcc()
        {
            InitializeComponent();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cmbAccName.SelectedItem;
            string accountName = selectedRow["Account_name"].ToString();
            string selected_Acc = cmbAccName.Text;
            int acc_id = GetAccountId(accountName);

            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                deleteAccount(selected_Acc, connection, acc_id);
                connection.Close();

            }
        }

        private void deleteAcc_Load(object sender, EventArgs e)
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
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Set the DataSource  of the ComboBox to the DataTable
                            cmbAccName.DataSource = dataTable;
                            cmbAccName.DisplayMember = "Account_name";
                            cmbAccName.ValueMember = "Account_name";
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

        private void deleteAccount(string AccName, SqlConnection connection, int AccId)
        {
            SqlTransaction transaction = null;

            try
            {
                transaction = connection.BeginTransaction();

                string querySubtaskDelete = "DELETE FROM Subtask WHERE Account_id=@accountId";
                string queryAccountDelete = "DELETE FROM Account WHERE Account_name = @accountName";

                using (SqlCommand cmd = new SqlCommand(querySubtaskDelete, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@accountId", AccId);

                    cmd.ExecuteNonQuery();
                }


                using (SqlCommand cmd = new SqlCommand(queryAccountDelete, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@accountName", AccName);

                    cmd.ExecuteNonQuery();
                }


                transaction.Commit();
                MessageBox.Show("Account Deleted successfully.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                transaction?.Rollback();
                MessageBox.Show("Error occured in deleteAccount() method : " + e.ToString());
            }
            finally
            {
                transaction?.Dispose();

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

            Form6 form6 = new Form6();
            form6.Show();
        }

        private void getDetailedReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Home form2 = new Home();
            form2.Show();
        }
    }
}
