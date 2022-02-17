using System;


//BT05: Tìm chu vi và diện tích hình tròn trong C#

namespace BT05
{
    internal class BT05
    {
        static void Main()
        {
            //khai báo biến
            int r; //bán kính
            double d = Math.E; //Số PI
            
            Console.Write("Nhap ban kinh hinh tron: ");
            r = Convert.ToInt32(Console.ReadLine());

            while (r < 0)
            {
                Console.WriteLine("Ban kinh khong hop le !");
                Console.Write("Nhap ban kinh hinh tron: ");
                r = Convert.ToInt32(Console.ReadLine());
            }

            //tính chu vi hình tròn
            Double P = (double)(r * 2 * d); //chu vi
            Console.WriteLine("Chu vi hinh tron: " + P);

            //tính diện tích hình tròn
            Double S = (double)(r * r * d); //diện tích
            Console.WriteLine("Dien tich hinh tron: " + S);

            Console.ReadKey();

        }
    }
}
