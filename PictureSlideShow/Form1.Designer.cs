namespace PictureSlideShow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            lblTitle = new Label();
            panelBottom = new Panel();
            lblSpeed = new Label();
            cboSpeed = new ComboBox();
            lblStatus = new Label();
            btnStart = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnOpen = new Button();
            panelImage = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(24, 76, 120);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(884, 50);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHƯƠNG TRÌNH XEM ẢNH & PICTURE SLIDE SHOW";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(245, 247, 250);
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(lblSpeed);
            panelBottom.Controls.Add(cboSpeed);
            panelBottom.Controls.Add(lblStatus);
            panelBottom.Controls.Add(btnStart);
            panelBottom.Controls.Add(btnNext);
            panelBottom.Controls.Add(btnPrevious);
            panelBottom.Controls.Add(btnOpen);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 521);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(884, 90);
            panelBottom.TabIndex = 1;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeed.Location = new Point(715, 18);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(47, 15);
            lblSpeed.TabIndex = 6;
            lblSpeed.Text = "Tốc độ:";
            // 
            // cboSpeed
            // 
            cboSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpeed.FormattingEnabled = true;
            cboSpeed.Items.AddRange(new object[] { "1 giây / ảnh", "2 giây / ảnh", "3 giây / ảnh", "5 giây / ảnh" });
            cboSpeed.Location = new Point(715, 38);
            cboSpeed.Name = "cboSpeed";
            cboSpeed.Size = new Size(110, 23);
            cboSpeed.TabIndex = 5;
            cboSpeed.SelectedIndexChanged += cboSpeed_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(12, 60);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(860, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Chưa có thư mục hình nào được chọn. Nhấn 'Mở Thư Mục hình' để bắt đầu.";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(40, 167, 69);
            btnStart.Enabled = false;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(495, 15);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 38);
            btnStart.TabIndex = 3;
            btnStart.Text = "<< Bắt đầu Slide Show >>";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(23, 162, 184);
            btnNext.Enabled = false;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(375, 15);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 38);
            btnNext.TabIndex = 2;
            btnNext.Text = "Sau >>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(23, 162, 184);
            btnPrevious.Enabled = false;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(255, 15);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 38);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<< Trước";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(0, 123, 255);
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(65, 15);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(170, 38);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Mở Thư Mục hình";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // panelImage
            // 
            panelImage.BackColor = Color.FromArgb(30, 30, 30);
            panelImage.Controls.Add(pictureBox1);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(0, 50);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(884, 471);
            panelImage.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 471);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += Timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(panelImage);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MinimumSize = new Size(700, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo Picture Slide Show - Windows Programming C#";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblTitle;
        private Panel panelBottom;
        private Button btnStart;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnOpen;
        private Label lblStatus;
        private ComboBox cboSpeed;
        private Label lblSpeed;
        private Panel panelImage;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
