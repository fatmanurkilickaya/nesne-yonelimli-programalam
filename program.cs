using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("kütüphanenin ismini giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine(isim);
            Library lib = new Library();
            lib.GetirKutuphane("Kayseri üniversitesi kütüphanesi", "kayseri");
           

            Library1 lib1 = new Library1();
            lib1.GetirKutuphane("kayü", "talas");
            

            Ogrenciler ogr = new Ogrenciler();
            ogr.IsimGetir("fatmanur");
            ogr.IsminUzunlugu();

            Console.ReadKey();

        }

       
    }

    public class Library1
    {
        string isim, adres;
        public void GetirKutuphane(string name, string adres)
        {
            this.isim = name;
            this.adres = adres; 
        }

    }
}
