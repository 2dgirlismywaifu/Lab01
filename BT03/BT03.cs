using System;


//BT03: Viết chương trình nhập vào 2 chuỗi bất kì từ bàn phím, kiểm tra xem 2 chuỗi 
//này có giống hệt nhau hay không ( bài toán kiểm tra khớp mật khẩu)


//sử dụng thư viện BCrypt.Net-Next (4.0.2)
//Lệnh cài qua dotnet CLI
//dotnet add package BCrypt.Net-Next
namespace BT03
{
    internal class BT03
    {
        
        static void Main(string[] args)
        {
            //đơn giản nhất
            Console.Write("Nhap chuot thu nhat: ");
            String text01 = Console.ReadLine();
            ///////////////////////////////////////////
            Console.Write("Nhap chuoi thu hai: ");
            String text02 = Console.ReadLine();

            //Dùng equals để so sánh hai chuỗi

            if (text01.Equals(text02))
            {
                Console.WriteLine("Chuoi trung khop");
            }
            else
            {
                Console.WriteLine("Chuoi khong khop");
            }

            //mở rộng hơn với BCrypt
            //ở đây sử dụng với hàng băm mật khẩu BCrypt
            //var cost = 10; //vòng băm BCrypt đặt là 10 lần

            ////vòng băm cao nhất là 31, thấp nhất là 8
            ////chú ý: vòng băm càng cao thì CPU càng phải xử lý cao

            ////chuỗi đầu tiên nhập bất kỳ
            //Console.Write("Nhap chuot thu nhat: ");
            //String text01 = Console.ReadLine();

            ////ta thử hash từ text01
            //String hashtxt01 = BCrypt.Net.BCrypt.HashPassword(text01, workFactor: cost);
            //Console.WriteLine("===========================================");
            //Console.WriteLine("Ban co the dung thu chuoi tu bam sau de thu");
            //Console.WriteLine("Chuoi ban nhap da duoc bam nhu sau: ");
            //Console.WriteLine(hashtxt01);
            ////chuỗi thứ hai là chuỗi hashtxt01 hoặc ta tự băm chuỗi tại
            ////https://bcrypt-generator.com/

            ////chú ý: vòng băm chọn phải trùng khớp với biến cost

            //Console.WriteLine("Nhap chuoi thu hai: ");
            //String text02 = Console.ReadLine();

            ////tiến hành so sánh chuỗi
            //var verify = BCrypt.Net.BCrypt.Verify(text01, text02);
            //if (verify)
            //{
            //    Console.WriteLine("Chuoi trung khop");
            //}
            //else
            //{
            //    Console.WriteLine("Chuoi khong khop");
            //}


            Console.ReadKey();
        }
    }
}
