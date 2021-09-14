using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            string n = "Poul";
            Student firstStudent;
            firstStudent = new Student(n, "POHE", 123, 1);
            Student secondStudent = new Student("Peter", "PELE", 124, 2);

            firstStudent = secondStudent;
            secondStudent.Name = "Kurt";
            Console.WriteLine(firstStudent.Name);

            //secondStudent.Name = "Ole";

            Student thirdStudent = new Student("Susanne", "SUS");

            firstStudent.PrintAllInfo();
            secondStudent.PrintAllInfo();
            thirdStudent.PrintAllInfo();


            Calculator myCalc = new Calculator();

            int t1 = 10;
            int t2 = 17;
            int t3 = 20; 

            int result =myCalc.Add( myCalc.Add(t1, t2), t3);
           
            //int result2 = myCalc.Add(result, t3);

            // The LAST line of code should be ABOVE this line
        }
    }
}