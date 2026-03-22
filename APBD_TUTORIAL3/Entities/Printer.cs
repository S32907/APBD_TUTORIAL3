namespace APBD_TUTORIAL3.Entities;

public class Printer: Equipment
{
    
    //properties 
    public int PagesPerMinute { get; set; }
    public bool IsColour { get; set; }
    
    //constructor 
    public Printer(string name, string description, int pagesPerMinute, bool isColour) : base(name, description)
    {
        this.PagesPerMinute = pagesPerMinute;
        this.IsColour = isColour;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() + $" Speed of Printing per minute - {PagesPerMinute} \n Is colour printer - {IsColour} \n" ;
    }
}