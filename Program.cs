using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myFantasyGameChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3) if player level is not >= to quest level then display "you do not meet the minimun requirements" 


            //Player Will choose a character from the list of Characters
            string CharacterChoice;
            List<PlayerCharacter> Character = GetPlayerCharacters();
            foreach (var character in GetPlayerCharacters())
            {
                Console.WriteLine($" Id : {character.CharacterId} Character :{character.PlayerName} characterclass : {character.CharacterClass}  characterlevel {character.PlayerLevel}");
            }
            Console.WriteLine("Choose your character");
            CharacterChoice = Console.ReadLine();

            PlayerCharacter chosenCharacter = null;
            if (int.TryParse(CharacterChoice, out int characterChoice))
            {
                chosenCharacter = Character.First(Ch => Ch.CharacterId == characterChoice);
                Console.WriteLine($"you have chosen the character {chosenCharacter.PlayerName}");
            }

            // Player will choose a quest from the list of Quests
            string Choice;
            List<Quest> quests = GetQuests();
            foreach (var quest in quests)
            {
                Console.WriteLine($"ID : {quest.QuestId} Quest :{quest.Name} Level : {quest.Level}");
            }
            Console.WriteLine("CHOOSE YOUR QUEST");
            Choice = Console.ReadLine();

            Quest chosenQuest = null;
            if (int.TryParse(Choice, out int questChoice))
            {
                chosenQuest = quests.First(q => q.QuestId == questChoice);
                Console.WriteLine($"You have chosen quest {chosenQuest.Name}");
            }

            // Create a validation to check and compare the character level and the quest level to determine if they may proceed with the quest.
            if (chosenCharacter != null && chosenQuest != null)
            {
                if (chosenCharacter.PlayerLevel >= chosenQuest.Level)
                {
                    Console.WriteLine("You are eligible for this quest.");
                    Quest selectedQuest = new Quest();
                    selectedQuest.QuestOption1();

                }
                else
                {
                    Console.WriteLine("You do not meet the minimum requirements.");
                }
            }




            var playerCharacter = new PlayerCharacter();
            playerCharacter.PlayAtk = 30;
            
            Console.WriteLine("Press Enter To Exit ...");
            Console.ReadLine();
        }

        public static List<Quest> GetQuests()
        {
            var quests = new List<Quest>();

            quests.Add(new Quest { QuestLevel = 1, QuestId = 1, Name = "Defeat Void", Level = 1 });
            quests.Add(new Quest { QuestLevel = 2, QuestId = 2, Name = "Defeat Goblins", Level = 2 });
            quests.Add(new Quest { QuestLevel = 3, QuestId = 3, Name = "Defeat Orc", Level = 3 });

            return quests;
        }

        public static List<PlayerCharacter> GetPlayerCharacters()
        {
            var playerCharacter = new PlayerCharacter();
            return playerCharacter.CreateCharacters();
        }
    }



}