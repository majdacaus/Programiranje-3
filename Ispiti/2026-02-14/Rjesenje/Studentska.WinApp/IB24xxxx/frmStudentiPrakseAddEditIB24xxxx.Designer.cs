namespace Studentska.WinApp.IB24xxxx
{
    partial class frmStudentiPrakseAddEditIB24xxxx
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
            cmbStudent = new ComboBox();
            cmbKompanija = new ComboBox();
            cmbStatus = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnGenerisi = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(33, 58);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(372, 33);
            cmbStudent.TabIndex = 0;
            // 
            // cmbKompanija
            // 
            cmbKompanija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKompanija.FormattingEnabled = true;
            cmbKompanija.Location = new Point(441, 58);
            cmbKompanija.Name = "cmbKompanija";
            cmbKompanija.Size = new Size(372, 33);
            cmbKompanija.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Enabled = false;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(441, 139);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(372, 33);
            cmbStatus.TabIndex = 0;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(33, 141);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(372, 31);
            dtpDatumPrijave.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(29, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 336);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(15, 30);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(763, 34);
            btnGenerisi.TabIndex = 8;
            btnGenerisi.Text = "Generisi zahtjeve";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(763, 250);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Kompanija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 5;
            label3.Text = "Datum prijave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 111);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(701, 188);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(112, 34);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentiPrakseAddEditIB24xxxx
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 569);
            Controls.Add(btnSacuvaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbKompanija);
            Controls.Add(cmbStudent);
            Name = "frmStudentiPrakseAddEditIB24xxxx";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Praksa";
            Load += frmStudentiPrakseAddEditIB24xxxx_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbKompanija;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDatumPrijave;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGenerisi;
        private Button btnSacuvaj;
        private ErrorProvider err;
    }
}