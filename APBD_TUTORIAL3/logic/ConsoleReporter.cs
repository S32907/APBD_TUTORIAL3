namespace APBD_TUTORIAL3.Entities;

public class ConsoleReporter: IConsoleReporter

{
    
    //properties
    public RentalService RentalService { get; set;}

    public ConsoleReporter(RentalService rentalService)
    {
        this.RentalService = rentalService;
    }
    
    public void DisplayEquipment()
    {
        Console.WriteLine("List of equipments:");
        List<Equipment> equipments = RentalService.GetEquipments();
        foreach (Equipment equipment in equipments)
        {
            Console.WriteLine(equipment);
        }
    }

    public void DisplayAvailableEquipment()
    {
        Console.WriteLine("List of available equipments:");
        List<Equipment> equipments = RentalService.GetAvailableEquipments();
        foreach (Equipment equipment in equipments)
        {
            Console.WriteLine(equipment);
        }
    }

    public void DisplayActiveRentalsByUSer(int userId)
    {   
        Console.WriteLine("List of active rental for user with ID : " + userId);
        List<Rental> rentals = RentalService.GetActiveRentalsByUser(userId);
        foreach (Rental rental in rentals)
        {
            Console.WriteLine(rental);
        }
    }

    public void DisplayOverDueRentals()
    {
        Console.WriteLine("List of over due rentals:");
        List<Rental> rentals = RentalService.GetOverDueRentals();
        foreach (Rental rental in rentals)
        {
            Console.WriteLine(rental);
        }
    }

    public void GenerateShortSummary()
    {
        Console.WriteLine("Short summary:");
        Console.WriteLine("Number of users: " + RentalService.UERepository.Users.Count );
        Console.WriteLine("Number of equipments: " + RentalService.UERepository.Equipments.Count );
        Console.WriteLine("Number of available equipments: " + RentalService.GetAvailableEquipments().Count );
        Console.WriteLine("Number of over due rentals: " + RentalService.GetOverDueRentals().Count );
        Console.WriteLine();
    }
}