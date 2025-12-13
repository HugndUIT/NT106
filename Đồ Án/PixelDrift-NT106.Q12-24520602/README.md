# 🏎️ Pixel Drift - Real-time Multiplayer Racing Game

> **Đồ án môn học: Lập trình mạng căn bản**
>
> Một tựa game đua xe đối kháng thời gian thực (Real-time) được xây dựng trên nền tảng **C# WinForms**, sử dụng kỹ thuật **TCP Socket** để đảm bảo độ trễ thấp nhất.

![Banner Game](https://via.placeholder.com/800x200?text=Pixel+Drift+Game+Banner)

---

## 📑 Mục lục
1. [Giới thiệu](#-giới-thiệu)
2. [Tính năng nổi bật](#-tính-năng-nổi-bật)
3. [Công nghệ sử dụng](#-công-nghệ-sử-dụng)
4. [Kiến trúc hệ thống & Database](#-kiến-trúc-hệ-thống--database)
5. [Cài đặt & Hướng dẫn sử dụng](#-cài-đặt--hướng-dẫn-sử-dụng)
6. [Thành viên thực hiện](#-thành-viên-thực-hiện)

---

## 📖 Giới thiệu

**Pixel Drift** giải quyết bài toán đồng bộ dữ liệu tốc độ cao trong môi trường mạng LAN/VPN. Thay vì sử dụng các mô hình Web Server truyền thống (HTTP) gây độ trễ, nhóm phát triển đã xây dựng một hệ thống **Client-Server** thuần túy sử dụng **Socket**, cho phép cập nhật vị trí và trạng thái xe liên tục (60 FPS) giữa các người chơi.

---

## 🚀 Tính năng nổi bật

### 1. Hệ thống Tài khoản & Sảnh (Lobby)
* 🔐 **Đăng ký / Đăng nhập:** Bảo mật mật khẩu (Mã hóa), xác thực tài khoản.
* 📧 **Quên mật khẩu:** Hỗ trợ lấy lại mật khẩu qua Email.
* 🏠 **Phòng Game:**
    * Tạo phòng (Host).
    * Vào phòng (Join) qua ID.
    * Tìm kiếm người chơi online.

### 2. Gameplay (Real-time)
* 🏎️ **Đồng bộ vị trí:** Sử dụng gói tin JSON qua TCP để đồng bộ tọa độ X, Y của xe đối thủ mượt mà.
* 💥 **Xử lý va chạm:** Server tính toán va chạm với chướng ngại vật và gửi phản hồi rung/âm thanh về Client.
* ⏱️ **Đồng bộ thời gian:** Thời gian trận đấu được quản lý tập trung tại Server.
* 🏆 **Lưu điểm tự động:** Tự động ghi nhận thành tích vào Database ngay khi kết thúc ván.

### 3. Thống kê
* 📊 **Bảng xếp hạng (Leaderboard):** Top 50 người chơi điểm cao nhất.
* 🔍 **Tìm kiếm lịch sử:** Tra cứu thành tích của người chơi bất kỳ.

---

## 🛠 Công nghệ sử dụng

| Thành phần | Công nghệ / Thư viện |
| :--- | :--- |
| **Ngôn ngữ** | C# (.NET Framework) |
| **Giao diện** | Windows Forms (WinForms) |
| **Giao thức mạng** | **TCP Sockets** (System.Net.Sockets) cho Gameplay.<br>**UDP** cho việc tự động tìm IP Server (Broadcast). |
| **Cơ sở dữ liệu** | **SQLite** (Nhúng trực tiếp, không cần cài đặt Server SQL). |
| **Định dạng tin** | JSON (Newtonsoft.Json) để đóng gói dữ liệu. |

---

## 🏗 Kiến trúc hệ thống & Database

### 1. Tại sao dùng Socket thay vì HTTP?
Game yêu cầu tốc độ cập nhật 60 lần/giây.
* **HTTP (Request-Response):** Phải thiết lập lại kết nối liên tục $\rightarrow$ Độ trễ cao, lag.
* **TCP Socket (Full-duplex):** Giữ kết nối liên tục, Server chủ động đẩy dữ liệu (Push) $\rightarrow$ **Trải nghiệm mượt mà, Real-time.**

### 2. Thiết kế Database (SQLite)
Hệ thống sử dụng mô hình quan hệ **1-1** tối ưu hóa:

* **Bảng `Info_User`:** Lưu thông tin đăng nhập (Username, Password, Email).
* **Bảng `ScoreBoard`:** Lưu thành tích tích lũy.
    * Sử dụng `UserId` làm Khóa chính (PK) và Khóa ngoại (FK).
    * Cơ chế **Upsert**: Cộng dồn điểm vào dòng cũ, không tạo dòng rác.

```mermaid
erDiagram
    Info_User ||--|| ScoreBoard : "1 User - 1 Bảng điểm"
    Info_User { int Id, string Username, string Password }
    ScoreBoard { int UserId, int WinCount, real TotalScore }
