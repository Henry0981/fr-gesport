Console.WriteLine(" hej välkomen till din frågesport vad är ditt namn?");

int hp = 0;

string name = Console.ReadLine();

Console.WriteLine($" du börjar spelet med {hp} poäng!");
Console.WriteLine($" Ok, första frågan {name}! i vilket land ligger den spanska trappan?");

Console.WriteLine(" a= frankrike, b=spanien, c= italien");

string val = "";
while (val != "a" && val != "b" && val != "c")
{
    val = Console.ReadLine();
    if (val != "a" && val != "b" && val != "c")
    {
        Console.WriteLine("dumpucko, välj mellan a, b eller c");
    }
}
if (val == "c")
{
    Console.WriteLine(" wow du hade rätt!");
    hp++;
    Console.WriteLine($" du har nu {hp} poäng ");
}
else
{
    Console.WriteLine("ops detta verkade ju vara rätt svar men den spanska trappan ligger faktiskt i centrala rom. Därför är rätt svar Italien.");
    hp--;
    Console.WriteLine($" Du har nu {hp} poäng");
}

Console.WriteLine("nästa fråga, vilka färger har den palstinska flaggan?");
Console.WriteLine(" a=röd,svart,vit och grön. b= rött och vitt. C= blått, vitt och gult");

string flagga = "";

while (flagga != "a" && flagga != "b" && flagga != "c")
{
    flagga = Console.ReadLine();

    if (flagga != "a" && flagga != "b" && flagga != "c")
    {
        Console.WriteLine("dumpucko, välj mellan a, b eller c");
    }
}

if (flagga == "a")

{
    Console.WriteLine("wow du hade rätt!");
    hp++;
    Console.WriteLine($"du har nu {hp} poäng");
}

else
{
    Console.WriteLine("nu blev det fel");
    hp--;
    Console.WriteLine($"du har nu {hp} poäng");
}

Console.WriteLine("sista frågan! cirka hur många människor bor i island?");
Console.WriteLine("a=366 425, b= 1000 000, c= 450 566");

string island = "";

while (island != "a" && island != "b" && island != "c")
{
    island = Console.ReadLine();

    if (island != "a" && island != "b" && island != "c")
    {
        Console.WriteLine("dumpucko, välj mellan a, b eller c");
    }
}

if (island == "a")

{
    Console.WriteLine("wow du hade rätt!");
    hp++;
    Console.WriteLine($"du har nu {hp} poäng!");

}
else 

{
 Console.WriteLine("nu blev det fel");
    hp--;
   Console.WriteLine($"du har nu {hp} poäng");
}


if (hp == 3)

{
    Console.WriteLine("wow du hade alla rätt! du är verkligen smart!!");
}

else if (hp == 1)

{
    Console.WriteLine("wow du lyckades få två rätt! bra jobbat.");
}

else if (hp == -3)

{
    Console.WriteLine("wow du fick alla fel.");

}

else if (hp== -1 )
{
    Console.WriteLine("du fick två fel, bättre lycka nästa gång!");
}

Console.ReadLine();

































// string num = "55" + "78"; 
// Console.WriteLine(num);

// string name  = "henry";

// bool s = name == "henry"; 

// bool s = 6 > 3; 

// if (s)

// {
//     Console.WriteLine("yes");
// }

// int potionHealing = 10;
// int curseDamage = 10; 
// int hp = 50 + 50; 

// hp = 200 + potionHealing; 

// hp += potionHealing;

// hp++;
// hp--;

// hp -= curseDamage;

// Console.WriteLine(hp);

// if (hp > 0)
// {
//     Console.WriteLine("jag lever!");
// }

// Console.ReadLine();
