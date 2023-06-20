#include <iostream>
using namespace std;

class Person{
    private:
        int id;
        string ten;

    public:
        Person(){
            id = 0;
            ten = "NO NAME";
        }

    public:
        Person(int data1, string data2){
            id = data1;
            ten = data2;
        }

    public:
        ~Person(){}

    // hàm gán đối tượng
    // gọi là hàm copy đối tượng cũng được
    public:
        Person(Person &dt){
            id = dt.get_id();
            ten = dt.get_ten();
        }

    // hiển thị
    public:
        void HienThi(){
            cout << id << "\t" + ten + "\n";
        }

    // get_id và get_ten
    public:
        int get_id(){
            return id;
        }

        string get_ten(){
            return ten;
        }

    // set_id và set_ten
    public:
        void set_id(int data){
            id = data;
        }

        void set_ten(string data){
            ten = data;
        }
};