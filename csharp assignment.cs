// See https://aka.ms/new-console-template for more information
Console.WriteLine("                       Welcome");

int dateofbirth  = 2001;
int currentyear = 2022;
int age = currentyear - dateofbirth;

Console.WriteLine(age);

for (age = 0; age < 5; age++) {

    Console.WriteLine(age);

}

Console.WriteLine("What is your name?");
String name = Console.ReadLine();

Console.WriteLine("What is your age?");
int age1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hell0 " + name);
Console.WriteLine("you are " + age1 + " years old.");