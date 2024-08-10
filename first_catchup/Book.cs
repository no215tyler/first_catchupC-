class Book
{
    public string Title { get; set; }
    private int pages;

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
            {
                pages = value;
            }
            else
            {
                Console.WriteLine("整数にしてください");
            }
        }
    }
}