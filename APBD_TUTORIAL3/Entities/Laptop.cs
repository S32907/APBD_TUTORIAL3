namespace APBD_TUTORIAL3.Entities;

public class Laptop: Equipment
{
    
    //properties
    public int Ram { get; set;}
    public string GraphicsCard {get; set;}
    
    //constructor 
    public Laptop(string name, string description, int ram, string graphicsCard) : base(name, description)
    {
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() + $" Ram - {Ram} \n GraphicsCard - {GraphicsCard} \n";
    }
}