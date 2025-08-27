// Run firsst C# program
Console.WriteLine("Hello, World!");

// Declare variable.
//The first line declares a variable, aFriend, and assigns it a value, "Bill". The second line prints the name.
string aFriend = "Bill";
Console.WriteLine(aFriend);
// Store another value in the variable
aFriend = "Maria";
Console.WriteLine(aFriend);
// String interpolation - $"This is call String intrapolation, joining Strings value in curly braces"
Console.WriteLine($"Hello {aFriend}");

// Workin with String
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// Print variable property - Lenght
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


// Variable property - Trim
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Variable property - Replace method takes two arguement
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// Variable property - ToUpper and ToLower methods
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// The other part of a search and replace operation is to find text in a string. 
//You can use the Contains method for searching. 
//It tells you if a string contains a substring inside it. 
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
//It tells you if a string StartsWith/Endswith a substring inside it. 
Console.WriteLine(songLyrics.StartsWith("you"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));

// Fråga användaren om deras namn och hälsa på dem
Console.WriteLine("Hej på dig!");
Console.Write("Vad heter du? ");
string name = Console.ReadLine();
Console.WriteLine($"Hej {name}!");