Console.WriteLine("Welcome to Grand Circus' Room Generator!");
Console.Write("What is the length of the room? ");
double length = double.Parse(Console.ReadLine());
Console.Write("What is the width of the room? ");
double width = double.Parse(Console.ReadLine());
double perimeter = (width * 2) + (length * 2);
Console.WriteLine("The perimeter of the room is " + perimeter);
double area = width * length;
Console.WriteLine("The area of the room is " + area);
if (area <= 250)
{
    Console.WriteLine("The room is small sized.");
}
else if (area <= 649)
    Console.WriteLine("The room is medium sized.");
else
{
    Console.WriteLine("The room is large sized.");
}
Console.WriteLine("What is the height of the roomn?");
double height = double.Parse(Console.ReadLine());
double volume = width * length * height;
Console.WriteLine("The volume of the room is " + volume);
double surfacearea = 2 * ((width * length) + (height * length) + (height * width));
Console.WriteLine("The surface area of the room is " + surfacearea);