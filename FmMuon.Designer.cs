﻿
namespace QUANLITHUVIENWINFORM
{
    partial class FmMuon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCTMuon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNgaymuon = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMuon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMathe = new System.Windows.Forms.ComboBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMathe);
            this.panel2.Controls.Add(this.btnCTMuon);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lbNgaymuon);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.txtNgayMuon);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.ptbSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvMuon);
            this.panel2.Location = new System.Drawing.Point(1, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 373);
            this.panel2.TabIndex = 4;
            // 
            // btnCTMuon
            // 
            this.btnCTMuon.BackColor = System.Drawing.Color.Yellow;
            this.btnCTMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCTMuon.FlatAppearance.BorderSize = 0;
            this.btnCTMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTMuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCTMuon.Location = new System.Drawing.Point(504, 192);
            this.btnCTMuon.Name = "btnCTMuon";
            this.btnCTMuon.Size = new System.Drawing.Size(87, 43);
            this.btnCTMuon.TabIndex = 27;
            this.btnCTMuon.Text = "Chi Tiết";
            this.btnCTMuon.UseVisualStyleBackColor = false;
            this.btnCTMuon.Click += new System.EventHandler(this.btnCTMuon_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(374, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 43);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNgaymuon
            // 
            this.lbNgaymuon.AutoSize = true;
            this.lbNgaymuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaymuon.Location = new System.Drawing.Point(346, 105);
            this.lbNgaymuon.Name = "lbNgaymuon";
            this.lbNgaymuon.Size = new System.Drawing.Size(70, 15);
            this.lbNgaymuon.TabIndex = 22;
            this.lbNgaymuon.Text = "Ngày Mượn";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(490, 56);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 15);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Mã thẻ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(346, 56);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(59, 15);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Mã mượn";
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Location = new System.Drawing.Point(418, 103);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(199, 20);
            this.txtNgayMuon.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(418, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvMuon
            // 
            this.dgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuon.Location = new System.Drawing.Point(0, 41);
            this.dgvMuon.Name = "dgvMuon";
            this.dgvMuon.Size = new System.Drawing.Size(321, 320);
            this.dgvMuon.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 55);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí mượn";
            // 
            // cbMathe
            // 
            this.cbMathe.FormattingEnabled = true;
            this.cbMathe.Location = new System.Drawing.Point(545, 53);
            this.cbMathe.Name = "cbMathe";
            this.cbMathe.Size = new System.Drawing.Size(72, 21);
            this.cbMathe.TabIndex = 28;
            // 
            // ptbSearch
            // 
            this.ptbSearch.Image = global::QUANLITHUVIENWINFORM.Properties.Resources._49116;
            this.ptbSearch.Location = new System.Drawing.Point(185, 15);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(26, 20);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 5;
            this.ptbSearch.TabStop = false;
            // 
            // FmMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FmMuon";
            this.Text = "FmMuon";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbNgaymuon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCTMuon;
        private System.Windows.Forms.ComboBox cbMathe;
    }
}