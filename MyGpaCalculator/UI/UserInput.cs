using MyGpaCalculator.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGpaCalculator.UI
{
    public static class UserInput
    {
        public static void inputake()
        {
            Console.Write("input the required COURSE NUMBER: ");
            string courseNum_input = Console.ReadLine();
            int course_number;

            //check if the inputed number of course is a Number, if not, throw an error message
            while (!int.TryParse(courseNum_input, out course_number))
            {
                Console.Clear();
                Console.WriteLine("NUMBER of COURSE can only be positive numbers");
                Console.WriteLine();
                Console.WriteLine("Try again, This time input a variable Data type of type Number.");

                Console.Write("input the required COURSE NUMBER: ");
                courseNum_input = Console.ReadLine();
                Console.Clear();
            }
            
         
             //create an empty Arraylist to store values of each input,
                ArrayList courseCode = new ArrayList();
                ArrayList course_Unit = new ArrayList();
                ArrayList score = new ArrayList();


                for (int i = 0; i < course_number; i++)
                {
                    Console.Write($"what is the COURSE CODE{i + 1}: ");
                    courseCode.Add(Console.ReadLine());

                    Console.Write($"what is the COURSE UNIT{i + 1}: ");
                    string courseUnit = Console.ReadLine();
                    int courseUnit_int;

                while (!int.TryParse(courseUnit, out courseUnit_int))
                {
                    //Console.Clear();
                    Console.WriteLine("COURSE UNITS can only be positive numbers");
                    Console.WriteLine();
                    Console.WriteLine("Try again, This time input a positive number.");

                    Console.Write($"what is the COURSE UNIT{i + 1}: ");
                    courseUnit = Console.ReadLine();
                    //Console.Clear();
                }                
                    course_Unit.Add(courseUnit);

                    Console.Write($"what is the SCORE{i + 1}: ");
                    string score_str = Console.ReadLine();
                    int score_int;
                while (!int.TryParse(score_str, out score_int))
                {
                    Console.Clear();
                    Console.WriteLine("SCORES can only be positive numbers");
                    Console.WriteLine();
                    Console.WriteLine("Try again, This time input a positive number Number.");

                    Console.Write($"what is the SCORE{i + 1}: ");
                    score_str = Console.ReadLine();
                    Console.Clear();
                }
                    score.Add(score_int);

                Console.WriteLine();
                }


                var gradeCalculation = new calculation(courseCode, course_Unit, score, course_number);
                Console.Clear();

               
                gradeCalculation.calcu();

            
        }
    }
}
