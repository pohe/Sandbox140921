using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Sandbox
{
    public class Student
    {
        // Instance fields - gemmer tilstanden i objektet
        private string _name;
        private string _id;
        private int _teamsNumber;
        private int _semester;

        //properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Id
        {
            get { return _id; }
            
        }

        public int TeamsNumber
        {
            get { return _teamsNumber; }
        }

        public int Semester
        {
            get { return _semester;}
            set { _semester = value; }
        }

        // constructor
        public Student(string name, string id, int teamsNumber, int semester) // i parentes er en parameterliste
        {
            _name = name;
            _id = id;
            _teamsNumber = teamsNumber;
            _semester = semester;
        }

        public Student(string name, string id) // i parentes er en parameterliste
        {
            _name = name;
            _id = id;
            _teamsNumber = 0;
            _semester = 0;
        }

        // methods
        public void PrintAllInfo()
        {
            Console.WriteLine($"Navn {_name};  ID {_id};  TeamsNumber { _teamsNumber}; Semester {_semester}");
        }
    }
}
