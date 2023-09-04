using GitHub_Example;
using static System.Console;

public class Program{

    static void Main(){
        HogwartsStudent[] hogwartsStudents = {

            //new HogwartsStudentHenk(100, 20, House.Slytherin),
            new HogwartStudentLirisa(),
            new HogwartStudentCait(),

        };

        foreach(HogwartsStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}