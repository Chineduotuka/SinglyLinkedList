using MyGpaCalculator.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGpaCalculator.Core
{
    public class calculation
    {
        private ArrayList courseCode;
        private ArrayList grade = new ArrayList();
        private ArrayList courseUnit;
        private ArrayList score;
        private ArrayList gradeUnit = new ArrayList();
        private ArrayList weightPoint = new ArrayList();
        private ArrayList remark = new ArrayList();
        private int numberOfCourses;
        public calculation(ArrayList courseCode, ArrayList courseUnit, ArrayList score, int course_number)
        {
            this.courseCode = courseCode;
            this.courseUnit = courseUnit;
            this.score = score;
            this.numberOfCourses = course_number;

        }
        public void calcu()
        {
            var TableHearder = new PrintTable("CourseCode", "CourseUnit", "Score", "Grade", "GradeUnit", "WeightPoint", "Remark");
            for (int j = 0; j < numberOfCourses; j++)
            {
                //loop throught to add grade and remark to equivalent index, ineach array list.
                double k = Convert.ToDouble(score[j]);
                if (k >= 70 && k <= 100)
                {
                    grade.Add("A");
                    remark.Add("Excellent");
                    gradeUnit.Add("5");
                }
                else if (k >= 60)
                {
                    grade.Add("B");
                    remark.Add("Very Good");
                    gradeUnit.Add("4");
                }
                else if (k >= 50)
                {
                    grade.Add("C");
                    remark.Add("Good");
                    gradeUnit.Add("3");

                }
                else if (k >= 45)
                {
                    grade.Add("D");
                    remark.Add("Fair");
                    gradeUnit.Add("2");
                }
                else if (k >= 40)
                {
                    grade.Add("E");
                    remark.Add("Pass");
                    gradeUnit.Add("1");
                }
                else
                {
                    grade.Add("F");
                    remark.Add("Fail");
                    gradeUnit.Add("0");
                }
            }
            //loop through, convert to int, calculate for weight point, convert to string and add to arraylist at equivalent index.
            for (int z = 0; z < numberOfCourses; z++)
            {
                int gradeUnit_toint = Convert.ToInt32(gradeUnit[z]);
                int courseUnit_toint = Convert.ToInt32(courseUnit[z]);
                weightPoint.Add((gradeUnit_toint * courseUnit_toint).ToString());
            }

            //loop through , call the row checker/add methode 
                for (int i = 0; i < numberOfCourses; i++)
            {
                TableHearder.RowAdd_Check_add(courseCode[i], courseUnit[i], score[i], grade[i], gradeUnit[i], weightPoint[i], remark[i]);
            }
            TableHearder.TablePrinter();

            int WeightTotal = 0;
            int GradeUnitTotal = 0;
            int CourseUnitTotal = 0;

            for (int i = 0; i < numberOfCourses; i++)
            {
                WeightTotal += Convert.ToInt32(weightPoint[i]);
                CourseUnitTotal += Convert.ToInt32(courseUnit[i]);
                //check if grade is F and 
                if (grade[i] != "F")
                {
                    GradeUnitTotal += Convert.ToInt32(courseUnit[i]);
                }
                else
                {
                    GradeUnitTotal += 0;
                }
            }
            // calculating GPA and convertuing to double 
            double GPA = ((double)WeightTotal / CourseUnitTotal);

            string gpaRound = Math.Round(GPA, 2).ToString("0.00");

            Console.WriteLine($"Total COURSE UNIT Registerd is: {CourseUnitTotal}");
            Console.WriteLine($"Total COURSE UNIT Passed is: {GradeUnitTotal}");
            Console.WriteLine($"Total WEIGHT POINT is: {WeightTotal}");
            Console.WriteLine($"Your GPA Is = {gpaRound}");

            if(GPA > 4.5)
            {
                Console.WriteLine("");
            }
        }
    }
}
