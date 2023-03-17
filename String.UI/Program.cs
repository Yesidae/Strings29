using String.Logic;

var myStrings = new Strings29[]
{
    new Strings29("*==+===+==*"),
    new Strings29("*=+="),
    new Strings29("*====="),
};

foreach (var myString in myStrings)
{
    Console.WriteLine(myString.Bridge());
}