using system;
{
    class House
    {
        protected int area;
        protected Door door;

        public house (int area)
        {
            area = new area;
            door = new Door;

        }
        public int area
        {
            get {return area;}
            set {area = value;}
        }
        Public Door door;
        {
            get {return door;}
            set {door = value;}
        }

        Public void ShowData()
        {
            Console.WriteLine("I am a house my area is 200m.");
        }
    }
    
    class Door
    {
        protected string color;

        public door ()
        {
            color = "Brown";
        }
        public door (string color)
        {
            color = new color;
        }

        public string color
        {
            get {return color;}
            set {color = value;}
        }
        Public Door door;
        {
            get {return door;}
            set {door = value;}
        }

        Public void ShowData ()
        {
            Console.WriteLine("I am a door, my color is brown.");
        }
    }

    class SmallApartment
    {
        public SmallApartment ()
        : area(50)
        {

        }
        Public void ShowData ()
        {
            Console.WriteLine("I am an apartment, my area is 50m.");
        }
    }
    
    class Person
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "name";
            house = new House(100);
        }
        public Person(string name, House house)
        {
            name = new name;
            house = new house;
        }

        public string name
        {
            get {return name;}
            set {name = value;}
        }
        public House house
        {
            get {return house;}
            set {house = value;}
        }

        Public void ShowData()
        {
            Console.WriteLine("My name is name.");
            house.ShowData(100);
            house.door.ShowData(100);
        }
    }
    
    class Apartment
    {
        public void Main()
        {
            SmallApartment mySmallApartment = new SmallApartment();
            Person myPerson = new Person();

            myperson.Name = "Name";
            myperson.House = mysmallApartment;
            myperson.ShowData();

            Console.ReadLine();
        }
    }
}