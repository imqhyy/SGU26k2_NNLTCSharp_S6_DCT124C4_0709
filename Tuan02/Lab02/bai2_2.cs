using System;
using System.Collections;


namespace bai2_2;

public class Program
{
    public static void Main(String[] args)
    {
        PersonList P = new PersonList();
        P.Input();
        P.Output();

        Console.WriteLine("-------------------------");
        Console.WriteLine("Danh sach nhung nguoi con song");
        PersonList living = P.LivingPeople();
        living.Output();
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

public class PersonList : IEnumerable
{
    private ArrayList persons;
    public int count => persons.Count;

    public PersonList()
    {
        persons = new ArrayList();
    }

    public PersonList(PersonList A)
    {
        this.persons = A.persons;
    }

    public void Input()
    {
        int n;
        Console.Write("Nhap so luong nguoi can them: ");
        n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap nguoi thu " + (i + 1));
            Person A = new Person();
            A.Input();
            persons.Add(A);
            Console.WriteLine();
        }
    }

    public void Output()
    {
        foreach (Person i in persons)
        {
            i.Output();
            Console.WriteLine();
        }
    }

    public void Add(Person P)
    {
        persons.Add(P);
    }

    //override phương thức này để sử dụng được foreach
    public IEnumerator GetEnumerator()
    {
        return persons.GetEnumerator();
    }

    public PersonList LivingPeople()
    {
        PersonList P = new PersonList();
        foreach (Person i in persons)
        {
            if(i.IsLiving())
            {
                P.Add(i);
            }
        }
        return P;
    }
}