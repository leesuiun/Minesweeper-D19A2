namespace Minesweeper
{
    partial class BestTime
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
            this.lblBeginName = new System.Windows.Forms.Label();
            this.lblExpBst = new System.Windows.Forms.Label();
            this.lblInterName = new System.Windows.Forms.Label();
            this.lblExpName = new System.Windows.Forms.Label();
            this.lblInterBst = new System.Windows.Forms.Label();
            this.lblBeginBst = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBeginName
            // 
            this.lblBeginName.Location = new System.Drawing.Point(174, 9);
            this.lblBeginName.Name = "lblBeginName";
            this.lblBeginName.Size = new System.Drawing.Size(105, 13);
            this.lblBeginName.TabIndex = 27;
            // 
            // lblExpBst
            // 
            this.lblExpBst.Location = new System.Drawing.Point(104, 68);
            this.lblExpBst.Name = "lblExpBst";
            this.lblExpBst.Size = new System.Drawing.Size(38, 13);
            this.lblExpBst.TabIndex = 26;
            // 
            // lblInterName
            // 
            this.lblInterName.Location = new System.Drawing.Point(174, 39);
            this.lblInterName.Name = "lblInterName";
            this.lblInterName.Size = new System.Drawing.Size(105, 13);
            this.lblInterName.TabIndex = 25;
            // 
            // lblExpName
            // 
            this.lblExpName.Location = new System.Drawing.Point(174, 68);
            this.lblExpName.Name = "lblExpName";
            this.lblExpName.Size = new System.Drawing.Size(105, 13);
            this.lblExpName.TabIndex = 24;
            // 
            // lblInterBst
            // 
            this.lblInterBst.Location = new System.Drawing.Point(104, 39);
            this.lblInterBst.Name = "lblInterBst";
            this.lblInterBst.Size = new System.Drawing.Size(38, 13);
            this.lblInterBst.TabIndex = 23;
            // 
            // lblBeginBst
            // 
            this.lblBeginBst.Location = new System.Drawing.Point(104, 9);
            this.lblBeginBst.Name = "lblBeginBst";
            this.lblBeginBst.Size = new System.Drawing.Size(38, 13);
            this.lblBeginBst.TabIndex = 22;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(146, 102);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(79, 23);
            this.cmdOK.TabIndex = 21;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(38, 102);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(82, 23);
            this.cmdReset.TabIndex = 20;
            this.cmdReset.Text = "Reset Scores";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Expert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Intermediate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Beginner:";
            // 
            // BestTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 137);
            this.Controls.Add(this.lblBeginName);
            this.Controls.Add(this.lblExpBst);
            this.Controls.Add(this.lblInterName);
            this.Controls.Add(this.lblExpName);
            this.Controls.Add(this.lblInterBst);
            this.Controls.Add(this.lblBeginBst);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestTime";
            this.Text = "BestTime";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.BestTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBeginName;
        public System.Windows.Forms.Label lblExpBst;
        public System.Windows.Forms.Label lblInterName;
        public System.Windows.Forms.Label lblExpName;
        public System.Windows.Forms.Label lblInterBst;
        public System.Windows.Forms.Label lblBeginBst;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}