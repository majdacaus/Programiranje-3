namespace Studentska.WinApp.IB24xxxx
{
    partial class frmPretragaIB24xxxx
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtPretraga = new TextBox();
            cmbStatus = new ComboBox();
            dgvPodaci = new DataGridView();
            btnKompanijaAdd = new Button();
            btnPraksaAdd = new Button();
            btnPrint = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(35, 46);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(342, 31);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(393, 42);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(158, 33);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Location = new Point(35, 94);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 62;
            dgvPodaci.Size = new Size(1060, 345);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellClick += dgvPodaci_CellClick;
            dgvPodaci.CellDoubleClick += dgvPodaci_CellDoubleClick;
            // 
            // btnKompanijaAdd
            // 
            btnKompanijaAdd.Location = new Point(742, 40);
            btnKompanijaAdd.Name = "btnKompanijaAdd";
            btnKompanijaAdd.Size = new Size(176, 34);
            btnKompanijaAdd.TabIndex = 3;
            btnKompanijaAdd.Text = "Nova kompanija";
            btnKompanijaAdd.UseVisualStyleBackColor = true;
            btnKompanijaAdd.Click += btnKompanijaAdd_Click;
            // 
            // btnPraksaAdd
            // 
            btnPraksaAdd.Location = new Point(942, 40);
            btnPraksaAdd.Name = "btnPraksaAdd";
            btnPraksaAdd.Size = new Size(153, 34);
            btnPraksaAdd.TabIndex = 4;
            btnPraksaAdd.Text = "Nova praksa";
            btnPraksaAdd.UseVisualStyleBackColor = true;
            btnPraksaAdd.Click += btnPraksaAdd_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(983, 466);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 16);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 6;
            label1.Text = "Ime prezime ili naziv kompanije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 7;
            label2.Text = "Status";
            // 
            // frmPretragaIB24xxxx
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 523);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrint);
            Controls.Add(btnPraksaAdd);
            Controls.Add(btnKompanijaAdd);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbStatus);
            Controls.Add(txtPretraga);
            Name = "frmPretragaIB24xxxx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB24xxxx_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        private ComboBox cmbStatus;
        private DataGridView dgvPodaci;
        private Button btnKompanijaAdd;
        private Button btnPraksaAdd;
        private Button btnPrint;
        private Label label1;
        private Label label2;
    }
}