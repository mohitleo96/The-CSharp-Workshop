using System;
using System.Collections.Generic;
public class Student
{
    public int Sid{get; set;}
    public string Sname{get; set;}
    public float Smarks{get; set;}

}

public class CompareStudentMarks: IComparer<Student>
{
    //This syntex will automatically comes if we are creating the instance of interface.
    public int Compare(Student x, Student y)
    {
        if(x.Smarks>y.Smarks)
        {
         return 1;
        }
        else if(x.Smarks<y.Smarks)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}


class Program
{
    static void Main()
    {
        Student student1 = new Student(){Sid = 12, Sname = "Ram", Smarks = 34.67f};
        Student student2 = new Student(){Sid = 22, Sname = "shyam", Smarks = 84.67f};
        Student student3 = new Student(){Sid = 2, Sname = "Vaibhav", Smarks = 74.69f};
        Student student4 = new Student(){Sid = 12, Sname = "Deppak", Smarks = 4.00f};

        List<Student> students = new List<Student>(){ student1, student2 ,student3 ,student4};

        // CompareStudentMarks object1 = new CompareStudentMarks();

         //We use IComparer interface into a new class CompareStudentMarks we we don't want to modify the existing class.
        // students.Sort(object1);


        //By using delegate also we do the comparasion
        //By Using Lamda expressions i did here but Annonymus funtion/Defining Delegate is also work.
        students.Sort((s1,s2)=>s1.Sname.CompareTo(s2.Sname));

        foreach(Student obj in students)
        {
            Console.WriteLine(obj.Sid+" "+obj.Sname+" "+obj.Smarks);
        }

    }
}

//output
// 12 Deppak 4
// 12 Ram 34.67
// 22 shyam 84.67
// 2 Vaibhav 74.69