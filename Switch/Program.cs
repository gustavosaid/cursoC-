// int level = 105;
// string nome = "John Smitch";

// string titulo = "";

// switch (level){
//     case 100:
//     case 200:
//     titulo = "junior Associate";
//     break;

//     case 300:
//     titulo = "Manager";
//     break;

//     case 400:
//     titulo = "Senior manager";
//     break;

//     deafault:
//     titulo = "Associate";
//     break;
// }

// Console.WriteLine($"{nome},{titulo}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shitrt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        type = "Black";
        break;
    case "MN":
        type = "Maroon";
        break;
    default:
        type = "White";
        break;
}

switch (product[2])
{
    case "S":
        type = "Small";
        break;
    case "M":
        type = "Medium";
        break;
    case "L":
        type = "Large";
        break;
    default:
        type = "one Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");