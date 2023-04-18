
namespace DBFirstApproachDemo
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
            this.Gridusers = new System.Windows.Forms.DataGridView();
            this.gridRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridallactiveRoles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gridFilterview = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.datelistview = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Gridusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridallactiveRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilterview)).BeginInit();
            this.SuspendLayout();
            // 
            // Gridusers
            // 
            this.Gridusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridusers.Location = new System.Drawing.Point(26, 70);
            this.Gridusers.Name = "Gridusers";
            this.Gridusers.RowHeadersWidth = 62;
            this.Gridusers.RowTemplate.Height = 28;
            this.Gridusers.Size = new System.Drawing.Size(520, 215);
            this.Gridusers.TabIndex = 0;
            // 
            // gridRoles
            // 
            this.gridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoles.Location = new System.Drawing.Point(582, 70);
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.RowHeadersWidth = 62;
            this.gridRoles.RowTemplate.Height = 28;
            this.gridRoles.Size = new System.Drawing.Size(387, 215);
            this.gridRoles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Roles";
            // 
            // gridallactiveRoles
            // 
            this.gridallactiveRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridallactiveRoles.Location = new System.Drawing.Point(26, 331);
            this.gridallactiveRoles.Name = "gridallactiveRoles";
            this.gridallactiveRoles.RowHeadersWidth = 62;
            this.gridallactiveRoles.RowTemplate.Height = 28;
            this.gridallactiveRoles.Size = new System.Drawing.Size(387, 215);
            this.gridallactiveRoles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Active Roles";
            // 
            // gridFilterview
            // 
            this.gridFilterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilterview.Location = new System.Drawing.Point(496, 372);
            this.gridFilterview.Name = "gridFilterview";
            this.gridFilterview.RowHeadersWidth = 62;
            this.gridFilterview.RowTemplate.Height = 28;
            this.gridFilterview.Size = new System.Drawing.Size(387, 215);
            this.gridFilterview.TabIndex = 6;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(654, 331);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(177, 26);
            this.txtsearch.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(859, 323);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 36);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter by registered date";
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(846, 602);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(123, 36);
            this.btnselect.TabIndex = 10;
            this.btnselect.Text = "select date";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // datelistview
            // 
            this.datelistview.HideSelection = false;
            this.datelistview.Location = new System.Drawing.Point(543, 602);
            this.datelistview.Name = "datelistview";
            this.datelistview.Size = new System.Drawing.Size(261, 51);
            this.datelistview.TabIndex = 11;
            this.datelistview.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 683);
            this.Controls.Add(this.datelistview);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.gridFilterview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridallactiveRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRoles);
            this.Controls.Add(this.Gridusers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridallactiveRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilterview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gridusers;
        private System.Windows.Forms.DataGridView gridRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridallactiveRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridFilterview;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListView datelistview;
    }
}

