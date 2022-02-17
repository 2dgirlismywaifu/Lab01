using System;

//BT06: Chương trình C# để tìm giá trị cụ thể của một hàm số với dãy giá trị của biến


//pt y = ax + b
namespace BT06
{
    internal class BT06
    {
        static void Main()
        {
            //Nhap a,b
            Console.Write("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //trả phương trình
            Console.WriteLine("Phuong trinh: y = " + a + "x + " + b);
            Console.WriteLine("========================================================");
            
            //nhap khoang (c,d)
            Console.WriteLine("Nhap khoang (c,d) ");
            Console.Write("Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            while (c > d)
            {
                Console.WriteLine("Khoang khong hop le: ");
                Console.Write("Nhap lai c: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap lai d: ");
                d = Convert.ToInt32(Console.ReadLine());               
            }
            Console.WriteLine("Khoang (c,d) la: (" + c + "," + d + ")");
            Console.WriteLine("========================================================");

            //vòng lặp for từ c + 1 cho den d - 1          
            for (int i = c + 1; i < d - 1; i++)
            {
                float x = (i - b) / 2;
                Console.WriteLine("y = {0} ; x = ({0} - " + b + ") / 2 " + "= {1}",i, x);
            }
            Console.ReadKey();
        }
    }
}
