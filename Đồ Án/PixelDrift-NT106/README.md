# 🏎️ Pixel Drift - Game Đua Xe Mạng LAN (Real-time)

> **Đồ án môn học:** Lập trình mạng căn bản / Thực hành Lập trình mạng
> **Nhóm thực hiện:** Pixel Drift Team (5 thành viên)

---

## 📖 Giới thiệu
**Pixel Drift** là tựa game đua xe đối kháng 2 người chơi trong thời gian thực (Real-time). Dự án được xây dựng để giải quyết bài toán đồng bộ chuyển động tốc độ cao trong môi trường mạng LAN/VPN mà không gây giật lag.

Thay vì sử dụng Web Server truyền thống, game sử dụng kết nối **TCP Socket** trực tiếp để đảm bảo độ trễ thấp nhất (Zero Latency).

---

## 🚀 Tính năng chính

* **🎮 Gameplay thời gian thực:** Đồng bộ vị trí xe và vật cản mượt mà (60 FPS) giữa 2 máy tính.
* **🏠 Sảnh chờ:** Hỗ trợ Tạo phòng, Vào phòng theo ID và Tìm kiếm người chơi đang online.
* **🔐 Hệ thống tài khoản:** Đăng ký, Đăng nhập bảo mật, Quên mật khẩu và Xem hồ sơ cá nhân.
* **🏆 Bảng xếp hạng:** Lưu trữ thành tích và hiển thị Top 50 tay đua xuất sắc nhất.
* **💾 Lưu trữ thông minh:** Tự động cộng dồn điểm số vào Database ngay khi kết thúc trận đấu.

---

## 🛠 Công nghệ sử dụng

* **Ngôn ngữ:** C# (.NET Framework)
* **Nền tảng:** Windows Forms (WinForms)
* **Giao thức mạng:** TCP Sockets (Gameplay) & UDP (Tự tìm IP Server).
* **Cơ sở dữ liệu:** SQLite (Nhúng, không cần cài đặt).
* **Dữ liệu:** JSON (Newtonsoft.Json).

---

*© 2025 - PixelDriftTeam - UIT*
