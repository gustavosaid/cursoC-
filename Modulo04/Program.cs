// Console.WriteLine($"sbyte {sbyte.MinValue} ate {sbyte.MaxValue}");
// Console.WriteLine($"short {short.MinValue} até {short.MaxValue}");
// Console.WriteLine($"int {int.MinValue} até {int.MaxValue}");
// Console.WriteLine($"long {long.MinValue} até {long.MaxValue}");



// Console.WriteLine("");



// Console.WriteLine($"byte {byte.MinValue} ate {byte.MaxValue}");
// Console.WriteLine($"ushort {ushort.MinValue} ate {ushort.MaxValue}");
// Console.WriteLine($"uint {uint.MinValue} ate {uint.MaxValue}");
// Console.WriteLine($"ulong {ulong.MinValue} ate {ulong.MaxValue}");



// Console.WriteLine("");

// Console.WriteLine($"float {float.MinValue} ate {float.MaxValue}");
// Console.WriteLine($"double {double.MinValue} ate {double.MaxValue}");
// Console.WriteLine($"decimal {decimal.MinValue} ate {decimal.MaxValue}");
 



// Console.WriteLine("Conversão de [Int] para [Decimal]");
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal {myDecimal}");




// Console.WriteLine("Conversão de [Decimal] para [Int]");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int)myDecimal;
// Console.WriteLine($"int {myInt}");





// Console.WriteLine("Conversão de [Decimal] para [Float]");
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");




// Console.WriteLine("Conversão de [Int] para [String]");
// int num1 = 5;
// int num2 = 7;
// string message = num1.ToString() + num2.ToString();
// Console.WriteLine(message);


// Console.WriteLine("Conversão de [String] para [Int] usando o auxiliar PARSE");
// string num1 = "5";
// string num2 = "5";

// int sum = int.Parse(num1) + int.Parse(num2);
// Console.WriteLine(sum);



// Console.WriteLine("Conversão de [String] para [Int] usando o auxiliar CONVERT");
// string num1 = "5";
// string num2 = "5";

// int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
// Console.WriteLine(result);


// int valor1 = (int)1.5m;
// Console.WriteLine(valor1);

// int valor2 = Convert.ToInt32(1.5m);
// Console.WriteLine(valor2);

// string [] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values){
//     decimal number; 
//     if(decimal.TryParse(value, out number)){
//         total += number;
//     }else{
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;


// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


// decimal result2 = value2 / (decimal) value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");