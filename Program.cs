int dice = 0, dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0; int i;
string fix; string copyFix;
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;

void RollDice()
{
    if (!fixed1)
    {
        dice1 = Random.Shared.Next(1, 7);
    }
    if (!fixed2)
    {
        dice2 = Random.Shared.Next(1, 7);
    }
    if (!fixed3)
    {
        dice3 = Random.Shared.Next(1, 7);
    }
    if (!fixed4)
    {
        dice4 = Random.Shared.Next(1, 7);
    }
    if (!fixed5)
    {
        dice5 = Random.Shared.Next(1, 7);
    }
}
void PrintDice()
{
    Console.WriteLine($"{dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
}
void FixDice()
{
    fixed1 = false; fixed2 = false; fixed3 = false; fixed4 = false; fixed5 = false;
    do
    {
        Console.WriteLine("Which number do you want to fix?");
        fix = Console.ReadLine()!;
        switch (fix)
        {
            case "1":
                fixed1 = !fixed1;
                break;
            case "2":
                fixed1 = !fixed1;
                break;
            case "3":
                fixed1 = !fixed1;
                break;
            case "4":
                fixed1 = !fixed1;
                break;
            case "5":
                fixed1 = !fixed1;
                break;
        }
    } while (fix != "r");
}
for (i = 0; i <= 3; i++)
{
    if (!fixed1 || !fixed2 || !fixed3 || !fixed4 || !fixed5 )
    {
        RollDice();
        PrintDice();
        if (i <= 2)
        {
            FixDice();
        }
    }
    else
    {
        return;
    }
}