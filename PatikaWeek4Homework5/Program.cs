
using PatikaWeek4Homework5.Concrete;
using PatikaWeek4Homework5.Abstract;


// Öğretmen için instance oluşturuluyor
Teacher teacher = new Teacher()
{
    Name = "Şule",
    Surname = "Tepe",
    TeacherSalary=65000
};
teacher.TeacherInfo();

//Öğrenci için instance oluşturuluyor
Student student = new Student()
{
    StudentNumber = 1,
    Name = "Yılmaz",
    Surname = "Yıldırım",
};
student.StudentInf();

