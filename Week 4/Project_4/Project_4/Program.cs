string[] DaysOfWeek =
{
    "Monday","Tuesday",
    "Wednesday","Thursday",
    "Friday","Saturday",
    "Sunday"
};
foreach (string Day in DaysOfWeek)
{
    Console.WriteLine(Day);
}
Console.WriteLine(DaysOfWeek[1]);
DaysOfWeek[1] = "Mardi";
Console.WriteLine(DaysOfWeek[1]);

Console.WriteLine("Choose a number from 1 to 7: ");
String input = Console.ReadLine();
int choice = int.Parse(input);

choice -= 1;
Console.WriteLine("You chose " + DaysOfWeek[choice]);





/*string[] MonthsOfTheYear =
{
    "January","February",
    "March","April",
    "May","June",
    "July","August",
    "September","October",
    "November","December"
};
foreach (string Month in MonthsOfTheYear)
{
    Console.WriteLine(Month);
}*/



/*Console.WriteLine(MonthsOfTheYear[7]);
Console.WriteLine(MonthsOfTheYear.GetValue(9));

for (int i = 0; i < MonthsOfTheYear.Length; i++)
{
    Console.WriteLine(MonthsOfTheYear[i]);
}*/



/*List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
Console.WriteLine(numbers[3]);

for (int index = 0; index < numbers.Count; index++)
{
    int number = numbers[index];
    if (number == 4)
    {
        numbers.RemoveAt(index);
    }
}

Console.WriteLine(numbers[3]);*/


/*List<string> colours = new List<string>();
colours.Add("red");
colours.Add("green");
colours.Add("blue");
colours.Add("yellow");
colours.Add("pink");

for (int index = 0; index < colours.Count; index++)
{
    string colour = colours[index];
    if (colour == "red")
        {
        colours.RemoveAt(index);
        }
}*/



/*foreach (var colour in colours)
{
    Console.WriteLine(colour);
}*/



/*for (int index = 0; index < colours.Count; index++)
{
    Console.WriteLine(colours[index]);
}*/



/* new list */
/*List<string> colours = new List<string>();
colours.Add("red");
colours.Add("green");
colours.Add("blue");
colours.Add("yellow");
Console.WriteLine(colours[3]);*/
