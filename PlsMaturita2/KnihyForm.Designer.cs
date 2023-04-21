namespace PlsMaturita2
{
    partial class KnihyForm
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
            this.lvKnihy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.btnAddKnihy = new System.Windows.Forms.Button();
            this.btnEditKnihy = new System.Windows.Forms.Button();
            this.btnDelKnihy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtKnihy = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvKnihy
            // 
            this.lvKnihy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvKnihy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvKnihy.FullRowSelect = true;
            this.lvKnihy.GridLines = true;
            this.lvKnihy.HideSelection = false;
            this.lvKnihy.Location = new System.Drawing.Point(0, 0);
            this.lvKnihy.Name = "lvKnihy";
            this.lvKnihy.Size = new System.Drawing.Size(422, 450);
            this.lvKnihy.TabIndex = 2;
            this.lvKnihy.UseCompatibleStateImageBehavior = false;
            this.lvKnihy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Název";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum";
            this.columnHeader4.Width = 120;
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(569, 86);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(131, 22);
            this.tbNazev.TabIndex = 5;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(569, 137);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(131, 22);
            this.tbAutor.TabIndex = 6;
            // 
            // btnAddKnihy
            // 
            this.btnAddKnihy.Location = new System.Drawing.Point(569, 307);
            this.btnAddKnihy.Name = "btnAddKnihy";
            this.btnAddKnihy.Size = new System.Drawing.Size(98, 23);
            this.btnAddKnihy.TabIndex = 8;
            this.btnAddKnihy.Text = "Přidat";
            this.btnAddKnihy.UseVisualStyleBackColor = true;
            this.btnAddKnihy.Click += new System.EventHandler(this.btnAddKnihy_Click);
            // 
            // btnEditKnihy
            // 
            this.btnEditKnihy.Location = new System.Drawing.Point(493, 352);
            this.btnEditKnihy.Name = "btnEditKnihy";
            this.btnEditKnihy.Size = new System.Drawing.Size(100, 23);
            this.btnEditKnihy.TabIndex = 9;
            this.btnEditKnihy.Text = "Edit";
            this.btnEditKnihy.UseVisualStyleBackColor = true;
            this.btnEditKnihy.Click += new System.EventHandler(this.btnEditKnihy_Click);
            // 
            // btnDelKnihy
            // 
            this.btnDelKnihy.Location = new System.Drawing.Point(645, 352);
            this.btnDelKnihy.Name = "btnDelKnihy";
            this.btnDelKnihy.Size = new System.Drawing.Size(103, 23);
            this.btnDelKnihy.TabIndex = 10;
            this.btnDelKnihy.Text = "Odstranit";
            this.btnDelKnihy.UseVisualStyleBackColor = true;
            this.btnDelKnihy.Click += new System.EventHandler(this.btnDelKnihy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum";
            // 
            // dtKnihy
            // 
            this.dtKnihy.Location = new System.Drawing.Point(569, 202);
            this.dtKnihy.Name = "dtKnihy";
            this.dtKnihy.Size = new System.Drawing.Size(200, 22);
            this.dtKnihy.TabIndex = 14;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(536, 416);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(131, 22);
            this.tbSearch.TabIndex = 15;
            // 
            // KnihyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dtKnihy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelKnihy);
            this.Controls.Add(this.btnEditKnihy);
            this.Controls.Add(this.btnAddKnihy);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNazev);
            this.Controls.Add(this.lvKnihy);
            this.Name = "KnihyForm";
            this.Text = "KnihyForm";
            this.Load += new System.EventHandler(this.KnihyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKnihy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Button btnAddKnihy;
        private System.Windows.Forms.Button btnEditKnihy;
        private System.Windows.Forms.Button btnDelKnihy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtKnihy;
        private System.Windows.Forms.TextBox tbSearch;
    }
}