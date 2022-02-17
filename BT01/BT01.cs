using System;


//BT01: Viết chương trình nhập vào từ bàn phím 1 chuỗi và đảo ngược chuỗi khi hiển
//thị ra màn hình

namespace Lab01
{
    internal class BT01
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot chuoi: ");
            
            //Khai báo biến name và biến reverse (đảo ngược)
            string name = Console.ReadLine();
            
            //biến reverse giá trị là rỗng
            string reverse = String.Empty;
            
            //vòng lặp for từ độ dài của chuỗi trừ đi 1 (name.length - 1) trở về 0
            //mục đích là in từ vị trí cuối về vị trí đầu và gán vào biến reverse
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i]; 
            }

            Console.WriteLine($"Chuoi dao nguoc cua {name} la: {reverse}");
            Console.ReadKey();

        }
    }
}
