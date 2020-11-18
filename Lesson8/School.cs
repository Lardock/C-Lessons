using System;

namespace Lesson8
{
    class School
    {
        public string SchoolName;
    }

    class Schedule : School 
    {
        public string Lesson1;
        public string Lesson2;
        public string Lesson3;
    }

    class Hours:Schedule
    {
        public int LessHour1;
        public int LessHour2;
        public int LessHour3;
    }
}
