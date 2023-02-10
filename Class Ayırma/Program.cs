using System;

namespace Class_Ayırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler kisiler = new Kisiler();
            kisiler.isim = "Serhan";
            kisiler.soyisim = "Koral";
            kisiler.kimlikNumarasi = 12345678901;
            kisiler.Yazdir();

        }
    }
    partial class Kisiler
    {
        //Burada tanımalamalar
        public Int64 kimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        //Fonksiyon tanımlarken private olur bunuda aynı prob da olduğu gibi ayni isim gibi gozuken fonksiyonlarla halledilir
        partial void yazdir();
        public void Yazdir() { yazdir(); }
            

    }
    partial class Kisiler
    {
        //Burda Fonksiyonlar olur
        partial void yazdir()
        {
            Console.WriteLine("Kimlik No={0}",kimlikNumarasi);
            Console.WriteLine("İsim No={0}",isim);
            Console.WriteLine("Soyisim No={0}",soyisim);
        }

    }
}
