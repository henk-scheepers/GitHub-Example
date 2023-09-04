using GitHub_Example;
using static System.Console;

public class Program{

    static void Main(){
        HogwartsStudent[] hogwartsStudents = {

            new HogwartsStudentRebecca(), 
            new HogwartsStudentNJ(),
            new HogwartStudentCait(),       
        };

        foreach(HogwartsStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}