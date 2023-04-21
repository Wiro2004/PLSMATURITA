namespace PlsMaturita2
{
    partial class KnihyUpravit
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
            this.btnOkEditKnihy = new System.Windows.Forms.Button();
            this.tbNazevEdit = new System.Windows.Forms.TextBox();
            this.dtDatumEdit = new System.Windows.Forms.DateTimePicker();
            this.tbAutorEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název";
            // 
            // btnOkEditKnihy
            // 
            this.btnOkEditKnihy.Location = new System.Drawing.Point(119, 253);
            this.btnOkEditKnihy.Name = "btnOkEditKnihy";
            this.btnOkEditKnihy.Size = new System.Drawing.Size(143, 55);
            this.btnOkEditKnihy.TabIndex = 1;
            this.btnOkEditKnihy.Text = "Ok";
            this.btnOkEditKnihy.UseVisualStyleBackColor = true;
            // 
            // tbNazevEdit
            // 
            this.tbNazevEdit.Location = new System.Drawing.Point(119, 62);
            this.tbNazevEdit.Name = "tbNazevEdit";
            this.tbNazevEdit.Size = new System.Drawing.Size(161, 22);
            this.tbNazevEdit.TabIndex = 2;
            // 
            // dtDatumEdit
            // 
            this.dtDatumEdit.Location = new System.Drawing.Point(100, 183);
            this.dtDatumEdit.Name = "dtDatumEdit";
            this.dtDatumEdit.Size = new System.Drawing.Size(200, 22);
            this.dtDatumEdit.TabIndex = 3;
            // 
            // tbAutorEdit
            // 
            this.tbAutorEdit.Location = new System.Drawing.Point(119, 127);
            this.tbAutorEdit.Name = "tbAutorEdit";
            this.tbAutorEdit.Size = new System.Drawing.Size(161, 22);
            this.tbAutorEdit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // KnihyUpravit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAutorEdit);
            this.Controls.Add(this.dtDatumEdit);
            this.Controls.Add(this.tbNazevEdit);
            this.Controls.Add(this.btnOkEditKnihy);
            this.Controls.Add(this.label1);
            this.Name = "KnihyUpravit";
            this.Text = "KnihyUpravit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkEditKnihy;
        private System.Windows.Forms.TextBox tbNazevEdit;
        private System.Windows.Forms.DateTimePicker dtDatumEdit;
        private System.Windows.Forms.TextBox tbAutorEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}