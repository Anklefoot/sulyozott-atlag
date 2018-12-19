namespace SúlyozottAtlag2
{
    partial class NewClass
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBoxClass = new System.Windows.Forms.TextBox();
            this.txtBoxCredit = new System.Windows.Forms.TextBox();
            this.txtBoxGrade = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(51, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBoxClass
            // 
            this.txtBoxClass.Location = new System.Drawing.Point(74, 12);
            this.txtBoxClass.Name = "txtBoxClass";
            this.txtBoxClass.Size = new System.Drawing.Size(227, 20);
            this.txtBoxClass.TabIndex = 1;
            // 
            // txtBoxCredit
            // 
            this.txtBoxCredit.Location = new System.Drawing.Point(74, 38);
            this.txtBoxCredit.Name = "txtBoxCredit";
            this.txtBoxCredit.Size = new System.Drawing.Size(227, 20);
            this.txtBoxCredit.TabIndex = 2;
            // 
            // txtBoxGrade
            // 
            this.txtBoxGrade.Location = new System.Drawing.Point(74, 64);
            this.txtBoxGrade.Name = "txtBoxGrade";
            this.txtBoxGrade.Size = new System.Drawing.Size(227, 20);
            this.txtBoxGrade.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(13, 12);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Tantárgy:";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(13, 38);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(37, 13);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "Kredit:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(13, 64);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(58, 13);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Osztályzat:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Mégse";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 139);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtBoxGrade);
            this.Controls.Add(this.txtBoxCredit);
            this.Controls.Add(this.txtBoxClass);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tantárgy hozzáadása";
            this.Load += new System.EventHandler(this.NewClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBoxClass;
        private System.Windows.Forms.TextBox txtBoxCredit;
        private System.Windows.Forms.TextBox txtBoxGrade;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnClose;
    }
}