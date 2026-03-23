namespace APBD_TUTORIAL3.Entities;

public class Rental
{
    //properties
    public User User {get; set;}
    public Equipment Equipment {get; set;}
    public DateTime StartDate {get; set;}
    public DateTime DueDate {get; set;}
    public DateTime? ReturnDate {get; set;}
    
    public bool IsActive => ReturnDate == null;
    public bool? WasOnTime => ReturnDate.HasValue ? ReturnDate <= DueDate : (bool?)null;
    public TimeSpan RentedFor => ReturnDate.HasValue ? ReturnDate.Value - StartDate : DateTime.Now - StartDate;
    
    //constructor 
    public Rental(User user, Equipment equipment, DateTime dueDate)
    {
        this.User = user;
        this.Equipment = equipment;
        this.StartDate = DateTime.Now;
        this.DueDate = dueDate;
    }
    
    //methods
    
    public void Return()
    {
        this.ReturnDate = DateTime.Now;
    }

    public void Return(DateTime returnDate)
    {
        this.ReturnDate = returnDate;
    }

    public int CalculateFee()
    {
        if (WasOnTime == false) { return 100;}
        else if (DueDate < DateTime.Now) { return 200; }
        else { return 0; }
    }

    public override string ToString()
    {
        if (IsActive == false)
        {
            return $"User - {User.FirstName} {User.LastName} rented {Equipment.Name} on {StartDate} to {DueDate} \n returned at {ReturnDate}, Fee - {CalculateFee()}";
        }
        else
        {
            return $"User - {User.FirstName} {User.LastName} rented {Equipment.Name} on {StartDate} to {DueDate} \n not returned yet";
        }
    }
        
}