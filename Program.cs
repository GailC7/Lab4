using Lab4;

string root = FileRoot.Root;
string csvFile = root + Path.DirectorySeparatorChar + "data.csv";
string psvFile = root + Path.DirectorySeparatorChar + "data.psv";

List<Person> people = new List<Person>();

using (StreamReader sr = new StreamReader(csvFile))
{
    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var data = line.Split(",");

        string fName = data[0];
        string lName = data[1]; 
        var street


    }
}
