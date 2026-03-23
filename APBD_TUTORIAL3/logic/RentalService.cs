using APBD_TUTORIAL3.Enums;

namespace APBD_TUTORIAL3.Entities;

public class RentalService: IEquipmentService, IUserService, IRentalService
{
    //properties
    public List<Rental> Rentals { get; set; } = new List<Rental>();
    public UERepository UERepository {get; set;}

    public RentalService(UERepository UERepository)
    {
        this.UERepository = UERepository;
    }
    
    public Rental GetRental(int userId, int equipmentId)
    {
        foreach (var rental in Rentals)
        {
            if (rental.User.UserId == userId && rental.Equipment.Id == equipmentId)
            {
                return rental;
            }
        }
        throw new Exception("No rental found");
    }
    
    //IEquipmentService
    public void AddEquipment(Equipment equipment)
    {
        UERepository.AddEquipment(equipment);
    }
    
    public List<Equipment> GetEquipments()
    {
        return UERepository.Equipments;
    }

    public List<Equipment> GetAvailableEquipments()
    {
        List<Equipment> result = new List<Equipment>();
        foreach (var equipment in UERepository.Equipments)
        {
            if (equipment.IsAvailable)
            {
                result.Add(equipment);
            }
        }
        return result;
    }
    
    //IUserService
    public void AddUser(User user)
    {
        UERepository.AddUser(user);
    }
    
    //IRentalService
    public List<Rental> GetActiveRentalsByUser(int userId)
    {
        List<Rental> rentals = new List<Rental>();
        foreach (var rental in Rentals)
        {
            if (rental.IsActive && rental.User.UserId == userId)
            {
                rentals.Add(rental);
            }
        }
        return rentals;
    }
    
    public void RentEquipment(int userId, int equipmentId, DateTime DueDate)
    {   
        User user = UERepository.GetUser(userId);
        if (user.Type == UserType.Student && GetActiveRentalsByUser(userId).Count >= 2)
        {
            Console.WriteLine($"Student {user.FirstName} {user.LastName} cannot rent more than 2 equipments");
            return;
        }
        else if (user.Type == UserType.Teacher && GetActiveRentalsByUser(userId).Count >= 5)
        {
            Console.WriteLine($"Teacher {user.FirstName} {user.LastName} cannot rent more than 5 equipments");
            return;
        }
        Equipment equipment = UERepository.GetEquipment(equipmentId);
        if (!equipment.IsAvailable)
        {
            Console.WriteLine($"User {user.LastName} {user.LastName} with id {user.UserId} can not rent equipment {equipment.Name} with id {equipment.Id} because it is not available");
            return;
        }
        Rental rental = new Rental(user, equipment, DueDate);
        Rentals.Add(rental);
        equipment.IsAvailable = false;
    }

    public void ReturnEquipment(int userId, int equipmentId, DateTime? returnDate = null)
    {
        Rental rental = GetRental(userId, equipmentId);
        if (returnDate != null)
        {   
            rental.Return(returnDate.Value);
            Console.WriteLine(rental);
            rental.Equipment.IsAvailable = true;
        }
        else
        {   
            
            rental.Return();
            Console.WriteLine(rental);
            rental.Equipment.IsAvailable = true;
        }
    }
    

    public List<Rental> GetOverDueRentals()
    {
        List<Rental> rentals = new List<Rental>();
        foreach (var rental in Rentals)
        {
            if (rental.DueDate < DateTime.Now && rental.IsActive)
            {
                rentals.Add(rental);
            }
        }
        return rentals;
    }
    
    public void MarkEquipmentAsUnavailable(int equipmentId)
    {
        UERepository.GetEquipment(equipmentId).MarkEquipmentAsUnavailable();
    }
}