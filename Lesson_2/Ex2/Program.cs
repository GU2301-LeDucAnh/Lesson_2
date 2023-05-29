using System;

public class Ex2
{
    static void Main()
    {
        int n;
        Console.WriteLine("Nhap so n: ");
        n = Convert.ToInt16(Console.ReadLine());

        DanhSach(n);
        TimSoChan(n);
        TimSoLe(n);
        DaoNguocDanhSach(n);

        void DanhSach(int n)
        {
            Console.Write("Danh Sach tu so 1 den n la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + (i + 1));
            }
            Console.WriteLine();
        }

        void TimSoChan(int n)
        {
            Console.Write("Danh Sach tu so 1 den n la so chan la:");
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 == 0)
                    Console.Write(" " + (i + 1));
            }
            Console.WriteLine();
        }

        void TimSoLe(int n)
        {
            Console.Write("Danh Sach tu so 1 den n la so le la:");
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 != 0)
                    Console.Write(" " + (i + 1));
            }
            Console.WriteLine();
        }

        void DaoNguocDanhSach(int n)
        {
            Console.Write("Danh Sach dao nguoc:");
            for (int i = n; i > 0; i--)
            {
                Console.Write(" " + (i - 1));
            }
            Console.WriteLine();
        }
    }
}