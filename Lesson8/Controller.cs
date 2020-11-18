using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Controller
    {
        static void Main(string[] args)
        {
            School school = new School();
            Schedule sheduleMonady = new Schedule();
            Hours hoursMonday = new Hours();
            Hours hoursMondayDown = new Hours();
            Hours hoursMondayDownSchool = new Hours();
            Person person1 = new Person();
            Teacher obiVan = new Teacher();

            obiVan.Name = "Obi Van";
            obiVan.Sex = "male";
            obiVan.Age = 200;
            obiVan.Specialization = "Jedi Code";

            person1 = obiVan;
            Console.WriteLine(person1.Name+" | "+"Teacher 1");
            Teacher obiDownCast = (Teacher)person1;
            Console.WriteLine(obiDownCast.Name + " | " + "Specialization: "+ obiDownCast.Specialization);

            hoursMonday.LessHour1 = 45;
            hoursMonday.LessHour2 = 45;
            hoursMonday.LessHour3 = 45;
            hoursMonday.Lesson1 = "Jedi Code";
            hoursMonday.Lesson2 = "Sith fight";
            hoursMonday.Lesson3 = "Return of the Jedi";
            hoursMonday.SchoolName = "Programming Coldege";

            sheduleMonady = hoursMonday;
            school = hoursMonday;
            Console.WriteLine(sheduleMonady.Lesson1 + " Schedule UPCAST");
            Console.WriteLine(school.SchoolName + " School Name  UPCAST") ;
            hoursMondayDown = (Hours)sheduleMonady;
            hoursMondayDownSchool = (Hours)school;
            Console.WriteLine(hoursMondayDown.LessHour1 + " Less Hour 1");
            Console.WriteLine(hoursMondayDownSchool.LessHour2 + " Less Hour 2");

            Console.ReadLine();
        }
    }
}
