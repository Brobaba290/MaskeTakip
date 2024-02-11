//Degiskenler();

using Business.Concrete;
using Entities.Concrete;


public class Program
{
    private static void Main(string[] args)
    {
        Vatandas vatandas1 = new Vatandas();

        SelamVer();

        int sonuc = Topla(6, 58);


        //Diziler / Arrays

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kaan";
        string ogrenci3 = "Kerem";

        //Console.WriteLine(ogrenci1);
        //Console.WriteLine(ogrenci2);
        //Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kaan";
        ogrenciler[2] = "Kerem";

        ogrenciler = new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);


        Person person1 = new Person();
        person1.FirstName = "Kaan";
        person1.LastName = "DEMİRTAŞ";
        person1.DateOfBirthYear = 2002;
        person1.NationalIdentity = 12345646512312;

        Person person2 = new Person();
        person2.FirstName = "Murat";

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        //MyList
        List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
        yeniSehirler1.Add("Adana 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);



        Console.ReadLine();

        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + " " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;

        }

        static void Degiskenler()
        {
            Console.WriteLine("Hello World");

            string mesaj = "Merhaba";
            double tutar = 10000; //db'den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Kaan";
            string soyad = "Demirtaş";
            int dogumYili = 2002;
            long tcNo = 12345678910;


            Console.WriteLine(mesaj);
            Console.WriteLine(tutar);
        }
    }
}

//pascal casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

    
}