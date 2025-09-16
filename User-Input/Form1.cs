using System;
using System.Windows.Forms;

namespace User_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(txtAge.Text);

                if (age < 0)
                    throw new Exception("Age cannot be negative.");

                lblResult.Text = $"Your age is: {age}";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            catch (FormatException)
            {
                lblResult.Text = "Invalid input. Please enter a number.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



