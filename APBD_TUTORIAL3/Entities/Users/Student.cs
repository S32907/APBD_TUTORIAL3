namespace APBD_TUTORIAL3.Entities;
using APBD_TUTORIAL3.Enums;
public class Student: User
{
    //properties
    public int YearOfStudy {get; set;}
    public static int MaxNumberOfEquipment { get; set; } = 2;
    
    //constructor
    public Student(int userId, string firstName,
        string lastName, int yearOfStudy) : base(userId, firstName, lastName, UserType.Student )
    {
        YearOfStudy = yearOfStudy;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() + $" Year of study - {YearOfStudy} \n";
    }
}