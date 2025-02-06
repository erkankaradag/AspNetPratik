# ASP.NET Core MVC Projesi

Bu proje, **ASP.NET Core MVC** kullanılarak oluşturulmuş temel bir web uygulamasıdır.

## 🚀 Başlangıç
Bu projeyi çalıştırmak için aşağıdaki adımları takip edebilirsiniz.

### 📌 Gereksinimler
- .NET 6 veya daha yeni bir sürüm
- Visual Studio / VS Code / Rider
- ASP.NET Core SDK

### 🔧 Kurulum ve Çalıştırma
1. **Projeyi klonlayın**
   ```sh
   git clone https://github.com/kullanici/proje-adi.git
   cd proje-adi
   ```
2. **Bağımlılıkları yükleyin**
   ```sh
   dotnet restore
   ```
3. **Projeyi çalıştırın**
   ```sh
   dotnet run
   ```

## 📂 Proje Yapısı
```
📂 ProjeKlasörü
 ┣ 📂 Controllers  # MVC Controller dosyaları
 ┣ 📂 Views        # Razor View dosyaları
 ┣ 📂 Models       # Veri modelleri
 ┣ 📂 wwwroot      # Statik dosyalar (CSS, JS, img)
 ┣ 📜 Program.cs   # Uygulama başlangıç noktası
 ┗ 📜 appsettings.json  # Uygulama ayarları
```

## 🌍 Varsayılan Rota
Uygulama, aşağıdaki varsayılan rotayı kullanır:
```
{controller=Home}/{action=Index}/{id?}
```
Eğer bir URL belirtilmezse **HomeController** içindeki **Index** action'ı çalışır.

## 🛠 Kullanılan Teknolojiler
- **ASP.NET Core 6+**
- **Entity Framework Core** (isteğe bağlı)
- **Razor View Engine**

## 📜 Lisans
Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakabilirsiniz.

---
🚀 **Geliştirme veya destek için katkıda bulunabilirsiniz!**

