#include <iostream>
#include "Person.cpp"
using namespace std;

int main(){
    Person dt1 = Person();
    Person dt2 = Person(1, "Nguyen Van A");

    // in ra ban đầu
    cout << "Ban dau:\n";
    dt1.HienThi();
    dt2.HienThi();
    
    // thử gọi hàm gán dt2 cho dt1
    dt1 = Person(dt2);
    cout << "\nSau khi copy:\n";
    dt1.HienThi();
    dt2.HienThi();

    // thử thay đổi id ở dt1 xem dt2 có bị thay đổi không
    dt1.set_id(999);
    cout << "\nSau khi thay doi id cua dt1:\n";
    dt1.HienThi();
    dt2.HienThi();

    // thử thay đổi id ở dt2 xem dt1 có bị thay đổi không
    dt2.set_id(1000);
    cout << "\nSau khi thay doi id cua dt2:\n";
    dt1.HienThi();
    dt2.HienThi();
    
    cout << "\n";

    return 0;
}