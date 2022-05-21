
namespace QUANLITHUVIENWINFORM
{
    partial class FmTheTV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTacgia = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDocgia = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTen = new System.Windows.Forms.ComboBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 68);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí thẻ thư viện";
            // 
            // dgvThe
            // 
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Location = new System.Drawing.Point(0, 50);
            this.dgvThe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.RowHeadersWidth = 51;
            this.dgvThe.Size = new System.Drawing.Size(482, 394);
            this.dgvThe.TabIndex = 3;
            this.dgvThe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvThe_CellMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ptbSearch
            // 
            this.ptbSearch.Image = global::QUANLITHUVIENWINFORM.Properties.Resources._49116;
            this.ptbSearch.Location = new System.Drawing.Point(252, 18);
            this.ptbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(35, 25);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 5;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(612, 58);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(279, 22);
            this.txtId.TabIndex = 16;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Enabled = false;
            this.txtGhichu.Location = new System.Drawing.Point(612, 219);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(279, 22);
            this.txtGhichu.TabIndex = 19;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(496, 60);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(55, 20);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Mã thẻ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(496, 113);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(99, 20);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Ngày bắt đầu";
            // 
            // lbTacgia
            // 
            this.lbTacgia.AutoSize = true;
            this.lbTacgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacgia.Location = new System.Drawing.Point(496, 167);
            this.lbTacgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTacgia.Name = "lbTacgia";
            this.lbTacgia.Size = new System.Drawing.Size(100, 20);
            this.lbTacgia.TabIndex = 22;
            this.lbTacgia.Text = "Ngày kết thúc";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(496, 219);
            this.lbNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(58, 20);
            this.lbNXB.TabIndex = 23;
            this.lbNXB.Text = "Ghi chú";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(546, 391);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 36);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(676, 391);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 36);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(801, 391);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 36);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbDocgia
            // 
            this.lbDocgia.AutoSize = true;
            this.lbDocgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocgia.Location = new System.Drawing.Point(496, 271);
            this.lbDocgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDocgia.Name = "lbDocgia";
            this.lbDocgia.Size = new System.Drawing.Size(87, 20);
            this.lbDocgia.TabIndex = 28;
            this.lbDocgia.Text = "Mã Độc Giả";
            // 
            // cbID
            // 
            this.cbID.Enabled = false;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(500, 309);
            this.cbID.Margin = new System.Windows.Forms.Padding(4);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(83, 24);
            this.cbID.TabIndex = 29;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Độc Giả";
            // 
            // cbTen
            // 
            this.cbTen.Enabled = false;
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(612, 309);
            this.cbTen.Margin = new System.Windows.Forms.Padding(4);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(279, 24);
            this.cbTen.TabIndex = 31;
            this.cbTen.SelectedIndexChanged += new System.EventHandler(this.cbTen_SelectedIndexChanged);
            // 
            // dtpBD
            // 
            this.dtpBD.CustomFormat = "dd/MM/yyyy";
            this.dtpBD.Location = new System.Drawing.Point(612, 111);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(279, 22);
            this.dtpBD.TabIndex = 32;
            this.dtpBD.Value = new System.DateTime(2022, 5, 14, 19, 12, 43, 0);
            // 
            // dtpKT
            // 
            this.dtpKT.CustomFormat = "dd/MM/yyyy";
            this.dtpKT.Location = new System.Drawing.Point(612, 165);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(279, 22);
            this.dtpKT.TabIndex = 33;
            this.dtpKT.Value = new System.DateTime(2022, 5, 14, 19, 13, 15, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpKT);
            this.panel2.Controls.Add(this.dtpBD);
            this.panel2.Controls.Add(this.cbTen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbID);
            this.panel2.Controls.Add(this.lbDocgia);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lbNXB);
            this.panel2.Controls.Add(this.lbTacgia);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.ptbSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvThe);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 459);
            this.panel2.TabIndex = 4;
            // 
            // FmTheTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmTheTV";
            this.Text = "FmTheTV";
            this.Load += new System.EventHandler(this.FmTheTV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTacgia;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbDocgia;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTen;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.Panel panel2;
    }
}