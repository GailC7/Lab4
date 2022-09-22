using Lab4;

string root = FileRoot.Root;
string csvFile = root + Path.DirectorySeparatorChar + "data.csv";
string psvFile = root + Path.DirectorySeparatorChar + "data.psv";

List<Person> people = new List<Person>();

using (StreamReader sr = new StreamReader(csvFile))
{
    while(!sr.EndOfStream)
    {
        //reads and splits
        string line = sr.ReadLine();
        var data = line.Split(",");

        //gets data from csv file and splits and assigns it to value
        string fName = data[0];
        string lName = data[1];
        string streetAddress = data[2];
        string city = data[3];
        string state = data[4];
        string postalCode = data[5];

        //creates Address object for Person object
        Address address = new Address(streetAddress, city, state, postalCode);

        //creates Person object and adds to list
        people.Add(new Person(fName, lName, address));
    }
}

people.Sort();

Console.WriteLine("------------PSV FILE------------");
using(var sw = new StreamWriter(psvFile))
{


}
