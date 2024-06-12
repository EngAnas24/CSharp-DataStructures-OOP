using System;
using System.Linq;

namespace Calisma_sorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asal Sayıyı Bulma
            /*  int[] Asalsayilar = new int[50];
              int count = 0;

              for (int i = 2; count < 50; i++)
              {
                  bool isPrime = true;

                  for (int j = 2; j < i; j++)
                  {
                      if (i % j == 0)
                      {
                          isPrime = false;
                          break;
                      }
                  }

                  if (isPrime)
                  {
                      Asalsayilar[count] = i;
                      count++;
                  }
              }

              foreach (var prime in Asalsayilar)
              {
                  Console.WriteLine(prime);
              }
  */


            //C# Girilen İki Sayı Arasındaki Asal Sayıları Bulma (Console + Windows Form)
            /*  int count = 0;
              for (int i = 10; count < 50; i++)
              {
                  bool isPrime = true;

                  for (int j = 1; j < i; j++)
                  {
                      if (i % j == 0)
                      {
                          isPrime = false;
                          break;
                      }
                  }

                  if (isPrime)
                  {

                      Console.WriteLine("\t "+i);
                      count++;
                  }
              }
  */
            //Girilen Sayının Rakamlarının Toplamını Bulma

            /*   int say = 10548;
               int sayac = 0;
               int tmp = 0;
               while (say > 0)
               {
                    tmp += say % 10;
                 say = say / 10;
                   sayac++;
               }
               Console.WriteLine("\n Sayının Rakamlarının Adedi: "+sayac);
               Console.Write("Sayının Rakamlarının Toplami: " + tmp);
   */

            //Split Fonksiyonu Kullanımı – Metni Bölme

            /*char[] ayrac = { '-','/', ' ', ':' ,','};
            string tarih = "2018-05/03 14:50";

            string[] parcalar = tarih.Split(ayrac);

            Console.WriteLine("Yıl:{0}  Ay:{1} Gün:{2}  Saat:{3} Dakika:{4}", parcalar[0], parcalar[1], parcalar[2], parcalar[3], parcalar[4]);
*/

            //1-250 arası 3 e ve 7’ye Tam Bölünen Sayıları Listeleme
            /*  for(int i = 1; i < 250; i++)
              {
                  if (i % 3 == 0 & i % 7 == 0)
                  {
                      Console.WriteLine(i);
                  }
              }*/

            //MTV Hesaplama Örneği
            /*   double[] aractutar = { 100, 200 };
               double [] yastutar = { 1.75, 1.50 , 1.25 };
               double[] hacimCarpim = { 2, 3, 4 ,5};
               int aracSecimi, YasSecimi, HacimSecimi;
               double Odeme = 0;
               Console.WriteLine("Arac tipini girin: ");
               aracSecimi = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("yasinizi girin: : ");
               YasSecimi = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Hacim tipini gir: ");
               HacimSecimi = Convert.ToInt32(Console.ReadLine());

               Odeme += aractutar[aracSecimi-1] * yastutar[YasSecimi-1] * hacimCarpim[HacimSecimi - 1];

               Console.WriteLine("Odenecek tutar: "+Odeme);*/


            //Diziler Örnek Soruları (Ogrenci notlari)


            /*   int gecenSayisi = 0, kalanSayisi = 0, besAlanSayisi = 0, sinifOrtalamasi = 0;
               int ortalamaAltiSayisi = 0, ucalanSayisi = 0, enYuksek, enDusuk;
               int enDusukKacAlmali, sinifOrtAltindakiOrt = 0, toplam = 0, toplam2 = 0;
               Random rnd = new Random();
               int[] sayilar = new int[20];//www.yazilimkodlama.com

               Console.WriteLine("Yazılı Sonuçları");
               Console.WriteLine();
               for (int i = 0; i < 20; i++)
               {
                   sayilar[i] = rnd.Next(1, 100);
                   Console.Write(sayilar[i] + " ");
               }
               Console.WriteLine();
               Console.WriteLine("============================================================");

               for (int i = 0; i < 20; i++)
               {
                   toplam += sayilar[i];
                   if (sayilar[i] >= 50)
                   {
                       gecenSayisi++;//www.yazilimkodlama.com
                   }
                   if (sayilar[i] < 50)
                   {
                       kalanSayisi++;
                   }
                   if (sayilar[i] >= 85)
                   {
                       besAlanSayisi++;
                   }
                   if (sayilar[i] >= 60 && sayilar[i] < 70)
                   {
                       ucalanSayisi++;
                   }

               }
               sinifOrtalamasi = toplam / 20;

               for (int i = 0; i < 20; i++)//www.yazilimkodlama.com
               {
                   if (sayilar[i] < sinifOrtalamasi)
                   {
                       toplam2 += sayilar[i];
                       ortalamaAltiSayisi++;
                   }
               }

               sinifOrtAltindakiOrt = toplam2 / ortalamaAltiSayisi;

               Array.Sort(sayilar);
               enYuksek = sayilar[19];
               enDusuk = sayilar[0];
               enDusukKacAlmali = 100 - enDusuk;
               Console.WriteLine("Geçen Sayısı : " + gecenSayisi);
               Console.WriteLine("Kalan Sayısı : " + kalanSayisi);
               Console.WriteLine("5 Alan Sayısı : " + besAlanSayisi);
               Console.WriteLine("3 Alan Sayısı : " + ucalanSayisi);
               Console.WriteLine("En Yüksek Not : " + enYuksek);
               Console.WriteLine("En Düşük Not : " + enDusuk);
               Console.WriteLine("En Düşük Not Alan 2. Sınavda Kaç Almalı : " + enDusukKacAlmali);
               Console.WriteLine("Sınıf Genel Ortalaması : " + sinifOrtalamasi);
               Console.WriteLine("Sınıf Ortalaması Altındaki Not Sayısı : " + ortalamaAltiSayisi);
               Console.WriteLine("Sınıf Ortalaması Altında Kalan Kişileri Ortalaması : " + sinifOrtAltindakiOrt);*/

            /*string originalString = "example";
            string result = RemoveFirstAndLastCharacters(originalString);
            Console.WriteLine(result);
            string OriginalString = "MerhabaDunya";

            // 1. Başlangıç dizinini ve alınacak alt dizinin uzunluğunu belirterek kullanım:
            string substring1 = OriginalString.Substring(3, 5);
            Console.WriteLine(substring1);  // Çıktı: habaD

            // 2. Sadece başlangıç dizinini belirterek kullanım:
            string substring2 = OriginalString.Substring(7);
            Console.WriteLine(substring2);  // Çıktı: unya
           */

            /* Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number 
             of petals and the other has an odd number of petals it means they are in love.
                   Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.*/

            Console.WriteLine(FlowersPatels(8,5));
            // Example usage:
            int year = 2023;
            int century = GetCentury(year);
            Console.WriteLine($"The year {year} belongs to the {century} century.");

            Console.ReadKey();
        }
        /*   static string RemoveFirstAndLastCharacters(string inputString)
           {
               // Check if the string has at least two characters
               if (inputString.Length >= 2)
               {
                   // Use substring to remove the first and last characters
                   string resultString = inputString.Substring(1, inputString.Length-1 );
                   return resultString;
               }
               else
               {
                   // If the string has less than two characters, return the original string
                   return inputString;
               }
           }*/

        static public bool FlowersPatels(int num1,int num2)
        {
            if (num1 %2 == 0 && num2 % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        static int GetCentury(int year)
        {
            // Calculate the century based on the given year.
            int century = (year - 1) / 100 + 1;
            return century;
        }
    }
}