using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Name = "Elma";
            urun1.Price = 10;
            urun1.Description = "amasya elması";
            
            Urun urun2 = new Urun();    
            urun2.Id = 2;
            urun2.Name = "Karpuz";
            urun2.Price = 20;
            urun2.Description = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach(Urun product in urunler)
            {
                Console.WriteLine("ID: " + product.Id + "--" +" ISIM : " + product.Name + "--" + "AÇIKLAMA : " + product.Description + "--" + "FİYAT : " + product.Price);
            }
            Console.WriteLine("------------metodlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            
        }
    }
}