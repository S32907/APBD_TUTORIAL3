namespace APBD_TUTORIAL3.Entities;

public class Camera: Equipment
{
    
    //properties
    public int Resolution { get; set; }
    public double SensorSize { get; set; }
    
    //constructor
    public Camera(string name, string description, int resolution, double sensorSize) : base(name, description)
    {
        this.Resolution = resolution;
        this.SensorSize = sensorSize;
    }
    
    //methods
    public override string ToString()
    {
        return base.ToString() + $" Resolution - {Resolution} \n SensorSize - {SensorSize} \n";
    }
}