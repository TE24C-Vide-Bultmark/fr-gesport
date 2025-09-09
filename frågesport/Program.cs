Console.WriteLine("välkommen till min frågesport! du kommer att få en fråga samt 2 eller fler alternativ, svara med bokstaven som korresponderar det du tror är rätt svar, varje fråga är värd dubbelt så mycket poäng som den förra, lycka till!. ");
Console.WriteLine("fråga 1, 10 poäng: hur många bits finns i en byte?");
Console.WriteLine("a) tio");
Console.WriteLine("b) tolv");
Console.WriteLine("c) fem");
Console.WriteLine("d) åtta");

string svar = Console.ReadLine();
int poäng = 0;

if (svar == "d")
{
    poäng += 10;
    Console.WriteLine($"korrekt! du har nu {poäng} poäng");
}
else
{
    Console.WriteLine($"Aj då, rätt svar vad d) åtta! du har nu {poäng} poäng");
}


Console.WriteLine("fråga 2, 20 poäng: vilken klass gick Vide i årskurs 1?");
Console.WriteLine("a) TE24C");
Console.WriteLine("b) TE24A");
Console.WriteLine("c) TE24D");
Console.WriteLine("d) TE24B");

svar = Console.ReadLine();

if (svar == "a")
{
    poäng += 20;
    Console.WriteLine($"korrekt! du har nu {poäng} poäng");
}
else
{
    Console.WriteLine($"Aj då, rätt svar vad a) TE24C! du har nu {poäng} poäng");
}


Console.WriteLine("fråga 3, 40 poäng: när fyller vide år?");
Console.WriteLine("a) 7 januari");
Console.WriteLine("b) 14 juni");
Console.WriteLine("c) 17 oktober");
Console.WriteLine("d) 24 december");

svar = Console.ReadLine();

if (svar == "c")
{
    poäng += 40;
    Console.WriteLine($"korrekt! du fick {poäng} poäng");
}
else
{
    Console.WriteLine($"Aj då, rätt svar var c) 17 oktober! du har nu {poäng} poäng");
}
if (poäng == 80)
{
    Console.WriteLine("gratulerar du fick alla rätt!");
}
else if (poäng >= 30)
{
    Console.WriteLine("bra jobbat!");
}
else if (poäng > 0)
{
    Console.WriteLine("bättre lycka nästa gång");
}
else
{
    Console.WriteLine("du suger. L");
}

Console.ReadLine();