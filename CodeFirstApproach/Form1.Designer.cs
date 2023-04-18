
namespace CodeFirstApproach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrollnumber = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblmeassage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtconfirmemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RollNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // txtrollnumber
            // 
            this.txtrollnumber.Location = new System.Drawing.Point(293, 69);
            this.txtrollnumber.Name = "txtrollnumber";
            this.txtrollnumber.Size = new System.Drawing.Size(225, 26);
            this.txtrollnumber.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(293, 127);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(293, 174);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(225, 26);
            this.txtgender.TabIndex = 5;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(302, 354);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(165, 35);
            this.btncreate.TabIndex = 6;
            this.btncreate.Text = "Create Student";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lblmeassage
            // 
            this.lblmeassage.AutoSize = true;
            this.lblmeassage.Location = new System.Drawing.Point(618, 69);
            this.lblmeassage.Name = "lblmeassage";
            this.lblmeassage.Size = new System.Drawing.Size(0, 20);
            this.lblmeassage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(293, 230);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(225, 26);
            this.txtemail.TabIndex = 10;
            // 
            // txtconfirmemail
            // 
            this.txtconfirmemail.Location = new System.Drawing.Point(293, 295);
            this.txtconfirmemail.Name = "txtconfirmemail";
            this.txtconfirmemail.Size = new System.Drawing.Size(225, 26);
            this.txtconfirmemail.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtconfirmemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmeassage);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrollnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lblmeassage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtconfirmemail;
    }
}

