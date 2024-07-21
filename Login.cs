using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace LoginRegister
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)//login button
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            DatabaseOperations db = new DatabaseOperations();
            if (db.ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string filePath = @"C://Users//liora//source//repos//LoginRegister//LoginRegister//Users.xlsx";
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string storedUsername = worksheet.Cells[row, 1].Value.ToString();
                    string storedPassword = worksheet.Cells[row, 2].Value.ToString();

                    if (username == storedUsername && password == storedPassword)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//password twxtbox
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//username textbox
        {

        }

        private void label3_Click(object sender, EventArgs e)//password
        {

        }

        private void label2_Click(object sender, EventArgs e)//username
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)//dont have account?
        {

        }

        private void label8_Click_1(object sender, EventArgs e)//move to register form
        {
            this.Hide(); // Hide the login form
            Register registerForm = new Register(); // Create an instance of the register form
            registerForm.Show(); // Show the register form
        }

        private void button3_Click(object sender, EventArgs e)//exit
        {
            Application.Exit();
        }
    }
}
