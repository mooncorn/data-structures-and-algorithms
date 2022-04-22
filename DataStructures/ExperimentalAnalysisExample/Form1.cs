using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExperimentalAnalysisExample
{
    public partial class Form1 : Form
    {
        private int numberOfIterations = 1;

        public Form1()
        {
            InitializeComponent();
            #region Cache
            txtInput.Text = "10";
            GetAlgoBenchmark(1);
            GetAlgoBenchmark(2);
            txtInput.Text = "";
            txtReport.Text = "";
            #endregion
        }

        private void btnAlgo1_Click(object sender, EventArgs e)
        {
            GetAlgoBenchmark(1);
        }

        private void btnAlgo2_Click(object sender, EventArgs e)
        {
            GetAlgoBenchmark(2);
        }

        private void GetAlgoBenchmark(int algoNumber)
        {
            int depth;
            if (!int.TryParse(txtInput.Text, out depth))
            {
                MessageBox.Show("Please enter a numeric value for depth",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else if (depth <= 0)
            {
                MessageBox.Show("Please enter a value greater than zero",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;

            DateTime dateTime = DateTime.Now;

            numberOfIterations = 0;

            int fiboValue;

            if (algoNumber == 1)
            {
                fiboValue = FibonacciAlgorithm1(depth);
                txtReport.SelectionColor = Color.Green;
            }
            else
            {
                fiboValue = FibonacciAlgorithm2(depth);
                txtReport.SelectionColor = Color.Red;
            }

            TimeSpan ts = DateTime.Now - dateTime;

            string message = $"ALGORITHM {algoNumber} " +
                             $"(Fibonacci of {txtInput.Text} is {fiboValue}) ... " +
                             $"time spent: {ts.TotalMilliseconds} ms ... " +
                             $"# of iterations: {numberOfIterations}";

            txtReport.AppendText(message + "\r\n");

            Cursor = Cursors.Default;
        }


        private int FibonacciAlgorithm1(int depth)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (depth == 0) return 0; //To return the first Fibonacci number   
            if (depth == 1) return 1; //To return the second Fibonacci number   


            for (int i = 2; i <= depth; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;

                numberOfIterations++;
            }

            return result;
        }

        private int FibonacciAlgorithm2(int depth)
        {
            numberOfIterations++;
            if (depth == 1 || depth == 2)
                return 1;
            else
                return FibonacciAlgorithm2(depth - 1) + FibonacciAlgorithm2(depth - 2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Fibonacci_number");
        }
    }
}