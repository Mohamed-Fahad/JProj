using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApplication
{
    //custom or user defined exception

    public class AgeNotValid:ApplicationException
    {
        public AgeNotValid(string Message):base(Message)
        {

        }
    }

    class ExceptionHandlingEg
    {

        static void Main()
        {
            try
            {
                int num;
                int div;
                Console.WriteLine("Enter the values for num and div");
                num = Convert.ToInt32(Console.ReadLine());
                div = Convert.ToInt32(Console.ReadLine());

                if(div==0)
                {
                    throw new DivideByZeroException();
                    //throw new exception
                }

                else
                {
                    num = num / div;
                }

                Console.WriteLine(num);

                int[] arr = new int[] { 23, 30, 40 };
                //Console.WriteLine(arr[6]);
                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());
                if(Age<18)
                {
                    throw new AgeNotValid("To vote,age should be greater than 18");

                }

                else
                {
                    Console.WriteLine("Eligible to vote");
                }


            }
            //Error child then parent

             /*
            catch(Exception e)
            {
                Console.WriteLine()
            }
             */

            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                Console.WriteLine( e.Message);
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            /*catch(exception e)  //I dont think this will execute because DivideByZero Exception which is a part of this is already 
             *                    //invoked. Not sure whether this catch block or the one above the dividebyzeroexception block above
             * {
             *   Console.WriteLine(e);
             *  }
            */
            finally
            {
                Console.WriteLine("You are in the finally block");
            }
            
        }
    }
}
