namespace prjRegExp
{
    partial class frmRegExTester
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
            this.components = new System.ComponentModel.Container();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblMatches = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.mnuTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.mnuTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(101, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(426, 20);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to Test: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RegEx to Test: ";
            // 
            // txtRegEx
            // 
            this.txtRegEx.Location = new System.Drawing.Point(101, 129);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(426, 20);
            this.txtRegEx.TabIndex = 3;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(101, 155);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(426, 95);
            this.lstResults.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results: ";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(20, 199);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseDown);
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(58, 171);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(19, 13);
            this.lblMatches.TabIndex = 7;
            this.lblMatches.Text = "(0)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mnuTest
            // 
            this.mnuTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSingle,
            this.mnuBlock,
            this.mnuFile});
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(174, 70);
            // 
            // mnuSingle
            // 
            this.mnuSingle.Name = "mnuSingle";
            this.mnuSingle.Size = new System.Drawing.Size(173, 22);
            this.mnuSingle.Text = "Test on Single Line";
            this.mnuSingle.Click += new System.EventHandler(this.mnuSingle_Click);
            // 
            // mnuBlock
            // 
            this.mnuBlock.Name = "mnuBlock";
            this.mnuBlock.Size = new System.Drawing.Size(173, 22);
            this.mnuBlock.Text = "Test on Block";
            this.mnuBlock.Click += new System.EventHandler(this.mnuBlock_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(173, 22);
            this.mnuFile.Text = "Test on File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(101, 38);
            this.txtBlock.Multiline = true;
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBlock.Size = new System.Drawing.Size(426, 85);
            this.txtBlock.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Block to Test: ";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(20, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Into ->";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmRegExTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtRegEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Name = "frmRegExTester";
            this.Text = "Regular Expression Tester";
            this.mnuTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip mnuTest;
        private System.Windows.Forms.ToolStripMenuItem mnuSingle;
        private System.Windows.Forms.ToolStripMenuItem mnuBlock;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
    }
}

