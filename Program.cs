using System;

namespace Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for what grade they expect
            Console.WriteLine("Please enter an interger value of the grade you expect");
            /*
             Use the try catch block to validate user input.
            */
            try
            {
                
                int grade;
                grade = int.Parse(Console.ReadLine());
                /*
                 Using a IF statement to test the users input. 
                 Inside the IF statement there is switch conditional statement 
                 that displays depending on interger value. 
                */
                if ((grade > 90) && (grade < 100))
                    
                    Console.WriteLine("A");
                    Console.WriteLine("Press any key to exit the program...");
                    grade =int.Parse(Console.ReadLine());
                    /*
                      Execute the conditoinal switch statemtns to output
                      different messages dependid on the interger value.
                    */

                    switch(grade)
                    {
                        case 80: 
                            Console.WriteLine("B");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case 70:
                            Console.WriteLine("C");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case 60:
                            Console.WriteLine("D");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case 0:
                            Console.WriteLine("F");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        
                    }//end of switch
                
            }
            catch
            {
                Console.WriteLine("Please use interger data type for your grades next time...");
                Console.WriteLine("---OR---");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }//end of catch
        }//end of Main
    }//end of class
}//end of namespace
      