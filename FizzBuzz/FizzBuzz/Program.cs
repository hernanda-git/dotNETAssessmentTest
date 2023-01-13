using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Melakukan perulangan dari 1 hingga 100
            for (int i = 1; i <= 100; i++)
            {
                // Mengambil output untuk proses angka saat ini
                string output = GetFizzBuzzOutput(i);

                // Menuliskan output ke console
                Console.WriteLine(output);
            }

            Console.WriteLine("Program selesai, pencet tombol apapun untuk keluar...");
            // Menunda console app ada tombol yang dipencet
            Console.ReadKey();
        }

        static string GetFizzBuzzOutput(int number)
        {
            // Memeriksa apakah angka adalah kelipatan dari 3 dan 5 (Dengan mengkalikan 3 dan 5)
            if (number % 15 == 0)
                return "FizzBuzz";
            // Memeriksa apakah angka adalah kelipatan dari 3
            else if (number % 3 == 0)
                return "Fizz";
            // Memeriksa apakah angka adalah kelipatan dari 5
            else if (number % 5 == 0)
                return "Buzz";
            // Jika angka bukan termasuk semuanya
            else
                return number.ToString();
        }
    }
}
