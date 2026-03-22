namespace APBD_TUTORIAL3.Entities;
using APBD_TUTORIAL3.Enums;
    
public abstract class User
{
    //properties
    public string Identifier {get; set;}
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public UserType Type { get; set; }
    
    //constructor
    public User(string identifier, string firstName,
        string lastName, UserType type)
    {
        Identifier = identifier;
        FirstName = firstName;
        LastName = lastName;
        Type = type;
    }
    
    //methods
    public override string ToString()
    {
        return $" Identifier - {Identifier} \n Name and surname - {FirstName} {LastName} \n Type - {Type} \n";
    }
}