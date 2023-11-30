using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayıyı girin ");
            double s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            double s2 = Convert.ToInt32(Console.ReadLine());

            DortIslem dortIslem = new DortIslem();
            Console.WriteLine("İki sayının toplamı" + dortIslem.Topla(s1, s2));
            Console.WriteLine("iki sayının çarpımı" + dortIslem.Carpma(s1, s2));
            Console.WriteLine("iki sayıın  çıkarımı" + dortIslem.Cıkarma(s1, s2));
            Console.WriteLine("iki sayının bölümü" + dortIslem.Bolme(s1, s2));

        }
    }
    class DortIslem
    {
        public double Topla(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2);
        }
        public double Cıkarma(double sayi1, double sayi2)
        {
            return (sayi1 - sayi2);
        }
        public double Carpma(double sayi1, double sayi2)
        {
            return (sayi1 * sayi2);
        }
        public double Bolme(double sayi1, double sayi2)
        {
            return (sayi1 / sayi2);
        }
    }   
}
