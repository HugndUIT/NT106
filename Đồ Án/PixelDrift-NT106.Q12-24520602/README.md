# 🏎️ Pixel Drift - Real-time Multiplayer Racing Game

![Status](https://img.shields.io/badge/Status-Completed-success) ![Platform](https://img.shields.io/badge/Platform-Windows_Forms-blue) ![Language](https://img.shields.io/badge/Language-C%23-green)

> **Đồ án môn học: Lập trình mạng căn bản / Thực hành Lập trình mạng**
>
> Một tựa game đua xe đối kháng thời gian thực (Real-time) được xây dựng trên nền tảng **C# WinForms**, sử dụng kỹ thuật **TCP Socket** để đảm bảo độ trễ thấp nhất trong môi trường LAN/VPN.

---

## 📑 Mục lục
1. [Giới thiệu](#-giới-thiệu)
2. [Tính năng nổi bật](#-tính-năng-nổi-bật)
3. [Công nghệ sử dụng](#-công-nghệ-sử-dụng)
4. [Kiến trúc hệ thống](#-kiến-trúc-hệ-thống)
5. [Thiết kế Cơ sở dữ liệu](#-thiết-kế-cơ-sở-dữ-liệu)
6. [Cài đặt & Hướng dẫn sử dụng](#-cài-đặt--hướng-dẫn-sử-dụng)
7. [Thành viên thực hiện](#-thành-viên-thực-hiện)

---

## 📖 Giới thiệu

**Pixel Drift** giải quyết bài toán đồng bộ dữ liệu tốc độ cao. Thay vì sử dụng các mô hình Web Server truyền thống (HTTP) gây độ trễ, nhóm phát triển đã xây dựng một hệ thống **Client-Server** thuần túy sử dụng **Socket**, cho phép cập nhật vị trí và trạng thái xe liên tục (60 FPS) giữa các người chơi.

**Điểm nhấn:**
* ⚡ **Zero Latency Logic:** Sử dụng giao thức TCP truyền trưc tiếp gói tin JSON.
* 🛡️ **Bảo mật:** Mã hóa mật khẩu, xác thực phiên làm việc.
* 💾 **Persistance:** Lưu trữ dữ liệu người dùng bền vững với SQLite.

---

## 🚀 Tính năng nổi bật

### 1. Hệ thống Tài khoản (Auth)
* **Đăng ký / Đăng nhập:** Xác thực người dùng, mã hóa mật khẩu trước khi lưu.
* **Quên mật khẩu:** Quy trình lấy lại mật khẩu an toàn.
* **Thông tin cá nhân:** Xem và cập nhật hồ sơ người chơi.

### 2. Sảnh chờ (Lobby)
* **Tạo phòng (Host):** Người chơi tự tạo phòng và chờ đối thủ.
* **Vào phòng (Join):** Tìm và vào phòng thông qua ID hoặc IP.
* **Tìm kiếm:** Tra cứu người chơi online.
* **Bảng xếp hạng:** Xem Top 50 cao thủ (Update real-time).

### 3. Gameplay (Real-time)
* **Đồng bộ tọa độ:** Xe đối thủ di chuyển mượt mà nhờ gói tin JSON cập nhật 60 lần/giây.
* **Vật lý & Va chạm:** Xử lý va chạm chướng ngại vật phía Server, trả phản hồi (rung/âm thanh) về Client.
* **Lưu điểm thông minh:** Cơ chế Upsert (Cập nhật hoặc Thêm mới) điểm số ngay khi ván đấu kết thúc.

---

## 🛠 Công nghệ sử dụng

| Thành phần | Công nghệ / Thư viện |
| :--- | :--- |
| **Ngôn ngữ** | C# (.NET Framework 4.7.2+) |
| **Framework** | Windows Forms (WinForms) |
| **Networking** | `System.Net.Sockets` (TCP cho Game, UDP cho Discovery) |
| **Database** | **SQLite** (Nhúng, không cần cài server riêng) |
| **Serialization** | `Newtonsoft.Json` (JSON.NET) |

---

## 🏗 Kiến trúc hệ thống

### Tại sao chọn TCP Socket thay vì HTTP?

Game yêu cầu tốc độ phản hồi tính bằng mili-giây.

| Tiêu chí | HTTP (Web Server) | TCP Socket (Pixel Drift) |
| :--- | :--- | :--- |
| **Kết nối** | Đóng mở liên tục (Stateless) | **Duy trì liên tục (Persistent)** |
| **Cơ chế** | Client phải hỏi (Pull) | **Server tự đẩy tin (Push)** |
| **Header** | Cồng kềnh (Cookie, Token...) | **Gọn nhẹ (Raw Data)** |
| **Độ trễ** | Cao (Lag) | **Thấp (Real-time)** |

### Luồng dữ liệu (Data Flow)

```mermaid
sequenceDiagram
    participant Client A
    participant Server
    participant Database
    
    Client A->>Server: Gửi Tọa độ (X, Y)
    Server-->>Client A: Broadcast (Vị trí đối thủ)
    
    Note over Client A, Server: Loop 60 lần/giây
    
    Client A->>Server: Game Over (Gửi điểm)
    Server->>Database: INSERT / UPDATE Score
    Database-->>Server: Success
    Server-->>Client A: Hiển thị bảng điểm
