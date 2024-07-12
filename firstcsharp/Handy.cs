using Microsoft.VisualBasic;

namespace Programm1{
    class Handy {
        public string Name {get; set;}
        public int Year {get; set;}

        public void makeHandy(string name, int year){
            Name = name;
            Year = year;
        }

    }
}