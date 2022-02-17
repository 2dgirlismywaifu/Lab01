using System;

namespace BT10
{
    internal class BT10
    {
        static void Main()
        {
            //Khai bao 2 chuoi string va answer
            
            Console.Write("Nhap so bat ky trong he thap phan: ");
            string answer = Console.ReadLine();
            string result = ""; //bien result de mac dinh la rong
            
            int a = Convert.ToInt32(answer);
            
            while (a > 1)
            {
                int remainder = a % 2;
                result = Convert.ToString(remainder) + result;
                a /= 2; //a = a / 2
            }
            result = Convert.ToString(a) + result;
            Console.WriteLine("So trong he nhi phan tuong ung la: " + result);

            Console.ReadKey();
        }
    }
}

