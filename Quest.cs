using System;

namespace myFantasyGameChallenge
{
    public class Quest
    {
        public int QuestId { get; set; }

        public int QuestLevel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }

        public int healthvalue { get; set; } = 100;

    


        public void QuestOption1()
        {
            Console.WriteLine("Battle 1: FIGHT!!!");
            Bosses bos1 = new Bosses();
            PlayerCharacter player = new PlayerCharacter();

            bos1.Firstboss();

            Console.WriteLine("The menacing " + bos1.BossName1 + ", Lord of the Void");

            string choice;

            Console.WriteLine("What will you do, " + player.PlayerName + "? Fight, or surrender?");
            choice = Console.ReadLine();

            if (choice.Equals("fight", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Choose your attack: melee or magic");
                string userInput = Console.ReadLine();

                int melee = 10;
                int magic = 12;

                if (userInput.Equals("melee", StringComparison.OrdinalIgnoreCase))
                {
                    Random rnd = new Random();
                    int attackMultiplier = rnd.Next(1, 11);
                    int meleeAttack = melee * attackMultiplier;

                    Console.WriteLine("Player attack: " + meleeAttack);
                    Console.WriteLine("Boss health: " + bos1.BossHealth);

                    decimal phase1bossHealth = bos1.BossHealth - meleeAttack;

                    Console.WriteLine("Dormamu takes " + meleeAttack + " damage");
                    Console.WriteLine("Boss health after attack: " + phase1bossHealth);

                    if (phase1bossHealth > 0)
                    {
                        Console.WriteLine("Dormamu has not fallen!...Dormamu Attacks");

                        Random rnd2 = new Random();
                        int bossattackmultiplier = rnd2.Next(5, 10);

                        decimal BossPhase2Attack = bos1.BossAttack * bossattackmultiplier;
                        decimal herohealth = healthvalue - BossPhase2Attack;
                        PlayerCharacter health = new PlayerCharacter();
                        Console.WriteLine("Hero health after attack: " + health.DispalyHealth());

                        if (herohealth <= player.playerdeath)
                        {
                            Console.WriteLine("Game over");
                            Environment.Exit(0);
                        }
                        else
                        {
                            SuddenDeath(bos1, player);
                        }
                    }
                }
                else if (userInput.Equals("magic", StringComparison.OrdinalIgnoreCase))
                {
                    Random rnd = new Random();
                    int attackMultiplier = rnd.Next(1, 11);
                    int magicAttack = magic * attackMultiplier;

                    Console.WriteLine("Player attack: " + magicAttack);
                    Console.WriteLine("Boss health: " + bos1.BossHealth);

                    decimal phase1bossHealth = bos1.BossHealth - magicAttack;
                    bos1.BossHealth = phase1bossHealth;

                    Console.WriteLine("Dormamu takes " + magicAttack + " damage");
                    Console.WriteLine("Boss health after attack: " + phase1bossHealth);

                    if (phase1bossHealth > 0)
                    {
                        Console.WriteLine("Dormamu has not fallen!...Dormamu Attacks");

                        Random rnd2 = new Random();
                        int bossattackmultiplier = rnd2.Next(5, 10);

                        decimal BossPhase2Attack = bos1.BossAttack * bossattackmultiplier;
                        decimal herohealth = healthvalue - BossPhase2Attack;
                        Console.WriteLine("Hero health after attack: " + herohealth);

                        if (herohealth <= player.playerdeath)
                        {
                            Console.WriteLine("Game over");
                            Environment.Exit(0);
                        }
                        else
                        {
                            SuddenDeath(bos1, player);
                        }
                    }
                }
            }
        }

        private void SuddenDeath(Bosses bos1, PlayerCharacter player)
        {
            int suddenDeathBoss = 0;
            int suddenDeathHero = 0;

            Console.WriteLine("Sudden Death!!! BEGIN!");

            //while (bos1.BossHealth > 0 && player.Health > 0)
            //{
            //    ++suddenDeathBoss;
            //    ++suddenDeathHero;

            //    if (suddenDeathBoss >= bos1.bossdeath && suddenDeathHero > player.playerdeath)
            //    {
            //        Console.WriteLine("Sudden Death");
            //        break;
            //    }

            //    if (suddenDeathBoss > suddenDeathHero)
            //    {
            //        Console.WriteLine(bos1.BossName1 + " wins!... Game Over");
            //        Environment.Exit(0);
            //    }
            //}
        }
    }

}