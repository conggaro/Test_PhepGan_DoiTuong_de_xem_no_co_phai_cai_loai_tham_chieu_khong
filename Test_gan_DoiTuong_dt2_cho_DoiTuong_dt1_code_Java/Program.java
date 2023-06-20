public class Program{
    public static void main(String[] agrs){
        // tạo dt1 và dt2
        Person dt1 = new Person();
        Person dt2 = new Person(1, "Nguyen Van A");

        // ban đầu
        System.out.print("Ban dau:\n");
        dt1.HienThi();
        dt2.HienThi();

        // sau khi gán dt2 cho dt1
        System.out.print("\nSau khi gan dt2 cho dt1:\n");
        dt1 = new Person(dt2);
        dt1.HienThi();
        dt2.HienThi();

        // sau khi thay đổi id của dt1
        System.out.print("\nSau khi thay doi id cua dt1:\n");
        dt1.set_id(99);
        dt1.HienThi();
        dt2.HienThi();

        // sau khi thay đổi id của dt2
        System.out.print("\nSau khi thay doi id cua dt2:\n");
        dt2.set_id(1000);
        dt1.HienThi();
        dt2.HienThi();

        System.out.print("\n");
    }
}