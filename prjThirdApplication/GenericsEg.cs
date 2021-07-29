using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApplication
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        internal Person(int id,string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }


    class GenericsEg
    {
        static void ListEg()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1, "Strawberry");
            fruits.RemoveAt(3);
            //fruits.Add(10) not possible because type safe

            List<string> veg = new List<string>();
            veg.Add("carrot");
            veg.Add("Beetroot");
            veg.AddRange(fruits); //adding one list to another list

            foreach(var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }

            Console.WriteLine("Vegetables");

            foreach(var list in veg)
            {
                Console.WriteLine("Vegetables: {0}", list);
            }

            

        }

        //Key value pair

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "OS");
            dt.Add(3, "Python");

            foreach(KeyValuePair<int,string> k in dt)
            {
                Console.WriteLine(k.Key + " : " + k.Value);
            }

        }

        static void StackEg()
        {
            //Push,Pop,Peek,Contains,Clear methods

            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(65);
            st.Push(82);

            foreach(var stack in st)
            {
                Console.WriteLine(stack);
            }

            st.Pop();
            Console.WriteLine("After 1 pop");

            foreach (var stack in st)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("Peek : {0}",st.Peek());
        }

        static void SortedListEg()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Ruby");
            sl.Add(2, "Cplusplus");
            sl.Add(3, "Perl");
            
            foreach(KeyValuePair<int,string> s in sl)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }

        }

        static void QueueEg()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(20);
            queue.Enqueue(55);
            queue.Enqueue(14);
            queue.Enqueue(32);

            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }

            queue.Dequeue();
            Console.WriteLine("After 1 dequeue");

            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }

           
        }

        static void Main()
        {
            ListEg();
            Console.WriteLine("Person Details");
            Console.WriteLine("--------------");

            List<Person> person = new List<Person>();
            person.Add(new Person(1, "Felix", "Chennai"));
            person.Add(new Person(2, "Tex", "Hyderabad"));

            foreach(Person p in person) //var can also be used in  place of 'Person'
            {
                Console.WriteLine("ID:{0} Name:{1} City:{2}", p.id, p.name, p.city);
            }
            Console.WriteLine("--------------");
            DictionaryEg();
            Console.WriteLine("--------------");
            StackEg();
            Console.WriteLine("--------------");
            SortedListEg();
            Console.WriteLine("--------------");
            QueueEg();


        }
    }
}
