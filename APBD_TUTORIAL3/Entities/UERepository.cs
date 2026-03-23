namespace APBD_TUTORIAL3.Entities;

public class UERepository
{
    //properties
    public List<User> Users { get; set; } = new List<User>();
    public List<Equipment> Equipments { get; set; } = new List<Equipment>();

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        Equipments.Add(equipment);
    }

    public User GetUser(int id)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            if (Users[i].UserId == id)
            {
                return Users[i];
            }
        }
        throw new KeyNotFoundException("User not found");
    }

    public Equipment GetEquipment(int id)
    {
        for (int i = 0; i < Equipments.Count; i++)
        {
            if (Equipments[i].Id == id)
            {
                return Equipments[i];
            }
        }
        throw new KeyNotFoundException("Equipment not found");
    }
}