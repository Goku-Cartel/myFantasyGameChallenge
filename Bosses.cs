namespace myFantasyGameChallenge
{
    public class Bosses
    {
        public string BossName1 { get; set; }
        public string BossName2 { get; set; }
        public string BossName3 { get; set; }

        public decimal BossHealth { get; set; }
        public decimal BossHealth2 { get; set; }
        public decimal BossHealth3 { get; set; }

        public decimal BossAttack { get; set; }
        public decimal BossAttack2 { get; set; }
        public decimal BossAttack3 { get; set; }

        public decimal bossdeath { get; set; } = 0;

        public void Firstboss()
        {
            BossName1 = "Dormamu";
            BossHealth = 250;
            BossAttack = 50;
        }

        public void Secondboss()
        {
            BossName2 = "Voldamort";
            BossHealth2 = 150;
            BossAttack2 = 120;
        }

        public void ThirdBoss()
        {
            BossName3 = "Gauss the Silencer";
            BossHealth3 = 370;
            BossAttack3 = 350;
        }
    }

}