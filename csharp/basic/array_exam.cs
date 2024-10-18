


public class GradeAverage {
    public static string[] codes = {
        "F", "D-", "D","C-", "C", "C+", "B-", "B", "B+", "A-","A","A+"
    };

    public static string getCode (decimal grade) {
        if(grade >= 97 ) {
            return "A+";
        }
        else if(grade >= 93) {
            return "A";
        }
        else if(grade >= 90) {
            return "A-";
        }
        else if(grade >= 87) {
            return "B+";
        }
        else if(grade >= 83) {
            return "B";
        }
        else if(grade >= 80) {
            return "B-";
        }
        else if(grade >= 77) {
            return "C+";
        }
        else if(grade >= 73) {
            return "C";
        }
        else if(grade >= 70) {
            return "C-";
        }
        else if(grade >= 67) {
            return "D+";
        }
        else if(grade >= 63) {
            return "D";
        }
        else if(grade >= 60) {
            return "D-";
        }else {
            return "F";
        }
            
    }

}

public class StudentGradingApp: GradeAverage {
    private decimal grade;
    public StudentGradingApp () {
        this.initConsole();
    }

    public void initConsole() {
        try
        {
            Console.Write("Welcome student! \nPlease enter your name: ");
            string? name = Console.ReadLine();

            // bool validInput = false;
            // do
            // {
            //     Console.Write("Please enter your grade: ");
            //     validInput = Decimal.TryParse(Console.ReadLine(), out decimal result);
            //     grade = result;
            // } while (!validInput);
            grade = getGrade();
            Console.WriteLine($"Evaluating grade for: {name}");
            Console.WriteLine($"Getting student code grade remarks....");
            Console.WriteLine($"Your average grade is: {GradeAverage.getCode(grade)}");

        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public decimal getGrade() {

        decimal grade = 0;

        bool validInput = false;
        do
        {
            Console.Write("Please enter your grade: ");
            validInput = Decimal.TryParse(Console.ReadLine(), out decimal result);
            grade = result;
        } while (!validInput);
        return grade;
    }
}