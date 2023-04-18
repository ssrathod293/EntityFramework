
namespace DBFirstApproachDemo
{
    partial class SearchRole
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
            this.txtroleid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrolename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoleId";
            // 
            // txtroleid
            // 
            this.txtroleid.Location = new System.Drawing.Point(313, 62);
            this.txtroleid.Name = "txtroleid";
            this.txtroleid.Size = new System.Drawing.Size(260, 26);
            this.txtroleid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search Role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Role Name";
            // 
            // txtrolename
            // 
            this.txtrolename.Location = new System.Drawing.Point(320, 186);
            this.txtrolename.Name = "txtrolename";
            this.txtrolename.Size = new System.Drawing.Size(253, 26);
            this.txtrolename.TabIndex = 4;
            // 
            // SearchRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrolename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtroleid);
            this.Controls.Add(this.label1);
            this.Name = "SearchRole";
            this.Text = "SearchRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtroleid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrolename;
    }
}