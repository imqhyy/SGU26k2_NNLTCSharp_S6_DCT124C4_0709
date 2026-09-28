using System;

namespace bai1_3;

public class Program
{
    public static void Main(string[] args)
    {
        Person A = new Person();
        A.Input();
        A.Output();
        Console.WriteLine("Con song? " + A.IsLiving());
    }
}

public class Person
{
    private string id;
    private string name;
    private int yob;
    private int yod;

    private static int sl = 0;   
    //Default Constructor
    public Person()
    {
        id = "";
        name = "";
        yob = 0;
        yod = 0;
    }

    //Copy Constructor
    public Person(Person A)
    {
        this.id = A.id;
        this.name = A.name;
        this.yob = A.yob;
        this.yod = A.yod;
    }

    public void Input()
    {
        id = (sl + 1).ToString();
        sl++;
        Console.Write("Nhap ho va ten: ");
        name = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        int.TryParse(Console.ReadLine(), out yob);
        Console.Write("Nhap nam mat (0 neu con song): ");
        int.TryParse(Console.ReadLine(), out yod);
    }

    public void Output()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ho va ten: " + name);
        Console.WriteLine("Nam sinh: " + yob);

        //Nếu yod > 0 thì trả về yod, nếu yod = 0 thì trả về còn sống
        Console.WriteLine("Nam mat: " + ((yod > 0) ? yod : "con song"));
    }

    public bool IsLiving()
    {
        if(yod > 0) return false;
        else return true;
    }
    
}