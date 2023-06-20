var dt1;

var dt2 = {
    id: 1,
    ten: "Nguyen Van A"
}

// ban đầu
console.log("Ban đầu:");
console.log(dt1);
console.log(dt2);

// gán dt2 cho dt1
console.log("Sau khi gán dt2 cho dt1:");
dt1 = dt2;
console.log(dt1);
console.log(dt2);

// sửa id của dt1 và xem kết quả
console.log("Sau khi sửa id của dt1:");
dt1.id = 2;
console.log(dt1);
console.log(dt2);

// sửa id của dt2 và xem kết quả
console.log("Sau khi sửa id của dt2:");
dt2.id = 99;
console.log(dt1);
console.log(dt2);