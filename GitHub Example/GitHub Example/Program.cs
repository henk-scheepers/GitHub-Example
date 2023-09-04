using GitHub_Example;
using static System.Console;

public class Program{

    static void Main(){
        HogwartsStudent[] hogwartsStudents = {

            new HogwartsStudentRebecca(), 
            new HogwartsStudentNJ(),
            new HogwartStudentCait(),       
            new HogwartStudentLirisa(),
        };

        foreach(HogwartsStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}