# 🛒 Market Automation System (Market / Stok Yönetim Otomasyonu)

Bu proje, **Katmanlı Mimari (N-Tier Architecture)** ve **Entity Framework Code First** yaklaşımı kullanılarak C# WinForms ortamında geliştirilmiş bir masaüstü stok ve kategori yönetim sistemidir.

Proje, yazılım mimarisi standartlarına uygun olarak sorumlulukların ayrılması (Separation of Concerns) prensibiyle 4 ana katman halinde tasarlanmıştır.

---

## 🏗️ Proje Mimarısı (Katmanlar)

Proje aşağıdaki 4 temel katmandan oluşmaktadır:

* 📦 **`Market.EntityLayer`**: Veritabanı tablolarını ve aralarındaki ilişkileri (One-to-Many) temsil eden POCO sınıflarını (`Category`, `Product`) içerir.
* 🗄️ **`Market.DataAccessLayer`**: `DbContext` yapılandırmasını (`MarketContext`), `DbSet` tanımlamalarını ve veritabanı bağlantı ayarlarını barındırır.
* ⚙️ **`Market.BusinessLayer`**: İş kurallarını (Validation Rules), doğrulama kontrollerini ve CRUD operasyonlarının mantıksal süreçlerini yöneten `Manager` sınıflarını (`CategoryManager`, `ProductManager`) barındırır.
* 💻 **`Market.FormsUI`**: Kullanıcının sistemle etkileşime girdiği Windows Forms arayüz katmanıdır.

---

## ✨ Öne Çıkan Özellikler

- **Kategori Yönetimi:** Yeni kategori ekleme ve mevcut kategorileri listeleme.
- **Ürün Yönetimi:** Ürün ekleme, silme, güncelleme ve listeleme (Full CRUD).
- **İlişkisel Veritabanı Mantığı:** Ürünler ile Kategoriler arasında bire-çok (One-to-Many) ilişki kurulumu.
- **Dinamik Veri Bağlama (Data Binding):** ComboBox üzerinden seçilen kategoriye göre ürün ilişkilendirmesi.
- **İş Kuralları (Business Rules):** 
  - Fiyatı 0'dan küçük veya stoku eksi olan ürünlerin eklenmesinin engellenmesi.
  - İsmi boş geçilen kategorilerin kaydedilmemesi.
- **Code First Desteği:** Veritabanının (`MarketDB`) C# sınıfları üzerinden otomatik oluşturulması.

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler

* **Dil:** C#
* **Platform:** .NET Framework (Windows Forms)
* **ORM:** Entity Framework 6 (Code First)
* **Veritabanı:** Microsoft SQL Server
* **Mimari:** N-Tier (Katmanlı) Mimari

---

## 🚀 Projenin Yerel Kurulumu

1. Bu depoyu klonlayın:
   ```bash
   git clone [https://github.com/HakanSahinn/MarketAutomation1.git](https://github.com/HakanSahinn/MarketAutomation1.git)
