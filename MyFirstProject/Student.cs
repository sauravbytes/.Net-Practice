public class Student
{
    public string Name;
    public double ComputerGrade;
    public double MathematicsGrade;
    public double ScienceGrade;

    public double GetTotal()
    {
        return ComputerGrade + MathematicsGrade + ScienceGrade;
    }

    public double GetPercentage()
    {
        return GetTotal() / 3;
    }

    public string GetGrade()
    {
        double percentage = GetPercentage();

        if (percentage >= 90)
            return "A";
        else if (percentage >= 80)
            return "B";
        else if (percentage >= 70)
            return "C";
        else if (percentage >= 60)
            return "D";
        else
            return "F";
    }
}