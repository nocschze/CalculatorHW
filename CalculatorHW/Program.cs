using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double birinciSayi;
            double ikinciSayi;
            string islem;
            double sonuc;

            Console.WriteLine("Merhaba, FuTu'nun hesap makinesindesiniz! Devam etmek için enter'a basınız!");
            Console.ReadLine();

            Console.Write("Lütfen hesaplama için bir sayı giriniz: ");
            birinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Şimdi hesaplama yapmak için diğer sayınızı giriniz: ");
            ikinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayılarınız tamam! Şimdi yapmak istediğiniz işlemi girin ( x , / , +, -): ");

            islem = Console.ReadLine();

            if (islem == "x")
            {
                sonuc = birinciSayi * ikinciSayi;
                Console.WriteLine("Sonuç: " + birinciSayi + " x " + ikinciSayi + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == "/")
            {
                sonuc = birinciSayi / ikinciSayi;
                Console.WriteLine("Sonuç: " + birinciSayi + " / " + ikinciSayi + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == "+")
            {
                sonuc = birinciSayi + ikinciSayi;
                Console.WriteLine("Sonuç: " + birinciSayi + " + " + ikinciSayi + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == "-")
            {
                sonuc = birinciSayi - ikinciSayi;
                Console.WriteLine("Sonuç: " + birinciSayi + " - " + ikinciSayi + " = " + sonuc);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Upps! Yanlış bir şeyler oldu lütfen tekrar deneyizin!");
                Console.ReadLine();
            }
        }
    }
}
