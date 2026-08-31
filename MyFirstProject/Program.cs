Student student = new Student();

Console.WriteLine("Enter student name:");
student.Name = Console.ReadLine();

Console.WriteLine("Enter Computer grade:"); 
student.ComputerGrade = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Mathematics grade:");
student.MathematicsGrade = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Science grade:");
student.ScienceGrade = Convert.ToDouble(Console.ReadLine());

double total = student.GetTotal();
double percentage = student.GetPercentage();
string grade = student.GetGrade();

Console.WriteLine("Name: " + student.Name);
Console.WriteLine("Total Marks: " + total);
Console.WriteLine("Percentage: " + percentage);
Console.WriteLine("Grade: " + grade);
