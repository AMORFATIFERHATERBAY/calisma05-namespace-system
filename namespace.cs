using System;
//using System.Text;
using Grafik3D;
using Grafik2D;




using Nokta2D = Grafik2D.Nokta; // takma isim
using Nokta3D = Grafik3D.Nokta; // takma isim
//using K = System.Console;
//using DY = System.Boolean;
//using TarihSaat = System.DateTime;

namespace Grafik3D
{
    public class Nokta
    {
        public Nokta()
        {
            Console.WriteLine("3D nokta");
        }
    }
}

namespace Grafik2D
{
    public class Nokta
    {
        public Nokta()
        {
            Console.WriteLine("2D nokta");

        }
    }
}

namespace calisma05_namespaces
{
    public class UsingDispose : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose bloğu çalıştı.");
        }
    }

    class Islemler
    {
        // public double a;
        // public double b;
        static public double Toplam(double a, double b)
        {
            return a + b;
        }
    }

    class Deneme
    {
        public int mx;
        public int my;
        public Deneme(int x, int y) //yapıcı metot
        {
            mx = x + y;
            my = y;
        }
        public int ResultMulti(int x, int y)
        {
            return x * y;
        }
        public void Yaz()
        {
            Console.WriteLine("x : " + mx);
            Console.WriteLine("y : " + my);
        }
    }

    class Program
    {
        static int Topla(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");// System.Console.WriteLine("Hello World!"); -> eğer using System isim alanını kullanmamış olsaydık,
                                              // Console'un başına system yazarak derleyebirdik.
            int b = 6;
            Int32 a = 10;              // System isim alanı olmadan bunu derlemezdi ama "int a = 10;" derlerdi.Derlemesi için System.Int32 a = 10; yazmamız gerekirdi. 
            Console.WriteLine(a += 1); // => 11
            Console.WriteLine(a++);    // => 11 yazar ve sonra 1 artırır 12 olur.
            Console.WriteLine(++a);    // => 12 olan a'yı 1 daha artırır önce 13 olur ve sonra bunu 13 olarak yazar.
            Console.WriteLine(b);

            Deneme d = new Deneme(5, 6);
            Console.WriteLine("x :" + d.mx); //+ d.my);
            Console.WriteLine(d);
            int t = Topla(5, 6);
            Console.WriteLine(t);
            Console.WriteLine(Topla(5, 9));
            //calisma05_namespaces.Deneme de = new calisma05_namespaces.Deneme(5, 4);
            //Console.WriteLine(Deneme.ResultMulti(5, 3));
            Console.WriteLine(d.ResultMulti(5, 3));
            d.Yaz();



            Console.WriteLine(Islemler.Toplam(20.5, 6));
            Console.WriteLine(calisma05_namespaces.Islemler.Toplam(25.5, 3));

            Grafik2D.Nokta nokta2D = new Grafik2D.Nokta();
            Grafik3D.Nokta nokta3D = new Grafik3D.Nokta();

            Nokta2D n = new Nokta2D();
            Nokta3D nok = new Nokta3D();

            UsingDispose di = new UsingDispose();
            using (di)
            {
                Console.WriteLine("using bloğu");
            }
            Console.WriteLine("using bloğu dışı");

            using (UsingDispose d1 = new UsingDispose(), d2 = new UsingDispose())
            {
                Console.WriteLine("using bloğu");
            }
            Console.WriteLine("using bloğu dışı");

            bool asalmi = true; // boolean => takma DY takma adı ile çağırdık.
            if (asalmi)
                Console.WriteLine("->Doğru"); // K => Console yerine takma ad ile çağırma.

            // TarihSaat ts = new TarihSaat();
            // ts = Convert.ToDateTime(K.ReadLine());
            // K.WriteLine(ts);

            Array ar = Array.CreateInstance(typeof(int), 5, 3);
            for (int i = 0; i <= ar.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= ar.GetUpperBound(1); ++j)
                {
                    ar.SetValue(i + j, i, j);
                    Console.Write(ar.GetValue(i, j) + " ");
                }
                Console.WriteLine();
            }

            // Console.WriteLine(UInt64.MaxValue);
            // Console.WriteLine(Int64.MinValue);
            // Console.WriteLine(UInt32.MinValue);
            // Console.WriteLine(UInt32.MaxValue);
            // Console.WriteLine(Int32.MinValue);
            // Console.WriteLine(Int32.MaxValue);
            // Console.WriteLine(Decimal.MaxValue);

            string s = "56";
            int m = Int32.Parse(s); // int int.Parse(string s)
                                    // Converts the string representation of a number to its 32-bit signed integer equivalent.

            Console.WriteLine(m + 5);
            // if( bool // override object.Equals
            // public override bool Equals(object obj)
            // {
            //     //
            //     // See the full list of guidelines at
            //     //   http://go.microsoft.com/fwlink/?LinkID=85237
            //     // and also the guidance for operator== at
            //     //   http://go.microsoft.com/fwlink/?LinkId=85238
            //     //

            //     if (obj == null || GetType() != obj.GetType())
            //     {
            //         return false;
            //     }

            //     // TODO: write your implementation of Equals() here
            //     throw new System.NotImplementedException();
            //     return base.Equals (obj);
            // }

            // // override object.GetHashCode
            // public override int GetHashCode()
            // {
            //     // TODO: write your implementation of GetHashCode() here
            //     throw new System.NotImplementedException();
            //     return base.GetHashCode();
            // })
            object o = 57;
            int k = 5;


            if (m.Equals(o))
            { Console.WriteLine("doğru"); }
            else
            { Console.WriteLine("yanlış"); }

            if (m.CompareTo(o) == 0)
            { Console.WriteLine(m.CompareTo(o)); }
            else
            { Console.WriteLine("sayılar eşit değil ve k ile m nin toplamı :" + (k + m)); }

            char ch = 'a';
            Console.WriteLine("Bir karakter giriniz : ");
            ch = Convert.ToChar(Console.ReadLine());



            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Doğru " + ch);
            }
            else
            {
                Console.WriteLine("Yanlış " + ch);

            }

            Console.WriteLine("char ch karakter numerik mi :" + Char.GetNumericValue(ch));
            if (Char.GetNumericValue(ch) == -1)
            {
                Console.WriteLine("ch numerik bir karakter değilidr : " + Char.GetNumericValue(ch));

            }
            else
            {
                Console.WriteLine(Char.GetNumericValue(ch));

            }
            string z = "000";
            Console.WriteLine(String.Concat(s, z));

            string str = "BEN akşam eve genelde 21:30 civarı gelirim ve Ahmet'le sabahları 8:30 da ayrılırız.";

            for (int i = 0; i < str.Length; ++i)
            {
                if (Char.IsDigit(str[i]))  // bool char.IsDigit(char c) ,
                {                          // Indicates whether the specified Unicode character is categorized as a decimal digit.

                    Console.Write(str[i] + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < str.Length; ++i)
            {
                if (Char.IsUpper(str[i])) // bool char.IsUpper(char c)
                                          // Indicates whether the specified Unicode character is categorized as an uppercase letter.
                {

                    Console.Write("'" + str[i] + "'" + " ");
                    Console.WriteLine($"büyük harf ve  i[{i}] indeks ");
                }
            }
            Console.WriteLine();

            if (Char.IsUpper(str, 2)) // bool char.IsUpper(string s, int index)
                                      // Indicates whether the character at the specified position in a specified string is categorized as an uppercase letter.
            {
                Console.WriteLine("'str' cümlesinin 3.karakteri büyük harftir.");
            }
            else
            {
                Console.WriteLine("'str' cümlesinin 3.karakteri büyük harf değildir.");

            }
            string BuyukYazi = "";
            //Console.WriteLine(BuyukYazi=str.ToUpper());
            for (int i = 0; i < str.Length; ++i)
                BuyukYazi += Char.ToUpper(str[i]);

            Console.WriteLine("Büyük Yazı : " + BuyukYazi);

            string KucukYazi = "";
            for (int i = 0; i < BuyukYazi.Length; ++i)
                KucukYazi += Char.ToLower(BuyukYazi[i]);

            Console.WriteLine("Küçük Yazı : " + KucukYazi);

            Decimal dec = new decimal(986576, 0, 0, false, 3);
            Console.WriteLine(decimal.Round(dec, 2));

            Console.WriteLine("En küçük :" + DateTime.MinValue);
            Console.WriteLine("En küçük :" + DateTime.MinValue);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            DateTime Tarih = new DateTime(2020, 07, 10, 23, 12, 59);
            Console.WriteLine("*---" + Tarih.DayOfWeek);
            Console.WriteLine(Tarih.DayOfYear);
            Console.WriteLine(Tarih.Date);
            Console.WriteLine(Tarih.Month);
            Console.WriteLine(Tarih.Day);
            Console.WriteLine(Tarih.TimeOfDay + "-----*");
            int we = Convert.ToInt32(Tarih.DayOfWeek);
            int week = Convert.ToInt32(DayOfWeek.Friday);

            int trh = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine(trh);
            Console.WriteLine(we);
            Console.WriteLine(Tarih);

            int yil, ay, gun;
            Console.Write("Doğum yılı : ");
            yil = Convert.ToInt32(Console.ReadLine());

            Console.Write("Doğum ayı : ");
            ay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Doğum günü : ");
            gun = Convert.ToInt32(Console.ReadLine());

            DateTime Bugun = DateTime.Today;
            DateTime DogumTarihi = new DateTime(yil, ay, gun);

            TimeSpan fark = Bugun - DogumTarihi;
            //Console.WriteLine("*"+fark);

            Console.WriteLine("Doğduğun gün :" + DogumTarihi.DayOfWeek);
            Console.WriteLine("Geçen gün sayısı :" + fark.Days);

            int GunSayisi;
            Console.Write("Gün sayısını giriniz :");
            GunSayisi = Convert.ToInt32(Console.ReadLine());

            TimeSpan GunSonra = new TimeSpan(GunSayisi, 0, 0, 0);
            DateTime dt = DateTime.Today+GunSonra;

            Console.WriteLine($" Bugünden {GunSayisi} gun sonra ki gün {dt.DayOfWeek} 'dir");























        }
    }
}
