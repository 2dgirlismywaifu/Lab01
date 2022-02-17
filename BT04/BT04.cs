using System;

//BT04: Viết chương trình nhập vào 2 số và 1 phép toán bất kì ( +, -, *, / ) từ bàn phím. 
//Sau đó thực hiện in ra ngoài màn hình 2 số và kết quả phép tính nêu trên.

namespace BT04
{
    internal class BT04
    {
        static void Main()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("=================================");
            Console.WriteLine("Lua chon phep toan: ");
            Console.WriteLine("1. Phep cong");
            Console.WriteLine("2. Phep tru");
            Console.WriteLine("3. Phep nhan");
            Console.WriteLine("4. Phep chia");
            Console.WriteLine("5. Thoat");
            Console.Write("Lua chon: ");
            int opt = Convert.ToInt32(Console.ReadLine());
           
            //sử dụng switch case
            int result;
            switch (opt)
            {
                case 1: //phép cộng
                    result = a + b;
                    Console.WriteLine("Ket qua: " + result);
                    break;
                case 2: //phép trừ
                    result = a - b;
                    Console.WriteLine("Ket qua: " + result);
                    break;
                case 3: //phép nhân
                    result = a * b;
                    Console.WriteLine("Ket qua: " + result);
                    break;
                case 4: //phép chia
                    if (b == 0)
                    {
                        Console.WriteLine("Khong co phep chia cho 0");
                        break;
                    }
                    else
                    {
                        result = a / b;
                        int surplus = a % b; //số dư
                        if (surplus == 0)
                        {
                            Console.WriteLine("Day la phep chia het");
                        }
                        else
                        {
                            Console.WriteLine("Du: " + surplus);
                        }
                        Console.WriteLine("Ket qua: " + result);
                        break;
                    }
                case 5:
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le: ");
                    break;

            }
            Console.ReadKey();
        }
    }
}
