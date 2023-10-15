using System.Runtime.CompilerServices;

public class User
{
    private string _name;
    private string _surname;
    private string _studentID;
    private Grade _grade;

    // เรียก Constructor หรือ ก็คือ การกำหนดค่าเริ่มต้นให้กับ วัตถุ
    public User(string name, string surname, string studentID, Grade grade)
    {
        _name = name;
        _surname = surname;
        _studentID = studentID;
        _grade = grade;
    }

    public string PrintUserInformation()
    {
        return "User information is: " + _name + " " + _surname +
        " " + _studentID + " " + "Score is: " + _grade.ShowScore()
        + " " + "Grade is: " + _grade.ShowGrade();
    }
}