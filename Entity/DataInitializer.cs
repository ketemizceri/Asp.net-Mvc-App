using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>()

            {

                new Category(){Name = "Kamera", Description = "Kamera ürünleri"},
                new Category(){Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category(){Name = "Televizyon", Description = "Televizyon ürünleri"},
                new Category(){Name = "Telefon", Description = "Telefon ürünleri"},
                new Category(){Name = "Beyaz Eşya", Description = "Beyaz Eşya ürünleri"},

            };


            foreach (var kategori in kategoriler)
            
            {
            
               context.Categories.Add(kategori);    
            
            }
            context.SaveChanges();

            var urunler = new List<Product>()


            {

                new Product(){Name = "Canon Eos 2000D 18-55mm DC DSLR Fotoğraf Makinesi", Description = "24,1 Megapiksel EOS 2000D ile düşük ışık koşullarında bile zahmetsizce detaylı DSLR kalitesinde fotoğraflar ve sinematik Full HD filmler çekin. Wi-Fi*, NFC** ve Canon Connect uygulaması ile anında uzaktan çekim yapın ve paylaşın.", Price =25999, Stock =500, IsApproved = true, CategoryId = 1,IsHome=true, Image = "1.jpg"},
                new Product(){Name = "Nikon Z50 DX 16-50mm VR Aynasız APS-C Fotoğraf Makinesi", Description = "Mükemmel kavrama sağlayan aynasız fotoğraf makinesi ile karşınıza çıkan tüm güzellikleri yakalayın. Cüretkar düşük ışıklı renkler. Beklenmedik bir açıdan bildik bir poz. Güneş tepedeyken gölge oyunları oynayın. Hafif ve dinamik Nikon Z 50 aynasız fotoğraf makinesi, pırıl pırıl fotoğraflar ve çarpıcı filmler sunar. Hızlı, güçlü ve kullanımı kolaydır.", Price =44999, Stock =300, IsApproved = true, CategoryId = 1,IsHome=true,Image = "2.jpg"},
                new Product(){Name = "Fujifilm X100VI Siyah Fotoğraf Makinesi", Description = "Fujifilm'in X100 Serisi dijital fotoğraf makineleri ile fotoğrafçılığın keyfini en saf haliyle çıkarın. Modelden modele aktarılan zamansız bir tasarım kullanan çarpıcı 6. nesil X100VI, her yaratıcı anda tam hayalinizdeki kareleri üretirken unutulmaz bir deneyim sunar.", Price =62999, Stock =200, IsApproved = false, CategoryId = 1,IsHome=true,Image = "3.jpg"},
                new Product(){Name = "Sony Alpha A6700 18-135mm Aynasız APS-C Fotoğraf Makinesi", Description = "α6700, kompakt bir APS-C fotoğraf makinesi gövdesinde en son yapay zeka teknolojisini Sony’nin olağanüstü α serisi görüntü kalitesiyle birleştirir. Gelişmiş nesne algılaması, fotoğraf ve videoya yönelik en son teknoloji ve E mount lens uyumluluğu sunan hafif α6700 her zaman her yerde yaratıcı maceralar içindir.", Price =77899, Stock =2, IsApproved = true, CategoryId = 1,IsHome=true,Image = "4.jpg"},
                new Product(){Name = "Nikon Z 5 24-200mm f/4 Aynasız Full Frame Fotoğraf Makinesi", Description = "Tam çerçeveli fotoğrafçılığın büyülü dünyasına hoş geldiniz. Sağlam, hafif ve taşıması kolay olan Nikon Z 5 aynasız fotoğraf makinesi, kompakt tam çerçeveli objektiflerin geniş dünyasıyla uyumludur. Durağan görüntü veya film çekerken heyecan verici yeni görüntü kalitesi seviyelerine ulaşın.", Price =94999, Stock =50, IsApproved = false, CategoryId = 1,Image = "5.jpg"},


                new Product(){Name = "Hp Victus 15-fa1084nt 13.Nesil Core i7 13620H-RTX4060 8Gb-16Gb-512Gb-15.6inc-W11", Description = "En büyük oyunlara ve en iyi oyunculara ayak uydur. Intel® Core İşlemci ve güçlü grafik kartıyla desteklenen küçük ama kuvvetli kasada tasarlanmıştır.", Price =46999, Stock =1200, IsApproved = true, CategoryId = 2, Image = "6.jpg"},
                new Product(){Name = "Msi Cyborg 15 13.Nesil Core i5 13420H-RTX4060 8GB-16GB-512Gb Ssd-15.6inc-W11", Description = "Evrimin bir sonraki adımı atıldı: Oyun dünyasına Cyberpunk tarzınızla dalın; bilim-kurgu modasını esnetin; rakiplerinizi yepyeni bir donanımla şaşırtın. Futuristik mekanize dış tasarımı ile Cyborg 15 çığır açan, avangart bir Gaming laptop olarak doğdu", Price =40999, Stock =900, IsApproved = true, CategoryId = 2,IsHome=true,Image = "7.jpg"},
                new Product(){Name = "Monster Abra A5 V22.1.5 15,6inch Oyun Bilgisayarı", Description = "Full HD ekranla oyunlarda her detayı net bir şekilde görün. 144Hz yenileme hızı ve IPS mat panel sayesinde, ultra akıcı görüntülerle gerçekçi ve canlı bir oyun deneyimi sizi bekliyor.", Price =68599, Stock =100, IsApproved = false, CategoryId = 2,IsHome=true,Image = "8.jpg"},
                new Product(){Name = "ASUS ROG Flow Z13 (2025)(GZ302EA-RU103-Gaming) AMD Ryzen™ AI İşlemci 32GB RAM 1TB SSD Tablet Gaming Laptop", Description = "Flow Z13'ün taşınabilir 13 inç CNC alüminyum kasası, 70Wh pili ve bir dizi giriş stili desteği ile inanılmaz taşınabilirliği sayesinde istediğiniz gibi oynayın.", Price =97999, Stock =30, IsApproved = true, CategoryId = 2,Image = "9.jpg"},
                new Product(){Name = "Acer Nitro V15 ANV15-41 AMD R7 7735HS 16GB 512GB SSD RTX4060-8GB Dos 15.6 FHD 165Hz Notebook NH.QSFEY.001", Description = "Acer Nitro V15 notebook, güçlü AMD Ryzen 7 işlemcisi ile kullanıcılara üst düzey bir performans sunar. Bu performans, 16GB bellekle birleştiğinde, multimedya içerikleri oynatma veya karmaşık hesaplamalar gerçekleştirmede hızlı ve akıcı bir deneyim sağlar.", Price =35279, Stock =1500, IsApproved = true, CategoryId = 2,Image = "10.jpg"},


                new Product(){Name = "LG 65QNED86T 65 inç 165 cm 4K Smart TV AI Sihirli Kumanda HDR10 webOS24,Uydu Alıcılı", Description = "Devasa LG QNED ile canlı renkler ve olağanüstü netlik. Yeni işlemcimiz ve karartma bölgelerimiz, içerikleri mükemmelleştirerek her pikselin son derece net kalmasını sağlar.", Price =49999, Stock =1200, IsApproved = true, CategoryId = 3,Image = "11.jpg"},
                new Product(){Name = "SAMSUNG QE 65QN70F 65inch 163 cm 4K UHD Smart Neo QLED TV,Uydu Alıcılı", Description = "En sevdiğiniz içerikleri daha canlı detaylarla izleyin. Yapay zeka işlemcimiz, net ve kusursuz görüntü kalitesini korurken 20 nöral yapay zeka ağından güç alarak içerikleri 4K çözünürlüğe yükseltebilir.", Price =64059, Stock =900, IsApproved = true, CategoryId = 3,Image = "12.jpg"},
                new Product(){Name = "TCL 75C655GTVPRO 75inch 189 cm 4K UHD Google Smart Qled TV,Uydu Alıcılı", Description = "Kendinizi, her tonun eşsiz bir parlaklık ve derinlikle hayat bulduğu bir renk kaleydoskopuna kaptırın.", Price =75149, Stock =100, IsApproved = false, CategoryId = 3,IsHome=true,Image = "13.jpg"},
                new Product(){Name = "Philips Ambilight TV 65OLED810 4K UHD OLED 164cm 65 inch Smart Dolby Vision&Atmos Go", Description = "Bu sofistike OLED Ambilight TV, güzelliğin gözlerinizin önüne serilmesini sağlar. Minimalist tasarım, gerçekçi görüntü ve şaşırtıcı derecede sinematik ses gibi özellikleriyle büyüleneceksiniz. Ambilight'ın olağanüstü parlaklığı, her şeyin daha büyük ve daha etkileyici görünmesini sağlar!", Price =89999, Stock =150, IsApproved = true, CategoryId = 3,IsHome=true,Image = "14.jpg"},
                new Product(){Name = "GRUNDIG 65GHO9900 65inch 164 cm 4K UHD Google Smart OLED TV,Uydu Alıcılı", Description = "Grundig OLED televizyonların kendinden aydınlatmalı pikselleri, mükemmel siyahı ve maksimum parlaklığı ekrana getiriyor. OLED teknolojisi, gerçeğe en yakın görüntüyü sunuyor. Renkler her zamankinden daha parlak ve daha doğal!", Price =64999, Stock =1400, IsApproved = true, CategoryId = 3,Image = "15.jpg"},


                new Product(){Name = "iPhone 16 Pro Max 256 GB Akıllı Telefon Natural Titanium", Description = "iPhone 16 Pro Max Dayanıklı ve Titanyum Tasarım, yepyeni kamera denetimi. A18 Pro Çip ile Apple Intelligence için tasarlanmış ilk Iphone.", Price =97999, Stock =1200, IsApproved = true, CategoryId = 4,Image = "16.jpg"},
                new Product(){Name = "Samsung Galaxy S25 Ultra 12/512 Gb Akıllı Telefon Titanyum Gri", Description = "Bas, konuş. İşte bu kadar kolay, uygulamalar arasında geçiş yapmanıza gerek kalmadan işlemlerinizi kolayca halledin. Yan düğmeye uzun basın ve günlük dilde konuşarak Google Gemini’a ne istediğinizi açıklayın, gerisini ona bırakın", Price =79999, Stock =1400, IsApproved = true, CategoryId = 4,Image = "17.jpg"},
                new Product(){Name = "Honor Magic V2 16+512 GB Akıllı Telefon Siyah Cam", Description = "Katlandığında 9,9 mm kalınlık, açıldığında 4,7 mm kalınlık, 231 g ağırlık. Tıpkı sıradan telefonunuzu tuttuğunuz gibi daha ince ve daha hafif. Yeni HONOR Süper Hafif Titanyum Menteşe, güvenilirliği açısından SGS sertifikasına sahiptir. Bu tasarım ve materyal, süper hafif olma konusunda daha fazla olanak sağlar.", Price =69999, Stock =100, IsApproved = false, CategoryId = 4,IsHome=true,Image = "18.jpg"},
                new Product(){Name = "Samsung Galaxy S24 Ultra 12/256 Gb Akılı Telefon Titanyum Siyah", Description = "Samsung’un yeni amiral gemisi Galaxy S24 Ultra eşsiz özellikleriyle satışa çıkıyor! Samsung Galaxy S24 Ultra fiyatı, sınırları aşan güç ve estetik görünümüyle kullanıcılara üstün performans deneyimi sunacak. Galaxy S24 Ultra ile yapay zeka çağı başlıyor!", Price =55999, Stock =1500, IsApproved = true, CategoryId = 4,IsHome=true,Image = "19.jpg"},
                new Product(){Name = "Xiaomi 14T Pro 12 + 512 Gb Akıllı Telefon Siyah", Description = "Işığa hükmet, geceyi yakala. Leica ile ortak geliştirilen ve düşük ışık performansı iyileştirilen Xiaomi 14T Serisi, kullanıcıların ışığı ustalıkla kullanmasını sağlıyor. Yeni bir mobil görüntüleme dünyasının kilidini açın ve yaratıcı ifadenizi dilediğiniz zaman, dilediğiniz yerde sergileyin.", Price =42999, Stock =1800, IsApproved = true, CategoryId = 4,Image = "20.jpg"}





            };




            foreach (var urun in urunler)
            {

                context.Products.Add(urun); 

            }

            context.SaveChanges();






            base.Seed(context);
        }
    }
}