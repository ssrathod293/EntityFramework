
namespace CodeFirstApproach
{
    partial class Trainer
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
            this.lblmasg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridtrainer = new System.Windows.Forms.DataGridView();
            this.txtexperiance = new System.Windows.Forms.TextBox();
            this.txttrainernmae = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TrainerPage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TrainerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experiance";
            // 
            // lblmasg
            // 
            this.lblmasg.AutoSize = true;
            this.lblmasg.Location = new System.Drawing.Point(398, 215);
            this.lblmasg.Name = "lblmasg";
            this.lblmasg.Size = new System.Drawing.Size(0, 20);
            this.lblmasg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridtrainer
            // 
            this.gridtrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtrainer.Location = new System.Drawing.Point(119, 280);
            this.gridtrainer.Name = "gridtrainer";
            this.gridtrainer.RowHeadersWidth = 62;
            this.gridtrainer.RowTemplate.Height = 28;
            this.gridtrainer.Size = new System.Drawing.Size(543, 161);
            this.gridtrainer.TabIndex = 5;
            // 
            // txtexperiance
            // 
            this.txtexperiance.Location = new System.Drawing.Point(344, 158);
            this.txtexperiance.Name = "txtexperiance";
            this.txtexperiance.Size = new System.Drawing.Size(190, 26);
            this.txtexperiance.TabIndex = 7;
            // 
            // txttrainernmae
            // 
            this.txttrainernmae.Location = new System.Drawing.Point(344, 97);
            this.txttrainernmae.Name = "txttrainernmae";
            this.txttrainernmae.Size = new System.Drawing.Size(190, 26);
            this.txttrainernmae.TabIndex = 8;
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttrainernmae);
            this.Controls.Add(this.txtexperiance);
            this.Controls.Add(this.gridtrainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblmasg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trainer";
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmasg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridtrainer;
        private System.Windows.Forms.TextBox txtexperiance;
        private System.Windows.Forms.TextBox txttrainernmae;
    }
}