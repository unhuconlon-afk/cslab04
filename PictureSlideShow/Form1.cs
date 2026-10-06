using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureSlideShow
{
    public partial class Form1 : Form
    {
        // Bước 1: Khai báo các biến theo hướng dẫn trong tài liệu
        private string[]? folderFile = null;
        private int selected = 0;
        private int begin = 0;
        private int end = 0;

        public Form1()
        {
            InitializeComponent();
            cboSpeed.SelectedIndex = 1; // Mặc định 2 giây / ảnh
        }

        // Bước 2: Hàm xử lý sự kiện Click cho nút Open (btnOpen)
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Chọn thư mục chứa hình ảnh cần xem Slide Show:";
                folderBrowserDialog1.ShowNewFolderButton = false;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;

                    // Lấy các tập tin ảnh JPG, JPEG, BMP (và hỗ trợ thêm PNG)
                    string[] part1 = Directory.GetFiles(path, "*.jpg");
                    string[] part2 = Directory.GetFiles(path, "*.jpeg");
                    string[] part3 = Directory.GetFiles(path, "*.bmp");
                    string[] part4 = Directory.GetFiles(path, "*.png");

                    int total = part1.Length + part2.Length + part3.Length + part4.Length;
                    if (total == 0)
                    {
                        MessageBox.Show("Thư mục đã chọn không có hình ảnh (.jpg, .jpeg, .bmp, .png) nào!",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    folderFile = new string[total];
                    Array.Copy(part1, 0, folderFile, 0, part1.Length);
                    Array.Copy(part2, 0, folderFile, part1.Length, part2.Length);
                    Array.Copy(part3, 0, folderFile, part1.Length + part2.Length, part3.Length);
                    Array.Copy(part4, 0, folderFile, part1.Length + part2.Length + part3.Length, part4.Length);

                    selected = 0;
                    begin = 0;
                    end = folderFile.Length - 1;

                    // Dừng slide show nếu đang chạy
                    if (timer1.Enabled)
                    {
                        timer1.Enabled = false;
                        btnStart.Text = "<< Bắt đầu Slide Show >>";
                        btnStart.BackColor = Color.FromArgb(40, 167, 69);
                    }

                    showImage(folderFile[selected]);

                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnStart.Enabled = true;
                }
            }
        }

        // Hàm hiển thị hình ảnh theo đường dẫn
        private void showImage(string path)
        {
            try
            {
                if (!File.Exists(path)) return;

                // Giải phóng ảnh cũ nếu có để không bị chiếm dụng bộ nhớ / khóa file
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                // Đọc ảnh vào bộ nhớ an toàn
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string fileName = Path.GetFileName(path);
                lblStatus.Text = $"Đang hiển thị [{selected + 1} / {folderFile?.Length}]: {fileName} (Kích thước gốc: {pictureBox1.Image.Width} x {pictureBox1.Image.Height})";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Lỗi khi tải ảnh: {ex.Message}";
            }
        }

        // Bước 3: Hàm prevImage() được gọi trong sự kiện Click của nút <<Trước
        private void prevImage()
        {
            if (folderFile == null || folderFile.Length == 0) return;

            if (selected <= begin)
            {
                selected = end;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1;
                showImage(folderFile[selected]);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            prevImage();
        }

        // Bước 4: Hàm nextImage() được gọi trong sự kiện Click của nút Sau>>
        private void nextImage()
        {
            if (folderFile == null || folderFile.Length == 0) return;

            if (selected >= end)
            {
                selected = begin;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1;
                showImage(folderFile[selected]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextImage();
        }

        // Bước 5: Bổ sung sự kiện Tick của control Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            nextImage();
        }

        // Bước 6: Xử lý sự kiện Click của nút Bắt đầu (btnStart)
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnStart.Text = "<< Bắt đầu Slide Show >>";
                btnStart.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                timer1.Enabled = true;
                btnStart.Text = "<< Kết thúc Slide Show >>";
                btnStart.BackColor = Color.FromArgb(220, 53, 69);
            }
        }

        private void cboSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSpeed.SelectedIndex)
            {
                case 0: timer1.Interval = 1000; break; // 1s
                case 1: timer1.Interval = 2000; break; // 2s
                case 2: timer1.Interval = 3000; break; // 3s
                case 3: timer1.Interval = 5000; break; // 5s
                default: timer1.Interval = 2000; break;
            }
        }
    }
}
