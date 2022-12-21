Console.Clear();

int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0; int i = 0, x = 0, y = 0, save = 0;
string fix; 
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;

void RollDice()
{
    if (!fixed1) {dice1 = Random.Shared.Next(1, 7);}
    if (!fixed2) {dice2 = Random.Shared.Next(1, 7);}
    if (!fixed3) {dice3 = Random.Shared.Next(1, 7);}
    if (!fixed4) {dice4 = Random.Shared.Next(1, 7);}
    if (!fixed5) {dice5 = Random.Shared.Next(1, 7);}
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
                fixed2 = !fixed2;
                break;
            case "3":
                fixed3 = !fixed3;
                break;
            case "4":
                fixed4 = !fixed4;
                break;
            case "5":
                fixed5 = !fixed5;
                break;
        }
    } while (fix != "r");
}
void SortDice()
{
    for (x = 10; x > 0; x--) 
{
    for (y = 0; y < 9; y++)
    {
        if (dice1 > dice2) {save = dice1; dice1 = dice2; dice2 = save;}
        if (dice2 > dice3) {save = dice2; dice2 = dice3; dice3 = save;}
        if (dice3 > dice4) {save = dice3; dice3 = dice4; dice4 = save;}
        if (dice4 > dice5) {save = dice4; dice4 = dice5; dice5 = save;}
    }  
}
}
for (i = 0; i <= 3; i++)
{
    if (!fixed1 || !fixed2 || !fixed3 || !fixed4 || !fixed5 )
    {
        RollDice();
        SortDice();
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