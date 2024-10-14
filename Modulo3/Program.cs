// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string valor = "a";
// Console.WriteLine(valor == "a");

// string valor1 = " a";
// string valor2 = "A ";

// Console.WriteLine(valor1.Trim().ToLower() == valor2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string valor = "a";
// Console.WriteLine(valor != "a");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));