using System;

//BT02: Viết chương trình nhập vào từ bàn phím 1 số n ( n là số nguyên). Hiển thị tam
//giác đều đươc tạo bởi các số 0 có đáy đúng bằng n số 0 kể trên.

namespace BT02
{
    internal class BT02
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //kiểm tra xem n có lớn hơn 0 hay không
            while (n < 0)
            {
                Console.WriteLine("So hang n khong hop le !");
                Console.Write("Nhap lai n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            //vòng lặp đầu điều khiển số hàng
            for (int i = 1; i <= n; i++)
            {
                //vòng lặp này dùng để in các khoảng trống
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                //vòng lặp này in các số 0
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0 ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
