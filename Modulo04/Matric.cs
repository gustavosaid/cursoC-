// ordem crescente...
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorteando...");
// Array.Sort(pallets);

// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }


// reserve do array...
// Console.WriteLine("Reverse...");
// Array.Reverse(pallets);

// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }

//remover conteudo
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2); // comeca no indice 0 e limpando os 2 elementos.

// if (pallets[0] != null){
//     Console.WriteLine($"After: {pallets[0].ToLower()}");
// }

// Console.WriteLine($"Limpando 2... count {pallets.Length}");
// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }



//Redimensionar a matriz para adicionar mais elementos

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2); // limpa os elementos
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6); // acrescentando 
// Console.WriteLine($"Resizing 6 ... count {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }

// //Redimensionar a matriz para remover elementos

// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count{pallets.Length}");

// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }



// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string (valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string [] items = result.Split(',');
// foreach(var item in items){
//     Console.WriteLine(item);
// }


// DESAFIO
// string pangram = "The quick brown fox jumps over the lazy dog";

// string [] message = pandram.Split(' ');

// string newMessage = new string [message.Length];

// for(int i = 0; i < message.Length; i++){
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);



// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string [] items = orderStream.Split(',');

// foreach(var item in items){
//     if(item.Length == 4 ){
//         Console.WriteLine(item);
//     }else{
//         Console.WriteLine(item +"\t- Error");
//     }
// }
