using System;

//BT08: Chương trình C# để kiểm tra một chữ cái thường nhập từ bàn phím là nguyên 
//âm, chữ số hay ký tự khác

namespace BT08
{
    internal class BT08
    {
        static void Main()
        {
            //khai bao kieu du lieu char
            char symbol;

            Console.Write("Nhap vao mot ky tu: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
            //nguyen am: u e o a i -> ue oai
            {
                Console.WriteLine("Ky tu vua nhap la nguyen am.");
            }
            // chu so: tu 0 -> 9
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("Ky tu vua nhap la chu so.");
            }                 
            else
            {
                Console.Write("Ky tu vua nhap la ky tu khac.");
            }    
            
            Console.ReadKey();

        }
    }
}
