public class Person {
    private int id;
    private String ten;

    // hàm khởi tạo không tham số
    public Person(){
        id = 0;
        ten = "NO NAME";
    }

    // hàm khởi tạo có tham số
    public Person(int data1, String data2){
        id = data1;
        ten = data2;
    }

    public void HienThi(){
        System.out.print(id + "\t" + ten + "\n");
    }

    // get_id và get_ten
    public int get_id(){
        return id;
    }
    public String get_ten(){
        return ten;
    }

    // set_id và set_ten
    public void set_id(int data){
        id = data;
    }
    public void set_ten(String data){
        ten = data;
    }

    // hàm copy trong java
    // tức là lấy dt2 gán cho dt1
    public Person(Person dt){
        id = dt.get_id();
        ten = dt.get_ten();
    }
}
