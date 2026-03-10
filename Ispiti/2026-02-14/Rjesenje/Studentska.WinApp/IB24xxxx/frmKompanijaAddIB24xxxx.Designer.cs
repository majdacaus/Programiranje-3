namespace Studentska.WinApp.IB24xxxx
{
    partial class frmKompanijaAddIB24xxxx
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
            components = new System.ComponentModel.Container();
            pbSlika = new PictureBox();
            txtNaziv = new TextBox();
            cmbGrad = new ComboBox();
            txtURL = new TextBox();
            txtAdresa = new TextBox();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbAktivna = new CheckBox();
            txtMaxStudenata = new TextBox();
            label5 = new Label();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(19, 28);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(163, 162);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(278, 71);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 31);
            txtNaziv.TabIndex = 1;
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(514, 69);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(200, 33);
            cmbGrad.TabIndex = 2;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(514, 150);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(200, 31);
            txtURL.TabIndex = 3;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(278, 150);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(200, 31);
            txtAdresa.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(602, 275);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(112, 34);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 122);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 6;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 122);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 7;
            label2.Text = "Adresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 39);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 8;
            label3.Text = "Grad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 39);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 9;
            label4.Text = "Naziv";
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(523, 220);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(97, 29);
            cbAktivna.TabIndex = 10;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // txtMaxStudenata
            // 
            txtMaxStudenata.Location = new Point(278, 226);
            txtMaxStudenata.Name = "txtMaxStudenata";
            txtMaxStudenata.Size = new Size(200, 31);
            txtMaxStudenata.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 198);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 12;
            label5.Text = "Maksimalno studenata";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbSlika);
            groupBox1.Location = new Point(44, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 216);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Logo";
            // 
            // frmKompanijaAddIB24xxxx
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 337);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(txtMaxStudenata);
            Controls.Add(cbAktivna);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtAdresa);
            Controls.Add(txtURL);
            Controls.Add(cmbGrad);
            Controls.Add(txtNaziv);
            Name = "frmKompanijaAddIB24xxxx";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kompanija";
            Load += frmKompanijaAddIB24xxxx_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private TextBox txtNaziv;
        private ComboBox cmbGrad;
        private TextBox txtURL;
        private TextBox txtAdresa;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox cbAktivna;
        private TextBox txtMaxStudenata;
        private Label label5;
        private ErrorProvider err;
        private GroupBox groupBox1;
    }
}