using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11___COSC_31112
{
    public partial class Log : Form
    {

        public Log()
        {
            InitializeComponent();

        }
        private Dictionary<string, string> userCredentials;

        private void Log_Load(object sender, EventArgs e)
        {
            string csvFilePath = @"\Group 11 - COSC 31112\Resources\Login_Details.csv";

            // Check if the CSV file exists
            if (File.Exists(csvFilePath))
            {
                userCredentials = new Dictionary<string, string>();

                using (TextFieldParser parser = new TextFieldParser(csvFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields.Length >= 2)
                        {
                            string username = fields[0];
                            string password = fields[1];
                            userCredentials[username] = password;
                        }
                    }
                }
            }
            else
            {
                // Handle the case where the CSV file doesn't exist
                MessageBox.Show("CSV file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int flag;
        private void Logbtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTxt.Text;
            string enteredPassword = passwordTxt.Text;
            

            // Check if the entered username exists in the userCredentials dictionary
            if (userCredentials.ContainsKey(enteredUsername))
            {
                // Username exists, now check the password
                if (userCredentials[enteredUsername] == enteredPassword)
                {
                    // Successful login
                     MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = 1;
                    Home form2 = new Home();
                    form2.Show();
                }

                else
                {
                    // Password is incorrect
                    MessageBox.Show("Password is incorrect.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    // Clear the password textbox
                    passwordTxt.Clear();
                }
            }
            else
            {
                // Both username and password are incorrect
                MessageBox.Show("Incorrect Login Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear both username and password textboxes
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
        }

        private void Signbtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTxt.Text;
            string enteredPassword = passwordTxt.Text;

            // Check if the entered username exists in the userCredentials dictionary
            if (userCredentials.ContainsKey(enteredUsername))
            {
                // Username exists, show a message about existing account
                MessageBox.Show($"Username '{enteredUsername}' is already registered. Enter the correct password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the password textbox
                passwordTxt.Clear();
            }
            else
            {
                if (AcceptBx.Checked)
                {
                    // Username doesn't exist, add it to the dictionary and CSV file
                    userCredentials[enteredUsername] = enteredPassword;

                    // Save the updated userCredentials dictionary to the CSV file
                    SaveUserCredentialsToCSV();

                    // Show a message about successful sign-up
                    MessageBox.Show($"Account for '{enteredUsername}' is created. You are now logged in as '{enteredUsername}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please accept the Terms and Conditions","Terms and Conditions",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }

        private void SaveUserCredentialsToCSV()
        {
            string csvFilePath = @"E:\Group 11 - COSC 31112\Resources\Login_Details.csv";

            // Create or overwrite the CSV file with the updated userCredentials
            using (StreamWriter sw = new StreamWriter(csvFilePath, false))
            {
                foreach (var entry in userCredentials)
                {
                    sw.WriteLine($"{entry.Key},{entry.Value}");
                }
            }
        }

    }
}
