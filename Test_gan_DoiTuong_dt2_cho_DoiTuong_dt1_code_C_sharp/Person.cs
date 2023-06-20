using System;

class Person{
    private int id;
    private string ten;

    // hàm khởi tạo không tham số
    public Person(){
        id = 0;
        ten = "NO NAME";
    }

    // hàm khởi tạo có tham số
    public Person(int data1, string data2){
        id = data1;
        ten = data2;
    }

    // hàm hiển thị
    public void HienThi(){
        Console.Write(id + "\t" + ten + "\n");
    }

    // get_id và get_ten
    public int get_id(){
        return id;
    }
    public string get_ten(){
        return ten;
    }

    // set_id và set_ten
    public void set_id(int data){
        id = data;
    }
    public void set_ten(string data){
        ten = data;
    }

    // hàm gán dt2 cho dt1
    public Person(Person dt){
        id = dt.get_id();
        ten = dt.get_ten();
    }

    // hàm hủy
    ~Person(){
        Console.WriteLine("Huy doi tuong");
    }
}