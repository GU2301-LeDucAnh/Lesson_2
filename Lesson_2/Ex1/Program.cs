using System;
using System.Runtime.InteropServices;

namespace Ex1
{
    public class Ex1
    {
        static void Main()
        {
            double a; //chieu rong 
            double b; //chieu dai
            Console.WriteLine("Nhap chieu dai: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chu vu hinh chu nhat co canh a = " + a + " va canh b = " + b + " la: " + TinhChuVi(a, b) +"\n");
            Console.Write("Dien tich hinh chu nhat co canh a = " + a + " va canh b = " + b + " la: " + TinhDienTich(a, b));

            double TinhChuVi(double a, double b)
            {
                return (a + b) * 2;
            }

            double TinhDienTich(double a, double b)
            {
                return a * b;
            }
        }
    }
}
