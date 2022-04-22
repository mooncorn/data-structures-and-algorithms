using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private int[] array = new int[100];
        private bool shuffling = false;

        private int workingIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DisableControls();
            Cursor = Cursors.WaitCursor;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            shuffling = true;
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = random.Next(0, array.Length);

                int temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;

                Refresh();
            }
            shuffling = false;

            Cursor = Cursors.Default;
            EnableControls();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            DisableControls();
            Cursor = Cursors.WaitCursor;

            DateTime start = DateTime.Now;

            BubbleSort(array);
            workingIndex = -1;
            Refresh();

            var elapsed = DateTime.Now - start;
            lblTime.Text = $"Time elapsed: {elapsed}";

            Cursor = Cursors.Default;
            EnableControls();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            DisableControls();
            Cursor = Cursors.WaitCursor;

            DateTime start = DateTime.Now;

            InsertionSort(array);
            workingIndex = -1;
            Refresh();

            var elapsed = DateTime.Now - start;
            lblTime.Text = $"Time elapsed: {elapsed}";

            Cursor = Cursors.Default;
            EnableControls();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            DisableControls();
            Cursor = Cursors.WaitCursor;

            DateTime start = DateTime.Now;

            QuickSort(array, 0, array.Length - 1);
            workingIndex = -1;
            Refresh();

            var elapsed = DateTime.Now - start;
            lblTime.Text = $"Time elapsed: {elapsed}";

            Cursor = Cursors.Default;
            EnableControls();
        }

        private void pbHistogram_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int i = 0; i < array.Length; i++)
            {
                var bounds = new Rectangle(i * 5, 230 - (array[i] * 2), 4, array[i] * 2);
                var pen = new Pen(Color.Black, 1);
                var brush = new SolidBrush(Color.DarkGray);
                e.Graphics.DrawRectangle(pen, bounds);
                e.Graphics.FillRectangle(brush, bounds);

                bool notSorted = array[i] == i + 1;
                if (notSorted && !shuffling)
                {
                    brush = new SolidBrush(Color.Green);
                    e.Graphics.FillRectangle(brush, bounds);
                }

                if (i == workingIndex)
                {
                    brush = new SolidBrush(Color.Red);
                    e.Graphics.FillRectangle(brush, bounds);
                }
            }
        }

        private void BubbleSort(int[] array)
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        workingIndex = j;
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                        Refresh();
                    }
                }
            }
        }

        private void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int item = array[i];
                int index = i;
                while (index > 0 && array[index - 1] > item)
                {
                    workingIndex = index;
                    array[index] = array[index - 1];
                    index--;
                    Refresh();
                }
                array[index] = item;
            }
        }

        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    workingIndex = j;
                    Refresh();
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        private void DisableControls()
        {
            btnShuffle.Enabled = false;
            btnQuickSort.Enabled = false;
            btnInsertionSort.Enabled = false;
            btnBubbleSort.Enabled = false;
        }

        private void EnableControls()
        {
            btnShuffle.Enabled = true;
            btnQuickSort.Enabled = true;
            btnInsertionSort.Enabled = true;
            btnBubbleSort.Enabled = true;
        }
    }
}
