namespace BaoHanhNCC
{
    partial class FrmThemDTH
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMaDTH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNVLapDon = new System.Windows.Forms.ComboBox();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.btnThemCT_DTH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm đơn trả hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Location = new System.Drawing.Point(571, 211);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(136, 56);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMaDTH
            // 
            this.txtMaDTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDTH.Location = new System.Drawing.Point(197, 132);
            this.txtMaDTH.Name = "txtMaDTH";
            this.txtMaDTH.Size = new System.Drawing.Size(327, 26);
            this.txtMaDTH.TabIndex = 6;
            this.txtMaDTH.TextChanged += new System.EventHandler(this.txtMaDTH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã đơn trả hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(197, 183);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(327, 29);
            this.dtpNgayLap.TabIndex = 9;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày lập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã nhà cung cấp:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhân viên lập đơn:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbNVLapDon
            // 
            this.cbbNVLapDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNVLapDon.FormattingEnabled = true;
            this.cbbNVLapDon.Location = new System.Drawing.Point(197, 235);
            this.cbbNVLapDon.Name = "cbbNVLapDon";
            this.cbbNVLapDon.Size = new System.Drawing.Size(327, 32);
            this.cbbNVLapDon.TabIndex = 13;
            this.cbbNVLapDon.SelectedIndexChanged += new System.EventHandler(this.cbbNVLapDon_SelectedIndexChanged);
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(197, 291);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(327, 32);
            this.cbbMaNCC.TabIndex = 14;
            this.cbbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbbMaNCC_SelectedIndexChanged);
            // 
            // btnThemCT_DTH
            // 
            this.btnThemCT_DTH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT_DTH.ForeColor = System.Drawing.Color.Teal;
            this.btnThemCT_DTH.Location = new System.Drawing.Point(128, 379);
            this.btnThemCT_DTH.Name = "btnThemCT_DTH";
            this.btnThemCT_DTH.Size = new System.Drawing.Size(446, 51);
            this.btnThemCT_DTH.TabIndex = 15;
            this.btnThemCT_DTH.Text = "Thêm chi tiết Đơn trả hàng";
            this.btnThemCT_DTH.UseVisualStyleBackColor = true;
            this.btnThemCT_DTH.Click += new System.EventHandler(this.btnThemCT_DTH_Click);
            // 
            // FrmThemDTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 592);
            this.Controls.Add(this.btnThemCT_DTH);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.cbbNVLapDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDTH);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemDTH";
            this.Text = "FrmTimDON_TRA_HANG";
            this.Load += new System.EventHandler(this.FrmThemDTH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtMaDTH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNVLapDon;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Button btnThemCT_DTH;
    }
}