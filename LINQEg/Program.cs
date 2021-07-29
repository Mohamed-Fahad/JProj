using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace LINQEg
{
    /*Query syntax
     * 
     * from <range variable> in ienumerable<T> or iquerable<T> Collection
     * standard query operators 
     * select or group by operator <result formation>
     */

    class Student
    {

        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        internal Student(int Rollno,string Name,string City,string Gender)
        {
            this.Rollno -= Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] Book = { "Tamil", "English", "Maths", "Science" };
            //LINQ : Query syntax
            //display all books

            var result = from s in Book
                         select s;

            foreach(var bname in result)
            {
                Console.WriteLine(bname);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Display the book name that contains 'a'");

            //display the name the contains 'a'

            var r = from bookname in Book
                    where bookname.Contains("a")
                    select bookname;

            foreach(var bname in r)
            {
                Console.WriteLine(bname);
            }

            int[] Marks = { 50, 74, 65, 85, 84 };

            Console.WriteLine("Minimum marks : {0}",Marks.Min());
            Console.WriteLine("Maximum marks : {0}",Marks.Max());

            //marks btw 70 and 100

            var r1 = from m in Marks
                     where m > 70 && m <= 100
                     select m;

            foreach(var marks in r1)
            {
                Console.WriteLine(marks);
            }


            //Using method syntax

            var r2 = Marks.Where(stumark => stumark > 70 && stumark <= 100);
            //dont forget to display

            //Count th enumber of marks btw 70 and 100

            var r2 = (from m in Marks
                      where m > 70 && m <= 100
                      select m).Count();

            Console.WriteLine("The number of marks btw 70 and 100 is {0}",r2);

            //-------
            //LINQ and Objects

            List<Student> stu = new List<Student>()
            {
                new Student(1001,"John","Pune","Male"),
                new Student(1002,"Jonas","Kolkata","Male"),
                new Student(1003,"Alexa","Delhi","Female"),
                new Student(1004,"Siri","Chennai","Female")
            };   //this is an alternatuve method for initiazlizing the constructors 

            //display max roll no of student
            //METHOD SYNTAX
            var student = stu.Max(stud => stud.Rollno);

            //dont forget to display the above thing btw


            //Display name and city where city is chennai

            //Deferred Execution - only when the for loop is exec the query is processed
            var stucity = from s in stu
                          where s.City.Equals("Chennai")
                          select new { s.Name, s.City }; //since we're aloccating only for name and city, only they can be 
                                                        //accessed in the foreach loop below


            //Immediate execution is when we convert the query directly into a list using list method in the same line 
            //at the end of query



            Console.WriteLine("Display name and city where city is chennai");

            foreach(var st in stucity)
            {
                Console.WriteLine(st.Name + " " + st.City);
            }

            //Display the name and roll no of student using MTHOD SYNTAX

            var m3 = stu.Select(s => new { stuname = s.Name, sturoll = s.Rollno });

            foreach(var x in m3)
            {
                Console.WriteLine(x.stuname+ " "+ x.sturoll);
            }


            //order by
            //order by gender
            Console.WriteLine("Order the student info based on gender");

            var stugen = from s in stu
                         orderby s.Gender, s.Name
                         select s;

            foreach (var s in stugen)
            {
                Console.WriteLine(s.Name + "  " + s.City+ " " + s.Gender);
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("No of males and females");

            var stumf = from s in stu
                        group s by s.Gender;

            foreach(var s in stumf)
            {
                Console.WriteLine(s.Key + " " + s.Count()); //key value indicates m or f and the count returns the count for each
            }

        }
    }
}
