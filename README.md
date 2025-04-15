# Egitim301 Projesi

Bu proje, .NET Core kullanılarak geliştirilmiş katmanlı mimari yapısına sahip bir eğitim projesidir.

## 🏗️ Proje Yapısı

Proje aşağıdaki katmanlardan oluşmaktadır:

- **Egitim301.PresentationLayer**: Kullanıcı arayüzü katmanı
- **Egitim301.EntityLayer**: Veri modellerinin bulunduğu katman
- **Egitim301.DataAccsessLayer**: Veritabanı işlemlerinin yapıldığı katman
- **Egitim301.BusinnesLayer**: İş mantığının bulunduğu katman
- **Egitim301.EFProject**: Entity Framework projesi
- **Egitim301.EfExampleMiniProject**: Entity Framework örnek mini projesi

## 🚀 Başlangıç

### Gereksinimler

- .NET Core SDK
- Visual Studio 2022 veya üzeri
- SQL Server

### Veritabanı Bağlantı Ayarları

Projede veritabanı bağlantı ayarları aşağıdaki dosyalarda yapılandırılmıştır:

1. **Egitim301.PresentationLayer/App.config**:
```xml
<connectionStrings>
    <add name="KampContext" connectionString="Data Source=.;initial Catalog=EgitimKampi301Db;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

2. **Egitim301.EFProject/App.config**:
```xml
<connectionStrings>
    <add name="EgitimKampiEFTravelDbEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=EgitimKampiEFTravelDb;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
    <add name="Egitim301.EFProject.Properties.Settings.EgitimKampiEFTravelDbConnectionString" connectionString="Data Source=.;Initial Catalog=EgitimKampiEFTravelDb;Integrated Security=True;TrustServerCertificate=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

3. **Egitim301.EfExampleMiniProject/App.config**:
```xml
<connectionStrings>
    <add name="EgitimKampiEFTravelDbEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=EgitimKampiEFTravelDb;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
    <add name="Egitim301.EFProject.Properties.Settings.EgitimKampiEFTravelDbConnectionString" connectionString="Data Source=.;Initial Catalog=EgitimKampiEFTravelDb;Integrated Security=True;TrustServerCertificate=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

Veritabanı bağlantısını değiştirmek için:
1. `Data Source=.` kısmını kendi SQL Server instance'ınızın adı ile değiştirin
2. `initial Catalog` veya `Initial Catalog` değerlerini kendi veritabanı adlarınızla değiştirin
3. Eğer SQL Server Authentication kullanıyorsanız, `Integrated Security=True` yerine kullanıcı adı ve şifre bilgilerinizi ekleyin

### Kurulum

1. Projeyi klonlayın:
```bash
git clone [repo-url]
```

2. Proje dizinine gidin:
```bash
cd Egitim301
```

3. Gerekli NuGet paketlerini yükleyin:
```bash
dotnet restore
```

4. Projeyi çalıştırın:
```bash
dotnet run
```

## 📝 Kullanılan Teknolojiler

- .NET Core
- Entity Framework Core
- SQL Server
- Katmanlı Mimari (N-Tier Architecture)

## 🤝 Katkıda Bulunma

1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Bir Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 📧 İletişim

Proje Sahibi - [@Ferhat Tetik](https://github.com/FerhatTetik)

Proje Linki: [https://github.com/your-username/Egitim301](https://github.com/your-username/Egitim301)
