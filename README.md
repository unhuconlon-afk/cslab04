# Windows Programming with C# - LAB 04: Picture Slide Show

Kho lưu trữ bài tập thực hành môn **Lập trình trên môi trường Windows với C# (Windows Programming with C#)**:
**Ứng dụng xem ảnh và trình chiếu Picture Slide Show (Windows Forms Application)**.

---

## Mục tiêu bài thực hành
Xây dựng một ứng dụng C# Windows Forms hoàn chỉnh có khả năng:
- Mở và duyệt thư mục hình ảnh bất kỳ từ máy tính bằng `FolderBrowserDialog`.
- Lọc và hiển thị danh sách tất cả các tập tin ảnh có định dạng phổ biến (`*.jpg`, `*.jpeg`, `*.bmp`, `*.png`).
- Hiển thị hình ảnh mượt mà trên control `PictureBox` với chế độ tự động căn chỉnh kích thước `Zoom` / `StretchImage`.
- Điều khiển chuyển ảnh thủ công bằng 2 nút lệnh:
  - `<< Trước` (`btnPrevious`)
  - `Sau >>` (`btnNext`)
  - Hỗ trợ xoay vòng ảnh: khi ở ảnh đầu bấm `<< Trước` sẽ quay về ảnh cuối, khi ở ảnh cuối bấm `Sau >>` sẽ quay lại ảnh đầu.
- Tính năng **Trình chiếu tự động (Slide Show)**:
  - Điều khiển bằng nút `<< Bắt đầu Slide Show >>` / `<< Kết thúc Slide Show >>`.
  - Sử dụng control `Timer` (`timer1`) để kích hoạt chuyển ảnh tự động.
  - Cho phép tùy chỉnh tốc độ chuyển slide: 1 giây, 2 giây, 3 giây, 5 giây qua ComboBox.
  - Thanh trạng thái hiển thị chi tiết tên file, thứ tự ảnh (`[1 / 4]`) và kích thước gốc của ảnh.

---

## Cấu trúc thư mục dự án

```text
cslab04/
├── .gitignore
├── README.md
├── PictureSlideShow.sln             # Solution Visual Studio
├── PictureSlideShow/
│   ├── PictureSlideShow.csproj      # File cấu hình dự án .NET Windows Forms
│   ├── Program.cs                   # Điểm khởi chạy ứng dụng
│   ├── Form1.cs                     # Xử lý logic sự kiện (Open, Next, Prev, SlideShow, Timer)
│   └── Form1.Designer.cs            # Thiết kế giao diện Form (PictureBox, Buttons, Timer, Panel)
└── SampleImages/                    # Thư mục hình ảnh mẫu để thử nghiệm slide show ngay lập tức
    ├── sample_01.jpg
    ├── sample_02.jpg
    ├── sample_03.bmp
    └── sample_04.png
```

---

## Hướng dẫn thực thi

### 1. Mở bằng Visual Studio
- Nhấp đúp vào file `PictureSlideShow.sln`.
- Bấm phím **F5** (hoặc **Ctrl + F5**) để khởi chạy ứng dụng.
- Nhấn **Mở Thư Mục hình** và chọn thư mục `SampleImages` có sẵn trong dự án.

### 2. Chạy bằng .NET CLI
```bash
# Di chuyển vào thư mục cslab04 và chạy lệnh:
dotnet run --project PictureSlideShow/PictureSlideShow.csproj
```
