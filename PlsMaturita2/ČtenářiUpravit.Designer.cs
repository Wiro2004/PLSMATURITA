namespace PlsMaturita2
{
    partial class ČtenářiUpravit
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
            this.lblNoveJmeno = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbNovePujcenychKnih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNovePrijmeni = new System.Windows.Forms.TextBox();
            this.tbNoveJmeno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNoveJmeno
            // 
            this.lblNoveJmeno.AutoSize = true;
            this.lblNoveJmeno.Location = new System.Drawing.Point(37, 67);
            this.lblNoveJmeno.Name = "lblNoveJmeno";
            this.lblNoveJmeno.Size = new System.Drawing.Size(80, 16);
            this.lblNoveJmeno.TabIndex = 0;
            this.lblNoveJmeno.Text = "Nové jméno";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(88, 243);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(202, 67);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbNovePujcenychKnih
            // 
            this.tbNovePujcenychKnih.Location = new System.Drawing.Point(162, 176);
            this.tbNovePujcenychKnih.Name = "tbNovePujcenychKnih";
            this.tbNovePujcenychKnih.Size = new System.Drawing.Size(128, 22);
            this.tbNovePujcenychKnih.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nové příjmení";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet knih";
            // 
            // tbNovePrijmeni
            // 
            this.tbNovePrijmeni.Location = new System.Drawing.Point(162, 124);
            this.tbNovePrijmeni.Name = "tbNovePrijmeni";
            this.tbNovePrijmeni.Size = new System.Drawing.Size(128, 22);
            this.tbNovePrijmeni.TabIndex = 5;
            // 
            // tbNoveJmeno
            // 
            this.tbNoveJmeno.Location = new System.Drawing.Point(162, 67);
            this.tbNoveJmeno.Name = "tbNoveJmeno";
            this.tbNoveJmeno.Size = new System.Drawing.Size(128, 22);
            this.tbNoveJmeno.TabIndex = 6;
            // 
            // ČtenářiUpravit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.tbNoveJmeno);
            this.Controls.Add(this.tbNovePrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNovePujcenychKnih);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNoveJmeno);
            this.Name = "ČtenářiUpravit";
            this.Text = "ČtenářiUpravit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoveJmeno;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbNovePujcenychKnih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNovePrijmeni;
        private System.Windows.Forms.TextBox tbNoveJmeno;
    }
}