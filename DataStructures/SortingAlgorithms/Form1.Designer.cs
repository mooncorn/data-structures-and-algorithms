namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShuffle = new System.Windows.Forms.Button();
            this.pbHistogram = new System.Windows.Forms.PictureBox();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(57, 12);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(500, 40);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // pbHistogram
            // 
            this.pbHistogram.Location = new System.Drawing.Point(57, 104);
            this.pbHistogram.Name = "pbHistogram";
            this.pbHistogram.Size = new System.Drawing.Size(500, 230);
            this.pbHistogram.TabIndex = 1;
            this.pbHistogram.TabStop = false;
            this.pbHistogram.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHistogram_Paint);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(57, 56);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(150, 40);
            this.btnBubbleSort.TabIndex = 2;
            this.btnBubbleSort.Text = "BUBBLE SORT";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(407, 56);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(150, 40);
            this.btnInsertionSort.TabIndex = 4;
            this.btnInsertionSort.Text = "INSERTION SORT";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(232, 56);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(150, 40);
            this.btnQuickSort.TabIndex = 3;
            this.btnQuickSort.Text = "QUICK SORT";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTime.Location = new System.Drawing.Point(54, 342);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 368);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.pbHistogram);
            this.Controls.Add(this.btnShuffle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.PictureBox pbHistogram;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Label lblTime;
    }
}

