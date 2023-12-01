using System.IO.Enumeration;

string fileName1 = "input.txt";
string fileName2 = "input2.txt";

Console.WriteLine(fileName1);
Console.WriteLine(PartTwo(fileName2));


int PartOne(string filename) {

    if (File.Exists(filename))
    {
        string[] text = File.ReadAllLines(filename);
        var sum = 0;
        foreach (string line in text)
        {
            char firstNumber = line.FirstOrDefault(number => char.IsNumber(number));
            char lastNumber = line.LastOrDefault(number => char.IsNumber(number));
            int number = Int32.Parse(firstNumber.ToString() + lastNumber.ToString());
            sum += number;
        }
        return sum;

    }
    else
        return -1;

}

int PartTwo(string fileName)
{
    Dictionary<string, string> numbers = new Dictionary<string, string>()
    {
        {"nine", "n9e" },
        {"seven", "s7n" },
        {"eight", "e8t"},
        {"two", "t2o"},
        {"one", "o1e" },
        {"three","t3e" },
        {"four", "f4r" },
        {"five", "f5e" },
        {"six" , "s6x" },    
    };

    var sum = 0;
    if (File.Exists(fileName)) { 
        string[] text = File.ReadAllLines(fileName);
        for(int i =  0; i < text.Length; i++)
        {

            foreach(KeyValuePair<string, string> n in numbers)
            {
                if (text[i].Contains(n.Key))
                    text[i] = text[i].Replace(n.Key, n.Value);
            }
            char firstNumber = text[i].FirstOrDefault(number => char.IsNumber(number));
            char lastNumber = text[i].LastOrDefault(number => char.IsNumber(number));
            int number = Int32.Parse(firstNumber.ToString() + lastNumber.ToString());
            sum += number;
        }  
    }
    return sum;
}
