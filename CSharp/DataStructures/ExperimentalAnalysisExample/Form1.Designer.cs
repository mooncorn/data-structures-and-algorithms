﻿using System.Windows.Forms;

namespace ExperimentalAnalysisExample
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
            this.btnAlgo1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlgo2 = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAlgo1
            // 
            this.btnAlgo1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAlgo1.Location = new System.Drawing.Point(240, 72);
            this.btnAlgo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlgo1.Name = "btnAlgo1";
            this.btnAlgo1.Size = new System.Drawing.Size(365, 41);
            this.btnAlgo1.TabIndex = 1;
            this.btnAlgo1.Text = "Compute Time (Algorithm 1)";
            this.btnAlgo1.UseVisualStyleBackColor = true;
            this.btnAlgo1.Click += new System.EventHandler(this.btnAlgo1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtInput.Location = new System.Drawing.Point(106, 72);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(128, 41);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Experimental Analysis Demo (Fibonacci Number)";
            // 
            // btnAlgo2
            // 
            this.btnAlgo2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAlgo2.Location = new System.Drawing.Point(611, 72);
            this.btnAlgo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlgo2.Name = "btnAlgo2";
            this.btnAlgo2.Size = new System.Drawing.Size(365, 41);
            this.btnAlgo2.TabIndex = 2;
            this.btnAlgo2.Text = "Compute Time (Algorithm 2)";
            this.btnAlgo2.UseVisualStyleBackColor = true;
            this.btnAlgo2.Click += new System.EventHandler(this.btnAlgo2_Click);
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtReport.Location = new System.Drawing.Point(12, 166);
            this.txtReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(1273, 342);
            this.txtReport.TabIndex = 5;
            this.txtReport.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(779, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "FYI: Any value greater than 43 will take a looong time for Algorithm 2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(575, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(518, 29);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://en.wikipedia.org/wiki/Fibonacci_number";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 519);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAlgo2);
            this.Controls.Add(this.btnAlgo1);
            this.Controls.Add(this.txtReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Experimental Analysis Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAlgo1;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Button btnAlgo2;
        private RichTextBox txtReport;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}

