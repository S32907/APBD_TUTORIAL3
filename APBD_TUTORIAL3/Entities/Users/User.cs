namespace APBD_TUTORIAL3.Entities;
using APBD_TUTORIAL3.Enums;
    
public abstract class User
{
    //properties
    public int UserId {get; set;}
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public UserType Type { get; set; }
    
    //constructor
    public User(int userId, string firstName,
        string lastName, UserType type)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Type = type;
    }
    
    //methods
    public override string ToString()
    {
        return $" Identifier - {UserId} \n Name and surname - {FirstName} {LastName} \n Type - {Type} \n";
    }
}