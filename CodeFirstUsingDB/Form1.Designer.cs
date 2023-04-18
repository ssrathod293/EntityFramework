
namespace CodeFirstUsingDB
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
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridviewcourses = new System.Windows.Forms.DataGridView();
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewcourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(298, 56);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(266, 26);
            this.txtcoursename.TabIndex = 2;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(298, 111);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(266, 26);
            this.txtduration.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridviewcourses
            // 
            this.gridviewcourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewcourses.Location = new System.Drawing.Point(135, 259);
            this.gridviewcourses.Name = "gridviewcourses";
            this.gridviewcourses.RowHeadersWidth = 62;
            this.gridviewcourses.RowTemplate.Height = 28;
            this.gridviewcourses.Size = new System.Drawing.Size(561, 150);
            this.gridviewcourses.TabIndex = 5;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(588, 214);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 20);
            this.lblmessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 499);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.gridviewcourses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.txtcoursename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewcourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridviewcourses;
        private System.Windows.Forms.Label lblmessage;
    }
}

