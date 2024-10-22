// string first = "Hello";
// string second = "World";

// Console.WriteLine($"{first} {second}");
// Console.WriteLine($"{second} {second}");

// decimal preco = 123.45m;
// int desconto = 50;

// Console.WriteLine($"Preco {preco:C} (Desconto {desconto:C})"); //numero como moeda R$10,00


// decimal numGrande = 123456.78912m;
// Console.WriteLine($"Numero grande:{numGrande:N}"); //N torna os números mais legíveis

// decimal tax = .123456m;
// Console.WriteLine($"Tax Rate{tax:P2}"); //P para formatar percentuais

// //Combinar abordagens de formatação 
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// Console.WriteLine(yourDiscount);

// Explorar a interpolação de cadeia de caracteres
// int number = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal percentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Number:{number}");
// Console.WriteLine($" Product {productShares} Shares");//precisao de milesimo, se for preciso arrendonda
// Console.WriteLine($"     Sub Total:{subtotal:C}");// moeda
// Console.WriteLine($"         Tax Percentage:{percentage:P2}");// percentual
// Console.WriteLine($"     Total pedido:{total:C}");//moeda


// string first = "Hello";
// string second = "World";

// string result = string.Format("{0} {1}",first,second);
// Console.WriteLine(result);


// string input = "Pad This";
// Console.WriteLine(input.PadLeft(12,'-')); // adiciona espaços em branco ao lado esquerdo da cadeia de caracteres 
// Console.WriteLine(input.PadRight(12,'-'));// adiciona espaços em branco ao lado direito da cadeia de caracteres 


// string paymentId = "769C";
// string name = "Mr. Stephen Ortega";
// string valor = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += name.PadRight(24);
// formattedLine += valor.PadLeft(10);

// Console.WriteLine(formattedLine);


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");


string comparisonMessage = "";


comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);



Console.WriteLine(comparisonMessage);
