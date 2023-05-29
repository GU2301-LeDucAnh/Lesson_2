using System;

public class Ex3
{
    static void Main()
    {
        int number;
        int bien_dem = 0;

        Console.Write("Nhap so n: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                bien_dem++;

        if (bien_dem == 2)
            Console.WriteLine("So n la so nguyen to.");
        else
            Console.WriteLine("So n khong phai la so nguyen to.");
    }
}
