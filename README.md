# OBiletCaseStudy

Bu proje, obilet.com API'si ile entegre olan ve kullanıcıların yolculuk araması yapmasını sağlayan bir ASP.NET Core MVC uygulamasıdır. Kullanıcılar kalkış, varış ve kalkış tarihi bilgilerini girerek otobüs seferlerini arayabilirler.

## Gereksinimler

- .NET 8 SDK
- Visual Studio 2022 veya üstü
- Redis
- Docker

## Kurulum

### Projeyi Klonlama

Öncelikle, projeyi yerel makinenize klonlayın:


git clone https://github.com/oguzhanyikilmaz/OBiletCaseStudy.git
cd OBiletCaseStudy

-Bağımlılıkları Yükleme
Proje klasöründe, gerekli bağımlılıkları yüklemek için şu komutu çalıştırın:
dotnet restore

-Redis kurulumu
Redis kullanabilmek için Docker kurulumu yapıp proje içerisindeki docker-compose.yml dosyasını kullanabilirsiniz ya da bilgisayarınıza direkt Redis kurulumu yapabilirsiniz.
Redis Connection bilgisini OBilet.Case.Study.Web katmanında appsettings.json dosyasında güncelleyebilirsiniz.

-Projeyi Çalıştırma
Projeyi çalıştırmak için şu komutu kullanabilirsiniz:
dotnet run
Alternatif olarak, Visual Studio'da projeyi açıp F5 tuşuna basarak projeyi başlatabilirsiniz.

-Proje Yapısı
Controllers
HomeController.cs: Ana sayfa ve yolculuk arama işlemleri için kullanılan controller.
Models
JourneySearchViewModel.cs: Kullanıcının yolculuk araması yaparken girdiği bilgileri içeren ViewModel.
JourneyIndexViewModel.cs: Arama sonuçlarını içeren ViewModel.
Location.cs: Otobüs kalkış ve varış noktalarını temsil eden model.
Journey.cs: Otobüs yolculuk bilgilerini temsil eden model.

-Services
	-Business Layer
		IAuthService OBilet API Client için Auth bilgilerini çeker.
		IBusService OBilet API isteği atar ve otobüsle ilgili bilgileri getirir.
		IRedisService Redis ile ilgili işlemleri yapar.   
	-OBilet API Client
		IOBiletService OBilet API bağlanarak ilgili işlemler için methodları tetikler. API Bağlantısı için RestSharp kullanılmıştır.

-Views
Index.cshtml: Ana sayfa ve yolculuk arama formu.
JourneyIndex.cshtml: Yolculuk arama sonuçlarını gösteren sayfa.

-Kullanım
Projeyi çalıştırdıktan sonra tarayıcınızda https://localhost:7059 adresine gidin.
Ana sayfada kalkış, varış ve kalkış tarihi bilgilerini girerek "Bilet Bul" butonuna tıklayın.
Arama sonuçları, yolculuk bilgilerini içeren bir tablo şeklinde görüntülenecektir.

-Katkıda Bulunma
Katkıda bulunmak için lütfen bir fork oluşturun ve ardından bir pull request gönderin. Her türlü katkı ve geri bildirim değerlidir.

-Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakabilirsiniz.

-İletişim
Herhangi bir sorunuz veya geri bildiriminiz varsa, lütfen oguzhanyklmz27@gmail.com adresinden benimle iletişime geçin.
