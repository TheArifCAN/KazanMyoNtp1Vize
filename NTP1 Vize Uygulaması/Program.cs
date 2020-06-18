using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP1_Vize_Uygulaması
{
    class Program
    {
        public static kitap[] Kitabevi { get; private set; }

        static void Main(string[] args)
        {
            

            {
                


                Console.WriteLine("Kitap eklemek için1'e\nKitap listesini görmek için 2'ye basınız");
                byte liste = byte.Parse(Console.ReadLine());
                if (liste==1)
                {
                    Console.WriteLine("Kaç kitap ekleyeceksiniz?");
                    byte kitapsecimi = byte.Parse(Console.ReadLine());
                    Kitabevi = new kitap[kitapsecimi];
                    for (int i = 0; i < kitapsecimi; i++)
                    {
                        kitap kitap = new kitap();
                        Console.WriteLine("Lütfen kitap bililerini ekleyiniz");
                        Console.WriteLine("Kitap adını giriniz: ");
                        kitap.Isim = Console.ReadLine();
                        Console.WriteLine("kitap türünü giriniz");
                        kitap.Tür = Console.ReadLine();
                        Console.WriteLine("kitap yazarını giriniz");
                        kitap.Yazar = Console.ReadLine();
                        Console.WriteLine("kitap basım yılını giriniz");
                        kitap.Tarih = new DateTime(Convert.ToInt32(Console.ReadLine()), 1, 1);
                        Console.WriteLine("------------------------------------------------");
                        Kitabevi[i] = kitap;

                        



                        


                    }
                    

                }
                
                else if (liste==2)
                {
                    kitap.Kitaplar();
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                }

                



            }
        }
    }
    
}
