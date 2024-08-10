class Vehicle
{
    public string Brand { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vehicle is moving");
    }
}