using System;

namespace NesneProje
{
    class Program
    {



        enum otomasyonfiyat
        {
            otobus = 250, otogaleri = 400, sinema = 550, eticaret= 1000, istasyon= 450, otopark= 600, surucukursu= 380, muhasebe= 150,
        }
        static void Main(string[] args)
        {
            int GirilenDeger;
            otomasyonfiyat otomasyon = new otomasyonfiyat();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine();

            Console.WriteLine("** Kiralık Otomasyonlar Kategorisi ** Satılık Otomasyonlar Kategorisi  **");
            Console.WriteLine();
            Console.WriteLine("** 1-Otobüs Firması Otomasyonu     **  5- E Ticaret Otomasyonu         **");
            Console.WriteLine();
            Console.WriteLine("** 2-Oto Galeri Otomasyonu         **  6- İstasyon Otomasyonu          **");
            Console.WriteLine();
            Console.WriteLine("** 3-Sinema Otomasyonu             **  7- Otopark  Otomasyonu          **");
            Console.WriteLine();
            Console.WriteLine("** 4-Muhasebe Otomasyonu           **  8- Sürücü Kursu Otomasyonu      **");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemeler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Kullanıcı Girişi");
            Console.WriteLine("3-Ayın Otomasyonu");
            Console.WriteLine("4-Otomasyon Satın Al");
            Console.WriteLine("5-Otomasyonlar hakkında bilgi");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarası :");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine("Otomayon Numarasını Giriniz : ");
                GirilenDeger = Convert.ToInt32(Console.ReadLine());
                switch (GirilenDeger)
                {
                    case 1:
                        otomasyon = otomasyonfiyat.otobus;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 2:
                        otomasyon = otomasyonfiyat.otogaleri;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 3:
                        otomasyon = otomasyonfiyat.sinema;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 4:
                        otomasyon = otomasyonfiyat.muhasebe;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 5:
                        otomasyon = otomasyonfiyat.eticaret;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 6:
                        otomasyon = otomasyonfiyat.istasyon;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 7:
                        otomasyon = otomasyonfiyat.otopark;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;
                    case 8:
                        otomasyon = otomasyonfiyat.surucukursu;

                        Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                        Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                        break;

                    default:
                        Console.WriteLine("Bu isletim sistemi mevcut değil");
                        break;
                }
            }
            if (islem == '2')
            {
                string ka = "admin";
                string sifre = "123";
                string girilenkullaniciadi;
                string girilensifre;

                Console.WriteLine("Kullanıcı adınızı giriniz : ");

                girilenkullaniciadi = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Şifrenizi giriniz : ");
                girilensifre = Convert.ToString(Console.ReadLine());

                if (girilenkullaniciadi==ka && sifre==girilensifre)
                {
                    Console.WriteLine("BAŞARI İLE GİRİŞ YAPILDI !");
                    Console.ReadKey();


                    int GirilenDeger2;
                    otomasyonfiyat otomasyon2 = new otomasyonfiyat();

                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine();

                    Console.WriteLine("** Kiralık Otomasyonlar Kategorisi ** Satılık Otomasyonlar Kategorisi  **");
                    Console.WriteLine();
                    Console.WriteLine("** 1-Otobüs Firması Otomasyonu     **  5- E Ticaret Otomasyonu         **");
                    Console.WriteLine();
                    Console.WriteLine("** 2-Oto Galeri Otomasyonu         **  6- İstasyon Otomasyonu          **");
                    Console.WriteLine();
                    Console.WriteLine("** 3-Sinema Otomasyonu             **  7- Otopark  Otomasyonu          **");
                    Console.WriteLine();
                    Console.WriteLine("** 4-Muhasebe Otomasyonu           **  8- Sürücü Kursu Otomasyonu      **");
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine();

                    Console.WriteLine("***** İşlemeler Menüsü *****");
                    Console.WriteLine();
                    Console.WriteLine("1-Fiyat Sorgulama");
                    Console.WriteLine("2-Kullanıcı Girişi");
                    Console.WriteLine("3-Ayın Otomasyonu");
                    Console.WriteLine("4-Otomasyon Satın Al");
                    Console.WriteLine("5-Otomasyonlar hakkında bilgi");
                    Console.WriteLine();
                    Console.WriteLine("Yapmak istediğiniz işlemin numarası :");
                    char islem2;
                    islem = Convert.ToChar(Console.ReadLine());
                    if (islem == '1')
                    {
                        Console.WriteLine("Otomayon Numarasını Giriniz : ");
                        GirilenDeger = Convert.ToInt32(Console.ReadLine());
                        switch (GirilenDeger)
                        {
                            case 1:
                                otomasyon = otomasyonfiyat.otobus;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 2:
                                otomasyon = otomasyonfiyat.otogaleri;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 3:
                                otomasyon = otomasyonfiyat.sinema;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 4:
                                otomasyon = otomasyonfiyat.muhasebe;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 5:
                                otomasyon = otomasyonfiyat.eticaret;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 6:
                                otomasyon = otomasyonfiyat.istasyon;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 7:
                                otomasyon = otomasyonfiyat.otopark;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;
                            case 8:
                                otomasyon = otomasyonfiyat.surucukursu;

                                Console.WriteLine("Otomasyon Adı = " + otomasyon.ToString("G"));
                                Console.WriteLine("Otomasyon Fiyatı = " + otomasyon.ToString("D"));
                                break;

                            default:
                                Console.WriteLine("Bu isletim sistemi mevcut değil");
                                break;
                        }
                    }
                    if (islem == '2')
                    {
                       

                    }
                    if (islem == '3')
                    {
                        Console.WriteLine();
                        Console.WriteLine("işlem : Ayın Otomasyonu ---> OTOPARK OTOMASYONU");
                    }

                    if (islem == '4')
                    {
                        Console.WriteLine();
                        Console.WriteLine("işlem : Otomasyon Satın Al --> Şirket ile iletişime geçiniz !");
                    }
                    if (islem == '5')
                    {
                        Otobilgi();
                    }

                    static void Otobilgi2()
                    {
                        Console.WriteLine();
                        Console.WriteLine("** 1-Otobüs Firması Otomasyonu     **  5- E Ticaret Otomasyonu         **");
                        Console.WriteLine();
                        Console.WriteLine("** 2-Oto Galeri Otomasyonu         **  6- İstasyon Otomasyonu          **");
                        Console.WriteLine();
                        Console.WriteLine("** 3-Sinema Otomasyonu             **  7- Otopark  Otomasyonu          **");
                        Console.WriteLine();
                        Console.WriteLine("** 4-Muhasebe Otomasyonu           **  8- Sürücü Kursu Otomasyonu      **");
                        Console.WriteLine("*************************************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Hangi işlem hakkında bilgi almak istiyorsunuz ?");
                        char otobilgi;
                        otobilgi = Convert.ToChar(Console.ReadLine());
                        if (otobilgi == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Otobüs Firması Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Web sitesi üzerinden veya Mobil uygulama(IOS, Android) ile satış yapabilirsiniz.");
                            Console.WriteLine();
                            Console.WriteLine("Kullanıcı yönetimi ve yetkilendirme ile tüm site içerikleri yönetilebilen CMS sağlar.");
                            Console.WriteLine();
                            Console.WriteLine("Eklediğiniz bütün şehirleri birbiriyle otomatik eşleşir ve bu şekilde Şehir-Şehir sayfaları oluşturabilirsiniz.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '2')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Oto Galeri Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("İşletme içi cari hesap takiplerinin yapılabilmesi.");
                            Console.WriteLine();
                            Console.WriteLine("Araç alış satış masraf sonucunda elde edilen net kazanç.");
                            Console.WriteLine();
                            Console.WriteLine("Araç genel bilgileri, araçlara fotoğraf tanımlama, araç alış satış bilgileri tanımlamaları.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Sinema Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Sinema Biletleme Yazılımı parametriktir. Kişi tiplerine göre bilet fiyatları, işletmenin ücret politikalarına göre tanımlanabilmektedir.");
                            Console.WriteLine();
                            Console.WriteLine("Satış personeli yetkisi dahilinde erişebildiği satış ekranları üzerinden film, seans, salon, koltuk tipi gibi seçimler yaparak bilet satışı gerçekleştirebilmektedir.");
                            Console.WriteLine();
                            Console.WriteLine("Satışı yapılan biletin yazıcıdan çıktısı alınabilmektedir.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '4')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Muhasebe Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Stok malzeme hareketleri ve aktif stok takibi.");
                            Console.WriteLine();
                            Console.WriteLine("Fatura ve fatura kesilmeyen Hasta / Kurum Takibi.");
                            Console.WriteLine();
                            Console.WriteLine("Mevzuata Uygun Resmi Muhasebe İşlemleri.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '5')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** E Ticaret Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Müşteri hizmetleri yönetimi.");
                            Console.WriteLine();
                            Console.WriteLine("Belirlenecek pazarlama stratejileri (hedef pazar belirlemesi).");
                            Console.WriteLine();
                            Console.WriteLine("Muhasebe ve finans yönetimi.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '6')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** İstasyon Otomasyonu Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Sahanızdaki akaryakıt pompalarından yapılan satışı anlık olarak takip edebilirsiniz.");
                            Console.WriteLine();
                            Console.WriteLine("Tanklarınızın seviyesini anlık olarak bilirsiniz.");
                            Console.WriteLine();
                            Console.WriteLine("Pompa ve yazarkasa toplamlarınızı anlık olarak kontrol edersiniz.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '7')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Otopark Otomasyonu Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Araç altı görüntüleme Sistemleri.");
                            Console.WriteLine();
                            Console.WriteLine("Otoparkta yönlendirilen aracı takip etme özelliği.");
                            Console.WriteLine();
                            Console.WriteLine("Plaka Tanımlama Sistemleri.");
                            Console.WriteLine();
                        }
                        if (otobilgi == '8')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("***** Sürücü Kursu Otomasyonu Hakkında Bilgiler *****");
                            Console.WriteLine();
                            Console.WriteLine("Sınırsız Kullanıcı Oluşturma.");
                            Console.WriteLine();
                            Console.WriteLine("Gelişmiş Yedekleme Bölümü İle Haftanın 7 Gününü Ayrı Ayrı Ayarlayarak Farklı Saat Dilimlerinde Yedek Alma İmkânı. (Program Kapalı Olsa Dahi Yedek Alır)");
                            Console.WriteLine();
                            Console.WriteLine("Sms ve Mail Bölümleri ile Kursiyerlere Her An Her Yerden İletişim Halinde Olabilirsiniz.");
                            Console.WriteLine();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış !");
                    Console.ReadKey();
                }

            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("işlem : Ayın Otomasyonu ---> OTOPARK OTOMASYONU");
            }

            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("işlem : Otomasyon Satın Al --> Şirket ile iletişime geçiniz !");
            }
            if (islem == '5')
            {
                Otobilgi();
            }

            static void Otobilgi()
            {
                Console.WriteLine();
                Console.WriteLine("** 1-Otobüs Firması Otomasyonu     **  5- E Ticaret Otomasyonu         **");
                Console.WriteLine();
                Console.WriteLine("** 2-Oto Galeri Otomasyonu         **  6- İstasyon Otomasyonu          **");
                Console.WriteLine();
                Console.WriteLine("** 3-Sinema Otomasyonu             **  7- Otopark  Otomasyonu          **");
                Console.WriteLine();
                Console.WriteLine("** 4-Muhasebe Otomasyonu           **  8- Sürücü Kursu Otomasyonu      **");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Hangi işlem hakkında bilgi almak istiyorsunuz ?");
                char otobilgi;
                otobilgi = Convert.ToChar(Console.ReadLine());
                if (otobilgi == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Otobüs Firması Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Web sitesi üzerinden veya Mobil uygulama(IOS, Android) ile satış yapabilirsiniz.");
                    Console.WriteLine();
                    Console.WriteLine("Kullanıcı yönetimi ve yetkilendirme ile tüm site içerikleri yönetilebilen CMS sağlar.");
                    Console.WriteLine();
                    Console.WriteLine("Eklediğiniz bütün şehirleri birbiriyle otomatik eşleşir ve bu şekilde Şehir-Şehir sayfaları oluşturabilirsiniz.");
                    Console.WriteLine();
                }
                if (otobilgi == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Oto Galeri Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("İşletme içi cari hesap takiplerinin yapılabilmesi.");
                    Console.WriteLine();
                    Console.WriteLine("Araç alış satış masraf sonucunda elde edilen net kazanç.");
                    Console.WriteLine();
                    Console.WriteLine("Araç genel bilgileri, araçlara fotoğraf tanımlama, araç alış satış bilgileri tanımlamaları.");
                    Console.WriteLine();
                }
                if (otobilgi == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Sinema Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Sinema Biletleme Yazılımı parametriktir. Kişi tiplerine göre bilet fiyatları, işletmenin ücret politikalarına göre tanımlanabilmektedir.");
                    Console.WriteLine();
                    Console.WriteLine("Satış personeli yetkisi dahilinde erişebildiği satış ekranları üzerinden film, seans, salon, koltuk tipi gibi seçimler yaparak bilet satışı gerçekleştirebilmektedir.");
                    Console.WriteLine();
                    Console.WriteLine("Satışı yapılan biletin yazıcıdan çıktısı alınabilmektedir.");
                    Console.WriteLine();
                }
                if (otobilgi == '4')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Muhasebe Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Stok malzeme hareketleri ve aktif stok takibi.");
                    Console.WriteLine();
                    Console.WriteLine("Fatura ve fatura kesilmeyen Hasta / Kurum Takibi.");
                    Console.WriteLine();
                    Console.WriteLine("Mevzuata Uygun Resmi Muhasebe İşlemleri.");
                    Console.WriteLine();
                }
                if (otobilgi == '5')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** E Ticaret Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Müşteri hizmetleri yönetimi.");
                    Console.WriteLine();
                    Console.WriteLine("Belirlenecek pazarlama stratejileri (hedef pazar belirlemesi).");
                    Console.WriteLine();
                    Console.WriteLine("Muhasebe ve finans yönetimi.");
                    Console.WriteLine();
                }
                if (otobilgi == '6')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** İstasyon Otomasyonu Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Sahanızdaki akaryakıt pompalarından yapılan satışı anlık olarak takip edebilirsiniz.");
                    Console.WriteLine();
                    Console.WriteLine("Tanklarınızın seviyesini anlık olarak bilirsiniz.");
                    Console.WriteLine();
                    Console.WriteLine("Pompa ve yazarkasa toplamlarınızı anlık olarak kontrol edersiniz.");
                    Console.WriteLine();
                }
                if (otobilgi == '7')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Otopark Otomasyonu Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Araç altı görüntüleme Sistemleri.");
                    Console.WriteLine();
                    Console.WriteLine("Otoparkta yönlendirilen aracı takip etme özelliği.");
                    Console.WriteLine();
                    Console.WriteLine("Plaka Tanımlama Sistemleri.");
                    Console.WriteLine();
                }
                if (otobilgi == '8')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("***** Sürücü Kursu Otomasyonu Hakkında Bilgiler *****");
                    Console.WriteLine();
                    Console.WriteLine("Sınırsız Kullanıcı Oluşturma.");
                    Console.WriteLine();
                    Console.WriteLine("Gelişmiş Yedekleme Bölümü İle Haftanın 7 Gününü Ayrı Ayrı Ayarlayarak Farklı Saat Dilimlerinde Yedek Alma İmkânı. (Program Kapalı Olsa Dahi Yedek Alır)");
                    Console.WriteLine();
                    Console.WriteLine("Sms ve Mail Bölümleri ile Kursiyerlere Her An Her Yerden İletişim Halinde Olabilirsiniz.");
                    Console.WriteLine();
                }
            }

            


            Console.Read();
        }
    }
}
