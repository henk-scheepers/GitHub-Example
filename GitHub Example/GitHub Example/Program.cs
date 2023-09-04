using static System.Console;

public class Program{

    static void Main(){
        HogwartStudent[] hogwartsStudents = {
            //new HogwartsStudentHenk(100, 20, House.Slytherin),
        };

        foreach(HogwartStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}