namespace APBD_TUTORIAL3.Entities;

public interface IRentalService
{
    void RentEquipment(int userId, int equipmentId, DateTime DueDate);
    void ReturnEquipment(int userId, int equipmentId,DateTime dueDate, DateTime? returnDate = null);
    List<Rental> GetOverDueRentals();
    List<Rental> GetActiveRentalsByUser(int userId);
}