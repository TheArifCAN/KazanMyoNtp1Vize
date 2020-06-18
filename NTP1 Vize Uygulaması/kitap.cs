using System;
using System.IO;

namespace NTP1_Vize_Uygulaması
{
    public class kitap
    {



        
       public string isim;
        public string tür;
        public string yazar;
        public DateTime tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                if
                    (value.Year <= 2020)
                {
                }
                else
                {
                    Console.WriteLine("Yıl 2020'den küçük olmalı");
                    tarih = new DateTime(Convert.ToInt32(Console.ReadLine()), 1, 1);
                }
            }

        }

        public string Isim { get => isim; set => isim = value; }
        public string Tür { get => tür; set => tür = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }

        private static string Yol = AppDomain.CurrentDomain.BaseDirectory + "kitapliste.txt";
        public static void Kitaplar()
        {
            if (File.Exists(Yol))
            {
                string bilgilerioku = File.ReadAllText(Yol);
                Console.WriteLine(bilgilerioku);
            }
        }
        
        public static void Yazdır(string isim, string tür,string yazar, DateTime tarih)
        {
            string kitaplar = "\nkitap bilgileri \nkitap adı: " + isim + "\nkitap türü: " + tür + "\nkitap yazarı: " + yazar + "\nbasım tarihi: " + tarih ;
            
        }

        
        
        
        


    }
      
    }
