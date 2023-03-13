using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshuaCalculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void N1_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "1";
            }
            else {
                txtBar.Text = txtBar.Text + "1";

            }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "2";
            }
            else
            {
                txtBar.Text = txtBar.Text + "2";
            }
        }
        private void N3_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "3";
            }
            else
            {
                txtBar.Text = txtBar.Text + "3";
            }
        }
        private void N4_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "4";
            }
            else
            {
                txtBar.Text = txtBar.Text + "4";
            }
        }
      private void N5_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "5";
            }
            else
            {
                txtBar.Text = txtBar.Text + "5";
          }
        }
        private void N6_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "6";
            }
            else
            {
                txtBar.Text = txtBar.Text + "6";

            }
        }
      private void N7_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "7";
            }
            else
            {
                txtBar.Text = txtBar.Text + "7";
            }
        }
       private void N8_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "8";
            }
            else
            {
                txtBar.Text = txtBar.Text + "8";

            }
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "9";
            }
            else
            {
                txtBar.Text = txtBar.Text + "9";

            }
        }
        private void N0_Click(object sender, EventArgs e)
        {
            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = "0";
            }
            else
            {
                txtBar.Text = txtBar.Text + "0";

            }
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {

            if (txtBar.Text == "0" && txtBar.Text != null)
            {

                txtBar.Text = ".";
            }
            else
            {
                txtBar.Text = txtBar.Text + ".";

            }
        }



        private void BtnClear_Click(object sender, EventArgs e)
        {
            // txtBar.Clear();

            n1.Enabled = true;
            n2.Enabled = true;
            n3.Enabled = true;
            n4.Enabled = true;
            n5.Enabled = true;
            n6.Enabled = true;
            n7.Enabled = true;
            n8.Enabled = true;
            n9.Enabled = true;
            n0.Enabled = true;
            btnDecimal.Enabled = true;


            //

            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;

            btnEqual.Enabled = true;
            txtBar.Text = "0";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;


                FirstNumber = double.Parse(txtBar.Text);
                txtBar.Text = "0";
                Operation = "+";

            }
            catch {

                MessageBox.Show("Invalid", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;


                FirstNumber = double.Parse(txtBar.Text);
                txtBar.Text = "0";
                Operation = "-";
            }
            catch
            {

                MessageBox.Show("Invalid Numbers Only","Warning",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {

            try
            {
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;

                FirstNumber = double.Parse(txtBar.Text);
                txtBar.Text = "0";
                Operation = "/";
            }
            catch {

                MessageBox.Show("Invalid Given","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;

                FirstNumber = double.Parse(txtBar.Text);
                txtBar.Text = "0";
                Operation = "*";
            }catch{

                MessageBox.Show("Invalid Given", "Warning", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {

            double SecondNumber;
            double Result;


            try
            {

            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
            n4.Enabled = false;
            n5.Enabled = false;
            n6.Enabled = false;
            n7.Enabled = false;
            n8.Enabled = false;
            n9.Enabled = false;
            n0.Enabled = false;
            btnDecimal.Enabled = false;

            //
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;

            btnEqual.Enabled = false;

            SecondNumber = double.Parse(txtBar.Text);

                            if (Operation=="+") {
                                button11.Enabled = false;
               
                                Result = (FirstNumber + SecondNumber);
                                txtBar.Text = Convert.ToString (FirstNumber) +" + "+ Convert.ToString(SecondNumber)+" = "+Convert.ToString(Result);
                                FirstNumber = Result;
                

                            }
            //
                            if (Operation == "-")
                            {

                                button12.Enabled = false;
                
                                Result = (FirstNumber - SecondNumber);
                                txtBar.Text = Convert.ToString(FirstNumber) + " - " + Convert.ToString(SecondNumber) + " = " + Convert.ToString(Result);
                                FirstNumber = Result;
                            }

                            if (Operation == "*")
                            {
                                button13.Enabled = false;

                                Result = (FirstNumber * SecondNumber);
                                txtBar.Text = Convert.ToString(FirstNumber) + " x  " + Convert.ToString(SecondNumber) + " = " + Convert.ToString(Result);

                                FirstNumber = Result;
                            }

                            if (Operation == "/")
                            {

                                button14.Enabled = false;
                                btnEqual.Enabled = false;


                                if (SecondNumber == 0)
                                {

                                    txtBar.Text = "It Cannot Divide by Zero";
                                }
                                else {
                                    Result = (FirstNumber / SecondNumber);
                                    txtBar.Text = Convert.ToString(FirstNumber) + " /  " + Convert.ToString(SecondNumber) + " = " + Convert.ToString(Result);

                                    FirstNumber = Result;


                                }
                            }

            }
            catch
            {

                MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private void TxtBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   this.BackColor = Color.White;
        }
    }
}
