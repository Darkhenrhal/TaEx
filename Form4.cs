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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.projectDatabaseDataSet.Account);
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {   
                    AccountNames.Clear();
                    connection.Open();
                    string sqlquery = "SELECT Account_name FROM Account";

                    using (SqlCommand command = new SqlCommand(sqlquery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //Read data and add to combobox
                            while (reader.Read())
                            {
                                string accountName = reader["Account_name"].ToString();
                                AccountNames.Add(accountName);
                               
                            }
                            cmbAccounts.DataSource = AccountNames;

                        }
                    }
                    connection.Close();//end the connection with database

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void subNewSubT_Click_1(object sender, EventArgs e)
        {
            if (txtNewSubT.Text==""||txtNewSubDesc.Text==""||cmbSubTCat.SelectedItem==null||txtAmount.Text=="")
            {
                MessageBox.Show("Please fill all items","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string subtask_name = txtNewSubT.Text;
                string subtask_desc = txtNewSubDesc.Text;
                string subtask_cat = cmbSubTCat.SelectedItem.ToString();
                string amount_money = txtAmount.Text;
                int acc_id = GetAccountId(cmbAccounts.SelectedItem.ToString());

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

                                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear input fields after successful submission if desired
                                txtNewSubT.Text = string.Empty;
                                txtNewSubDesc.Text = string.Empty;
                                txtAmount.Text = string.Empty;
                                cmbSubTCat.SelectedItem = null;

                                connection.Close();//end the connection with database
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: 2 " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private int GetAccountId(string accountName)
        {
            int accId = 1; // Default value if no account is found

            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Account_id FROM Account WHERE Account_name = @accountName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@accountName", accountName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        accId = Convert.ToInt32(result);
                    }
                }
            }

            return accId;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
        }

        private void editAcc_Click(object sender, EventArgs e)
        {

        }

        private void newAcc_Click(object sender, EventArgs e)
        {
            addNewAcc form3=new addNewAcc();
            form3.Show();
            frmAddNewSubT form4=new frmAddNewSubT();
            form4.Close();  
        }
    }
}
