namespace PRT_Assignment_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdoLinearSearch = new System.Windows.Forms.RadioButton();
            this.rdoBinarySearch = new System.Windows.Forms.RadioButton();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.rdoQuickSort = new System.Windows.Forms.RadioButton();
            this.rdoInsertionSort = new System.Windows.Forms.RadioButton();
            this.rdoBubbleSort = new System.Windows.Forms.RadioButton();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtNumToFind = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grb1.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 75);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(981, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "PRT1020 Assignment 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoLinearSearch
            // 
            this.rdoLinearSearch.AutoSize = true;
            this.rdoLinearSearch.Location = new System.Drawing.Point(26, 35);
            this.rdoLinearSearch.Name = "rdoLinearSearch";
            this.rdoLinearSearch.Size = new System.Drawing.Size(132, 25);
            this.rdoLinearSearch.TabIndex = 0;
            this.rdoLinearSearch.TabStop = true;
            this.rdoLinearSearch.Text = "Linear Search";
            this.rdoLinearSearch.UseVisualStyleBackColor = true;
            this.rdoLinearSearch.CheckedChanged += new System.EventHandler(this.rdoLinearSearch_CheckedChanged);
            // 
            // rdoBinarySearch
            // 
            this.rdoBinarySearch.AutoSize = true;
            this.rdoBinarySearch.Location = new System.Drawing.Point(468, 35);
            this.rdoBinarySearch.Name = "rdoBinarySearch";
            this.rdoBinarySearch.Size = new System.Drawing.Size(132, 25);
            this.rdoBinarySearch.TabIndex = 1;
            this.rdoBinarySearch.TabStop = true;
            this.rdoBinarySearch.Text = "Binary Search";
            this.rdoBinarySearch.UseVisualStyleBackColor = true;
            this.rdoBinarySearch.CheckedChanged += new System.EventHandler(this.rdoBinarySearch_CheckedChanged);
            // 
            // grb1
            // 
            this.grb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb1.Controls.Add(this.rdoLinearSearch);
            this.grb1.Controls.Add(this.rdoBinarySearch);
            this.grb1.Location = new System.Drawing.Point(21, 97);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(987, 71);
            this.grb1.TabIndex = 2;
            this.grb1.TabStop = false;
            this.grb1.Text = "Which Search Algorithm do you want to use?";
            // 
            // grbSort
            // 
            this.grbSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSort.Controls.Add(this.rdoQuickSort);
            this.grbSort.Controls.Add(this.rdoInsertionSort);
            this.grbSort.Controls.Add(this.rdoBubbleSort);
            this.grbSort.Location = new System.Drawing.Point(21, 174);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(981, 78);
            this.grbSort.TabIndex = 3;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Which Sort Algorithm do you want to use?";
            // 
            // rdoQuickSort
            // 
            this.rdoQuickSort.AutoSize = true;
            this.rdoQuickSort.Location = new System.Drawing.Point(868, 37);
            this.rdoQuickSort.Name = "rdoQuickSort";
            this.rdoQuickSort.Size = new System.Drawing.Size(107, 25);
            this.rdoQuickSort.TabIndex = 2;
            this.rdoQuickSort.TabStop = true;
            this.rdoQuickSort.Text = "Quick Sort";
            this.rdoQuickSort.UseVisualStyleBackColor = true;
            // 
            // rdoInsertionSort
            // 
            this.rdoInsertionSort.AutoSize = true;
            this.rdoInsertionSort.Location = new System.Drawing.Point(468, 37);
            this.rdoInsertionSort.Name = "rdoInsertionSort";
            this.rdoInsertionSort.Size = new System.Drawing.Size(128, 25);
            this.rdoInsertionSort.TabIndex = 1;
            this.rdoInsertionSort.TabStop = true;
            this.rdoInsertionSort.Text = "Insertion Sort";
            this.rdoInsertionSort.UseVisualStyleBackColor = true;
            // 
            // rdoBubbleSort
            // 
            this.rdoBubbleSort.AutoSize = true;
            this.rdoBubbleSort.Location = new System.Drawing.Point(26, 37);
            this.rdoBubbleSort.Name = "rdoBubbleSort";
            this.rdoBubbleSort.Size = new System.Drawing.Size(116, 25);
            this.rdoBubbleSort.TabIndex = 0;
            this.rdoBubbleSort.TabStop = true;
            this.rdoBubbleSort.Text = "Bubble Sort";
            this.rdoBubbleSort.UseVisualStyleBackColor = true;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(22, 23);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(322, 21);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "What is the Number you are Looking for?";
            // 
            // txtNumToFind
            // 
            this.txtNumToFind.Location = new System.Drawing.Point(442, 20);
            this.txtNumToFind.Name = "txtNumToFind";
            this.txtNumToFind.Size = new System.Drawing.Size(180, 27);
            this.txtNumToFind.TabIndex = 1;
            this.txtNumToFind.TextChanged += new System.EventHandler(this.txtNumToFind_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblPrompt);
            this.groupBox2.Controls.Add(this.txtNumToFind);
            this.groupBox2.Location = new System.Drawing.Point(21, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 58);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(853, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 21;
            this.lstDisplay.Location = new System.Drawing.Point(21, 360);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(981, 298);
            this.lstDisplay.TabIndex = 5;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(21, 323);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(57, 21);
            this.lblErrorMsg.TabIndex = 6;
            this.lblErrorMsg.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 687);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1039, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdoLinearSearch;
        private System.Windows.Forms.RadioButton rdoBinarySearch;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.RadioButton rdoQuickSort;
        private System.Windows.Forms.RadioButton rdoInsertionSort;
        private System.Windows.Forms.RadioButton rdoBubbleSort;
        private System.Windows.Forms.TextBox txtNumToFind;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

