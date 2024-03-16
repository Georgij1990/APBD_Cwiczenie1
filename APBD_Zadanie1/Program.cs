// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter name:");
var name = Console.ReadLine();
Console.WriteLine("The name is: " + name);
Console.WriteLine("Enter your age:");
var age = Console.ReadLine();
Console.WriteLine("The age is: " + age);
Console.WriteLine("Where are you studying?");
var university = Console.ReadLine();
Console.WriteLine(name + " has " + age + " years and studies at " + university + " university.");

static double findAverage(int[] ints) {
    return Queryable.Average(ints.AsQueryable());
}
int[] ints = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
var avg = findAverage(ints);
Console.WriteLine(avg);