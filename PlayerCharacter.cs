using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace myFantasyGameChallenge
{
    public class PlayerCharacter
    {
        public int CharacterId { get; set; }

        public int PlayerLevel { get; set; }
        public string PlayerName { get; set; }
        public string CharacterClass { get; set; }
        public decimal Level { get; set; } = 1;
        private decimal Health { get; set; } 
        public decimal playerdeath { get; set; } = 0;

        public int PlayAtk { get; set; } = 20;

      

        //CREATE PRIVATE method 2X: done
        private decimal CalculateDamage()
        {
            int IncommingDammage = PlayAtk * 2;
            return IncommingDammage;
        }

        public decimal DispalyHealth()
        {
            //assisgn a value to health while keeping it private and without create creating a property: pending
            Quest heroQuestHealth = new Quest();
            heroQuestHealth.healthvalue = (int)Health;
            return Health;
        }

       



        public void PlayerStats()
        {
            Console.WriteLine($"Name: {PlayerName}, Class: {CharacterClass}, Level: {Level}, Health: {Health}");
        }

        public void Attack() 
        { 
        
        }


        public decimal GetHealth(decimal damage) 
        {
            var currenthealth =  Health - damage;
            return currenthealth;
        }

        /// <summary>
        /// This gets A list of characters                done
        /// </summary>                                    done
        /// <returns></returns>                           done
        /// give characters a level and do same for quest done
        public List<PlayerCharacter> CreateCharacters() {
            var playercharaters = new List<PlayerCharacter>();
            playercharaters.Add(new PlayerCharacter {  PlayerLevel = 1,  CharacterId = 1, PlayerName = "Midoriya", CharacterClass = "Knight" });
            playercharaters.Add(new PlayerCharacter {  PlayerLevel = 1,  CharacterId = 2,  PlayerName = "Iida", CharacterClass = "Paladin" });
            playercharaters.Add(new PlayerCharacter {  PlayerLevel = 1,  CharacterId = 3,  PlayerName = "Bakugo", CharacterClass = "Mage" });
            playercharaters.Add(new PlayerCharacter {  PlayerLevel = 1,  CharacterId = 4,  PlayerName = "shigaraki", CharacterClass = "eRogue" });
            return playercharaters;
        }
        
    }



}