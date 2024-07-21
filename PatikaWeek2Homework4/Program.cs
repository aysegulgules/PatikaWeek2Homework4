using System;
Boolean repeat;

do
{ 
repeat = true;
Boolean wrongHoliday;

Dictionary<string, decimal> locationsHoliday = new Dictionary<string, decimal>
{
    { "BODRUM",4000 },
    { "MARMARİS",3000 },
    { "ÇEŞME",5000 }
};

//Lokasyon bilgisi alınıyor...... 

Console.WriteLine("-------------Tatil lokasyonları-----------");

string location;
do
{
    wrongHoliday = false;
    Console.WriteLine("1-Bodrum(Paket başlangıç fiyatı 4000 TL) ");
    Console.WriteLine("2-Marmaris(Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("3-Çeşme(Paket başlangıç fiyatı 5000 TL)");
    Console.WriteLine("Gitmek istediğiniz lokasyonu seçiniz...: ");
    location = (Console.ReadLine()).ToUpper();
       
        if(!locationsHoliday.ContainsKey(location))
        {        
            wrongHoliday = true;
            Console.WriteLine("\n Giriş hatalı, lütfen tekrar deneyiniz!\n");        
        }
    

} while (wrongHoliday);



//Tatil yapacak kişi sayısı belirleniyor.....

int personsHoliday = 0;
do
{ 
    wrongHoliday= false;
    Console.WriteLine("\nKaç kişi için tatil planlamak istiyorsunuz? ");
    string persons=Console.ReadLine();


    if (int.TryParse(persons, out personsHoliday))
    {
        if(personsHoliday <1)
        {
            Console.WriteLine("\n Kişi sayısını 1'den küçük bir sayı girdiniz, lütfen tekrar deneyiniz!..");
            wrongHoliday = true;
        }
    }
    else
    {
        wrongHoliday = true;
        Console.WriteLine("\n Bir sayı girmelisiniz, lütfen tekrar deneyiniz!..");
    }

}while (wrongHoliday);



//Girilen bilgilere göre özet geçiliyor......

Console.WriteLine($"\n{location} için tatil planlıyorsunuz. Paket başlangıç fiyatı: {locationsHoliday[location]} TL. {personsHoliday} kişi ile " +
    $"tatil planlamaktasınız.\n ");



//Seyahat türü belirleniyor........
int travelPrice = 0;
do
{
    wrongHoliday = false;
    Console.WriteLine("\n Tatile nasıl seyahat etmek istersiniz?");
    Console.WriteLine("1 - Kara yolu(Kişi başı ulaşım tutarı gidiş - dönüş 1500 TL)");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1-2).:");
    string travel = Console.ReadLine();
    if (travel=="1" )
    {
        travelPrice = 1500;

    }else if(travel == "2")
    {
        travelPrice = 4000;
    }
    else
    {
        wrongHoliday = true;
        Console.WriteLine("\nHata oluştu, seçiminizi 1 veya 2 şeklinde giriniz!\n");
    }

} while (wrongHoliday);



//Toplam tutar belirleniyor......
decimal sumPrice = (locationsHoliday[location] + travelPrice) * personsHoliday;  
Console.Write($"\n\nÖdemeniz gereken toplam fiyat..:{sumPrice}\n");



// Kullanıcıya başka bir tatil planlamak isteyip istemediği soruluyor......
    do
    {
        wrongHoliday = false;
        Console.WriteLine("\nBaşka bir tatil planlamak istiyor musunuz?(EVET/HAYIR)");
        string continueHoliday = (Console.ReadLine()).ToUpper();

        switch (continueHoliday)
        {
            case "EVET":
                Console.WriteLine("\n-------------------------------------------");
                break;
            case "HAYIR":
                repeat = false;
                Console.WriteLine("\nİyi günler dileriz!");
                break;
            default :
                Console.WriteLine("\nHatalı giriş, EVET veya HAYIR şeklinde giriş yapınız!..");
                wrongHoliday = true;
                break;

        }

     
    } while (wrongHoliday);


} while (repeat) ;