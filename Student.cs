using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Console;
namespace hw
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age{ get; set; }
        public string University{ get; set; }


        public Student(){
        WriteLine("enter your name: ");
        Name = ReadLine();

        WriteLine("enter your surname: ");
        Surname = ReadLine();

         WriteLine("enter your age: ");
         string a = ReadLine();
         int age = int.Parse(a);
         Age = age;

        WriteLine("enter your university: ");
        University = ReadLine();
    }

    public Student(string n, string s, int a, string u){
        Name = n;
        Surname = s;
        Age = a;
        University = u;
    }
    }


    class Program
{
    static void Main()
    {

// Реализуйте пользовательский тип Студент. В нём должна быть
// информация об имени, фамилии, возрасте, названии учебного
// заведения.
// Для массива студентов реализуйте следующие запросы:
//  Получить весь массив студентов
//  Получить студентов с именем Boris
//  Получить студентов с фамилией, которая начинается с Bro
//  Получить студентов, которые старше 19 лет
//  Получить студентов, которые старше 20 лет и младше 23 лет
//  Получить студентов, которые учатся в MIT
//  Получить студентов, которые учатся в Oxford и их возраст
// старше 18 лет. Результат отсортировать по возрасту по
// убыванию.

        Student[] students = new Student[]
        {
            new Student { Name = "Boris", Surname = "Brodsky", Age = 20, University = "MIT" },
            new Student { Name = "Anna", Surname = "Brown", Age = 22, University = "Oxford" },
            new Student { Name = "Boris", Surname = "Smith", Age = 18, University = "Harvard" },
            new Student { Name = "John", Surname = "Brooks", Age = 21, University = "Oxford" },
            new Student { Name = "Sarah", Surname = "Williams", Age = 19, University = "MIT" },
        };

        //  Получить весь массив студентов

        // var task1 = from s in students select s;
        // var task1 = students.Select(s => s);

        // foreach(var s in task1){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }


        //  Получить студентов с именем Boris

        //  var task2 = from s in students where s.Name == "Boris" select s;
        //  var task2 = students.Where(s => s.Name == "Boris");

        // foreach(var s in task2){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }


        //  Получить студентов с фамилией, которая начинается с Bro
        // var task3 = from s in students where s.Surname.StartsWith("Bro") select s;
        // var task3 = students.Where(s => s.Surname.StartsWith("Bro"));

        // foreach(var s in task3){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }




        //  Получить студентов, которые старше 19 лет
        // var task4 = from s in students where s.Age > 19 select s;
        // var task4 = students.Where(s => s.Age > 19);

          // foreach(var s in task4){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }


//  Получить студентов, которые старше 20 лет и младше 23 лет

// var task5 = from s in students where s.Age > 19 && s.Age < 23 select s;
// var task5 = students.Where(s => s.Age > 19 && s.Age < 23);

// foreach(var s in task5){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }



//  Получить студентов, которые учатся в MIT

// var task6 = from s in students where s.University == "MIT" select s;
// var task6 = students.Where(s => s.University == "Mit");

// foreach(var s in task6){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }


//  Получить студентов, которые учатся в Oxford и их возраст
// старше 18 лет. Результат отсортировать по возрасту по
// убыванию.
// var task7 = from s in students where s.Age > 18 && s.University == "Oxford" select s;
// var task7 = students.Where(s => s.Age > 18 && s.University == "Oxford");

// foreach(var s in task7){
        //     WriteLine(s.Name + s.Surname + s.Age + s.University + "\t");
        // }



    }
}


}