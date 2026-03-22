namespace APBD_TUTORIAL3.Entities;
using APBD_TUTORIAL3.Enums;
public class Student: User
{
    //properties
    public int YearOfStudy {get; set;}
    
    //constructor
    public Student(string identifier, string firstName,
        string lastName, int yearOfStudy) : base(identifier, firstName, lastName, UserType.Student )
    {
        YearOfStudy = yearOfStudy;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() + $" Year of study - {YearOfStudy} \n";
    }
}