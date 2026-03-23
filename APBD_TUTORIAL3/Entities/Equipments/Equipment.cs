namespace APBD_TUTORIAL3.Entities;

public abstract class Equipment: IEquipmentUnavailable
{
    //fields
    private static int _id = 0;
    
    //properties
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }
    public string Description { get; set; }
    
    //constructor
    public Equipment(string name, string description)
    {
        Id = ++_id;
        this.Name = name;
        this.Description = description;
        this.IsAvailable = true;
    }
    
    //methods
    public override string ToString()
    {
        return $" Id - {Id} \n Name - {Name} \n IsAvailable - {IsAvailable} \n Description - {Description} \n";
    }

    public void MarkEquipmentAsUnavailable()
    {
        IsAvailable = false;
    }
}