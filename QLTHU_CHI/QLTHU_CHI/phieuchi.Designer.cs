namespace QLTHU_CHI
{
    partial class phieuchi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phieuchi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveprint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMachi = new System.Windows.Forms.RadioButton();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLYTHUCHIDataSet = new QLTHU_CHI.QLYTHUCHIDataSet();
            this.btSeach = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.dtNgaychi = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtgiamdoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtketoantruong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnguoinhan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tablePhieuchi = new System.Windows.Forms.DataGridView();
            this.nHANVIENTableAdapter = new QLTHU_CHI.QLYTHUCHIDataSetTableAdapters.NHANVIENTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLYTHUCHIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaychi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuchi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnSaveprint);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1456, 112);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng chính";
            // 
            // button1
            // 
            this.button1.Image = global::QLTHU_CHI.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(163, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::QLTHU_CHI.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(436, 38);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 47);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLTHU_CHI.Properties.Resources.Windows_Close_Program_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1053, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLTHU_CHI.Properties.Resources.bin;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(936, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::QLTHU_CHI.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(755, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 47);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveprint
            // 
            this.btnSaveprint.Image = global::QLTHU_CHI.Properties.Resources.floppy_disk;
            this.btnSaveprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveprint.Location = new System.Drawing.Point(563, 38);
            this.btnSaveprint.Name = "btnSaveprint";
            this.btnSaveprint.Size = new System.Drawing.Size(172, 47);
            this.btnSaveprint.TabIndex = 1;
            this.btnSaveprint.Text = "&Xuất ExceI ";
            this.btnSaveprint.UseVisualStyleBackColor = true;
            this.btnSaveprint.Click += new System.EventHandler(this.btnSaveprint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLTHU_CHI.Properties.Resources.plus;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(302, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButtonMachi);
            this.groupBox1.Controls.Add(this.cbnhanvien);
            this.groupBox1.Controls.Add(this.btSeach);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.dtNgaychi);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtgiamdoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtketoantruong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtlydo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSotien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnguoinhan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMachi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1456, 257);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(267, 203);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(214, 27);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Check tên người nhận";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonMachi
            // 
            this.radioButtonMachi.AutoSize = true;
            this.radioButtonMachi.Location = new System.Drawing.Point(35, 203);
            this.radioButtonMachi.Name = "radioButtonMachi";
            this.radioButtonMachi.Size = new System.Drawing.Size(193, 27);
            this.radioButtonMachi.TabIndex = 24;
            this.radioButtonMachi.TabStop = true;
            this.radioButtonMachi.Text = "Check theo mã đơn";
            this.radioButtonMachi.UseVisualStyleBackColor = true;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.DataSource = this.nHANVIENBindingSource;
            this.cbnhanvien.DisplayMember = "msnv";
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(1251, 65);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(199, 31);
            this.cbnhanvien.TabIndex = 23;
            this.cbnhanvien.ValueMember = "msnv";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLYTHUCHIDataSet;
            // 
            // qLYTHUCHIDataSet
            // 
            this.qLYTHUCHIDataSet.DataSetName = "QLYTHUCHIDataSet";
            this.qLYTHUCHIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSeach
            // 
            this.btSeach.Image = global::QLTHU_CHI.Properties.Resources.magnifying_glass;
            this.btSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSeach.Location = new System.Drawing.Point(884, 203);
            this.btSeach.Name = "btSeach";
            this.btSeach.Size = new System.Drawing.Size(149, 34);
            this.btSeach.TabIndex = 6;
            this.btSeach.Text = "&Tìm kiếm";
            this.btSeach.UseVisualStyleBackColor = true;
            this.btSeach.Click += new System.EventHandler(this.btSeach_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(655, 206);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(216, 30);
            this.txttk.TabIndex = 22;
            // 
            // dtNgaychi
            // 
            this.dtNgaychi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtNgaychi.EditValue = null;
            this.dtNgaychi.Location = new System.Drawing.Point(189, 111);
            this.dtNgaychi.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaychi.Name = "dtNgaychi";
            this.dtNgaychi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaychi.Properties.MaskSettings.Set("mask", "dd/MM/yyyy HH:mm:ss");
            this.dtNgaychi.Size = new System.Drawing.Size(179, 22);
            this.dtNgaychi.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(892, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(180, 30);
            this.txtemail.TabIndex = 17;
            // 
            // txtgiamdoc
            // 
            this.txtgiamdoc.Location = new System.Drawing.Point(1251, 150);
            this.txtgiamdoc.Name = "txtgiamdoc";
            this.txtgiamdoc.Size = new System.Drawing.Size(199, 30);
            this.txtgiamdoc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu chi:";
            // 
            // txtketoantruong
            // 
            this.txtketoantruong.Location = new System.Drawing.Point(1251, 106);
            this.txtketoantruong.Name = "txtketoantruong";
            this.txtketoantruong.Size = new System.Drawing.Size(199, 30);
            this.txtketoantruong.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người nhận tiền:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(892, 65);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(180, 30);
            this.txtsdt.TabIndex = 16;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(575, 106);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(180, 30);
            this.txtdiachi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lý do:";
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(575, 150);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(517, 30);
            this.txtlydo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại:";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(188, 150);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(180, 30);
            this.txtSotien.TabIndex = 13;
            this.txtSotien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSotien_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(761, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // txtnguoinhan
            // 
            this.txtnguoinhan.Location = new System.Drawing.Point(575, 66);
            this.txtnguoinhan.Name = "txtnguoinhan";
            this.txtnguoinhan.Size = new System.Drawing.Size(180, 30);
            this.txtnguoinhan.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1097, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Người chi tiền:";
            // 
            // txtMachi
            // 
            this.txtMachi.Location = new System.Drawing.Point(188, 66);
            this.txtMachi.Name = "txtMachi";
            this.txtMachi.Size = new System.Drawing.Size(180, 30);
            this.txtMachi.TabIndex = 11;
            this.txtMachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMachi_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1099, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kế toán trưởng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1099, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Giám đốc:";
            // 
            // tablePhieuchi
            // 
            this.tablePhieuchi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePhieuchi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePhieuchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhieuchi.Location = new System.Drawing.Point(12, 393);
            this.tablePhieuchi.Name = "tablePhieuchi";
            this.tablePhieuchi.RowHeadersWidth = 51;
            this.tablePhieuchi.RowTemplate.Height = 24;
            this.tablePhieuchi.Size = new System.Drawing.Size(1456, 308);
            this.tablePhieuchi.TabIndex = 25;
            this.tablePhieuchi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePhieuchi_CellContentClick);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // phieuchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 713);
            this.Controls.Add(this.tablePhieuchi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "phieuchi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.phieuchi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLYTHUCHIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaychi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveprint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonMachi;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Button btSeach;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtgiamdoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtketoantruong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnguoinhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtNgaychi;
        private System.Windows.Forms.DataGridView tablePhieuchi;
        private System.Windows.Forms.Button button1;
        private QLYTHUCHIDataSet qLYTHUCHIDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLYTHUCHIDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}