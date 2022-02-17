using System;

//BT09: Kiểm tra chẵn lẻ trong C#

namespace BT09
{
    internal class BT09
    {    
        static void Main()
        {
            

            Console.Write("Nhap so bat ky: ");
            int n = Convert.ToInt32(Console.ReadLine());

            void checknumber(int n)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Day la so chan");
                }
                else
                {
                    Console.WriteLine("Day la so le");
                }
            }

            checknumber(n);

            Console.ReadKey();
        }
    }
}
