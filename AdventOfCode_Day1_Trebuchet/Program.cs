using System.IO.Enumeration;

string fileName1 = "input.txt";
string fileName2 = "input2.txt";

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

Console.WriteLine(PartOne(fileName1));
Console.WriteLine(PartTwo(fileName2));

int PartOne(string filename) {
    
    if (File.Exists(filename))
    {
        string[] text = File.ReadAllLines(filename);
        return CalculateSum(1, text);
    } 
    else
        return -1;
}

int PartTwo(string fileName)
{ 
    if (File.Exists(fileName)) { 
        string[] text = File.ReadAllLines(fileName);
        return CalculateSum(2, text); 
    }
    else
        return -1;
}

int CalculateSum(int part, string[] linesOfNumbers)
{
    var sum = 0;
    for (int i = 0; i < linesOfNumbers.Length; i++)
    {
        if(part == 2) { 
            foreach (KeyValuePair<string, string> n in numbers)
            {
                if (linesOfNumbers[i].Contains(n.Key))
                    linesOfNumbers[i] = linesOfNumbers[i].Replace(n.Key, n.Value);
            }
        }
        char firstNumber = linesOfNumbers[i].FirstOrDefault(number => char.IsNumber(number));
        char lastNumber = linesOfNumbers[i].LastOrDefault(number => char.IsNumber(number));
        int number = Int32.Parse(firstNumber.ToString() + lastNumber.ToString());
        sum += number;
    }
    return sum;
}