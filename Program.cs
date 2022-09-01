using System.Diagnostics;
namespace SwordDamageConsoleAppEncapsulated
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {

            SwordDamage swordDamage = new SwordDamage(RollDice());
            while (true)
            {


                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey(false).KeyChar;
                char[] acceptableChar = { '0', '1', '2', '3' };
                if (!acceptableChar.Contains(key))
                {
                    return;
                }
                else
                {
                    swordDamage.Roll = RollDice();
                    swordDamage.Magic = 1M;
                    swordDamage.Flaming = 0;
                    Debug.WriteLine(swordDamage.Roll);
                    if ((key == '1' || key == '3'))
                    {
                        swordDamage.Magic = 1.75M;
                    }
                    if ((key == '2' || key == '3'))
                    {
                        swordDamage.Flaming = 2;
                    }
                }
                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
            }

        }
        static int RollDice()
        {
            return (random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));

        }
    }
}