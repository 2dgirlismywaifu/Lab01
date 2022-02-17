using System;

//Tìm vận tốc (m/s, km/h, mile/h) với quãng đường và thời gian nhập từ bàn 
//phím trong C#.

namespace BT07
{
    internal class BT07
    {
        static void Main()
        {
            //khai bao bien quang duong va thoi gian nhap tu ban phim

            Console.WriteLine("Mac dinh: s (km) va t (h)");
            Console.Write("Nhap quang duong: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thoi gian: ");
            int t = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("================================");
            Console.WriteLine("Mac dinh tinh theo km/h");
            Console.WriteLine("Vui long lua chon");
            Console.WriteLine("1. Tiep tuc tinh theo km/h");
            Console.WriteLine("2. Doi don vi va tinh theo m/s");
            Console.WriteLine("3. Doi don vi va tinh theo mile/h");
            Console.Write("Lua chon: ");

            double result; //bien ket qua
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1: //tinh theo km/h
                    result = s / t;
                    Console.WriteLine("Van toc (km/h): " + result);
                    break;
                case 2:
                    result = (s * 1000) / (t * 60);
                    Console.WriteLine("Quang duong (m): " + (s * 1000));
                    Console.WriteLine("Thoi gian (s): " + (t * 60));
                    Console.WriteLine("Van toc (m/s): " + result);
                    break;
                case 3:
                    //1km = 0.6214 mile
                    double b = 0.6214;
                    result = (double)((s * b) / t);
                    Console.WriteLine("Quang duong (mile): " + (s * b));
                    Console.WriteLine("Van toc (mile/h): " + result);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Thoat chuong trinh !");
                    Console.ReadKey();
                    System.Environment.Exit(1);
                    break;

            }

            Console.ReadKey();

        }
    }
}
