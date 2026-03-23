namespace APBD_TUTORIAL3.Entities;

public interface IEquipmentService
{
    void AddEquipment(Equipment equipment);
    List<Equipment> GetEquipments();
    List<Equipment> GetAvailableEquipments();
}