
class Car
{
    private string model;
    private int speed;

    public Car(string model)
    {
        this.model = model;
        this.speed = 0;
    }

    public void Accelerate()
    {
        speed += 10;
    }

    public void ShowSpeed()
    {
        Console.WriteLine(speed);
    }
}