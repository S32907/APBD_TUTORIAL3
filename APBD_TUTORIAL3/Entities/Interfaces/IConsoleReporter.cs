namespace APBD_TUTORIAL3.Entities;

public interface IConsoleReporter
{
    void DisplayEquipment();
    void DisplayAvailableEquipment();
    void DisplayActiveRentalsByUSer(int userId);
    void DisplayOverDueRentals();
    void GenerateShortSummary();
}