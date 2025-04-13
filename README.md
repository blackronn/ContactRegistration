# 📇 Kişi Yönetim Sistemi | Contact Management System (WinForms C#)

Bu proje, C# ve Windows Forms kullanılarak geliştirilen bir **Kişi (Contact) Yönetim Sistemi**'dir. Kullanıcılar kişileri ekleyebilir, düzenleyebilir, silebilir ve veritabanında arama yapabilir.

This project is a **Contact Management System** developed with C# and Windows Forms. Users can add, edit, delete, and search contacts in the database.

---

## 📁 Proje İçeriği | Project Features

🇹🇷 Türkçe:
- SQL Server veritabanı ile kişi yönetimi
- Yeni kişi ekleme
- Kayıt düzenleme, silme
- Ad/Soyad ile arama
- Basit ve kullanıcı dostu arayüz

🇬🇧 English:
- Contact management using SQL Server database
- Add new contacts
- Edit and delete records
- Search by name/surname
- Simple and user-friendly interface

---
Kurulum ve Çalıştırma | Setup and Run
Repoyu klonlayın veya indirin
Clone or download the repository:

git clone https://github.com/kullaniciAdi/contact-management.git


SQL Server'da yeni bir veritabanı oluşturun
Create a new database in SQL Server and run the ContactDb.sql script.

Form1.cs içinde bağlantı cümlesini güncelleyin
Update the connection string in Form1.cs:
SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ContactDB;Integrated Security=True");
