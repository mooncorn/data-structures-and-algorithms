using DataSctructures_SortingAlgorithms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSctructures_SortingAlgorithms
{
    public partial class SortForm : Form
    {
        SortPanel sortMethod;

        public SortForm()
        {
            InitializeComponent();
            int Height = this.Height - this.button1.Height;
            sortMethod = new Insertion_Sort(this, " Insertion Sort", this.Width, Height);
            this.button1.Text = "     "+ sortMethod.Title;


            //Use Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            sortMethod.Run();
            DateTime endTime = DateTime.Now;
            
            double runTimeMinutes = endTime.Subtract(startTime).TotalMinutes;     
            this.label_RunTime.Text = Math.Round(runTimeMinutes, 3).ToString() + " Minutes";        
        }

        private void SortForm_Paint(object sender, PaintEventArgs e)
        {
            sortMethod.Draw(e.Graphics);
        }

    }
}
