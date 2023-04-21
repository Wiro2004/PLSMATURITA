namespace PlsMaturita2
{
    partial class Čtenáři
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
            this.lvCtenari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.tbPujcenychKnih = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // lvCtenari
            // 
            this.lvCtenari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCtenari.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvCtenari.FullRowSelect = true;
            this.lvCtenari.GridLines = true;
            this.lvCtenari.HideSelection = false;
            this.lvCtenari.Location = new System.Drawing.Point(0, 0);
            this.lvCtenari.Name = "lvCtenari";
            this.lvCtenari.Size = new System.Drawing.Size(422, 450);
            this.lvCtenari.TabIndex = 1;
            this.lvCtenari.UseCompatibleStateImageBehavior = false;
            this.lvCtenari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Příjmení";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Půjčených knih";
            this.columnHeader4.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Půjčených knih";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(550, 80);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(131, 22);
            this.tbJmeno.TabIndex = 4;
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(550, 124);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(131, 22);
            this.tbPrijmeni.TabIndex = 5;
            // 
            // tbPujcenychKnih
            // 
            this.tbPujcenychKnih.Location = new System.Drawing.Point(550, 171);
            this.tbPujcenychKnih.Name = "tbPujcenychKnih";
            this.tbPujcenychKnih.Size = new System.Drawing.Size(131, 22);
            this.tbPujcenychKnih.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Odstranit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Čtenáři
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPujcenychKnih);
            this.Controls.Add(this.tbPrijmeni);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvCtenari);
            this.Controls.Add(this.label1);
            this.Name = "Čtenáři";
            this.Text = "Čtenáři";
            this.Load += new System.EventHandler(this.Čtenáři_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCtenari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.TextBox tbPujcenychKnih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}