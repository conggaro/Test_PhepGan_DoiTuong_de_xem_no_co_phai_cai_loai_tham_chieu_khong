using System;

namespace MyApp{
    class Program{
        public static void Main(string[] agrs){
            // tạo dt1 và dt2
            Person dt1 = new Person();
            Person dt2 = new Person(1, "Nguyen Van A");
            
            // ban đầu
            Console.Write("Ban dau:\n");
            dt1.HienThi();
            dt2.HienThi();

            // sau khi gán dt2 cho dt1
            dt1 = new Person(dt2);
            Console.Write("\nSau khi gan dt2 cho dt1:\n");
            dt1.HienThi();
            dt2.HienThi();

            // sau khi thay đổi id của dt1
            dt1.set_id(99);
            Console.Write("\nSau khi thay doi id cua dt1:\n");
            dt1.HienThi();
            dt2.HienThi();

            // sau khi thay đổi id của dt2
            dt2.set_id(1000);
            Console.Write("\nSau khi thay doi id cua dt2:\n");
            dt1.HienThi();
            dt2.HienThi();

            Console.Write("\n");
        }
    }
}