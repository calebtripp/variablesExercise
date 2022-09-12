// See https://aka.ms/new-console-template for more information
//Step 1
string myPupName = "Apollo";
int pupAge = 4;
char y = 'g';
bool lovestreats = true;
double hasDecimal = 14.22;
decimal alsoHasDecimalIsNormallyMoney = 14.23m;
//Step 2
//Console.WriteLine($"my Dog's name is {myPupName}");
Console.WriteLine($"My dog's name is {myPupName},\n" +
    $"He is {pupAge} years old,\n" +
    $"His favorite character is {y},\n" +
    $"His love of treats is {lovestreats},\n" +
    $"His favorite number with a decimal is {hasDecimal},\n" +
    $"His favorite number with a decimal that's normally money is {alsoHasDecimalIsNormallyMoney}.");