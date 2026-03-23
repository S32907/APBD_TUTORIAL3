namespace APBD_TUTORIAL3.Entities;
using APBD_TUTORIAL3.Enums;
public class Teacher : User
{
    
    //field
    private double _popularityRating;
    //properties
    public double PopularityRating 
    {
        get {return _popularityRating;}
        set 
        {
            if (value < 0 || value > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "PopularityRating must be in range from 0 to 5.");
            }
            _popularityRating = value;
        }
    }
    
    //constructor
    public Teacher(string identifier, string firstName,
        string lastName, double popularityRating) : base(identifier, firstName, lastName, UserType.Teacher)
    {
        PopularityRating = popularityRating;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() +  $" Popularity rating - {PopularityRating} \n";
    }
    
}