using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class ProgramUI
    {
      
        public void Run()
        {
            //starting game
            RunMenu();
        }
        private void RunMenu()
        {
            Console.WriteLine("MadLibs - The Game");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine($"Nice to meet you, {playerName}.");
                Console.WriteLine("Use the following menu to make your selection:\n" +
                    "1. Play \n" +
                    "2. Credits \n" +
                    "3. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        StorySelector(playerName);
                        break;
                    case "2":
                        MadLibsCredits();
                        break;
                    case "3":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine($"I'm sorry, {playerName}, that doesn't appear to be a valid option.\n" +
                            $"Press any key to try again!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void StorySelector(string playerName)
        {
            Console.Clear();
            Console.WriteLine("Use the following menu to make your selection:\n" +
                "1. Story One \n" +
                "2. Story Two \n" +
                "3. Main Menu");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    StoryOne(playerName);
                    break;
                case "2":
                    StoryTwo(playerName);
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine($"I'm sorry, {playerName}, that doesn't appear to be a valid option.\n" +
                        $"Press any key to try again!");
                    Console.ReadKey();
                    StorySelector(playerName);
                    break;
            }
        }
        public void StoryOne(string playerName)
        {
            Console.Clear();
            Console.WriteLine($"Alright, {playerName}, let's begin!");
            Console.WriteLine("Give us a noun.");
            string nounOne = Console.ReadLine().ToLower();
            Console.WriteLine("Awesome! Now write it as a plural.");
            string nounOnePlural = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Thank you! Now we need another noun.");
            string nounTwo = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Just one more noun to go!");
            string nounThree = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Wonderful! We need three adjectives to make this work.");
            Console.WriteLine("Adjective 1:");
            string adjOne = Console.ReadLine().ToLower();
            Console.WriteLine("Adjective 2:");
            string adjTwo = Console.ReadLine().ToLower();
            Console.WriteLine("Adjective 3:");
            string adjThree = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Just two more words to complete your story!");
            Console.WriteLine("You need a adverb past participle (ending in -ed).");
            string advpp = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Finally, now you just need a verb past particple (ending in -ed).");
            string verbpp = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Thank you for giving those words. Press any key to continue and see your story!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Once there was a monkey. He lived on a {nounOne} tree. One day, a {nounTwo} came near the banks of the river where the tree was located. The monkey felt bad for the tired and hungry {nounTwo} and gave him some {nounOnePlural}. Soon, they became {adjOne} friends. Every day the monkey would give the {nounTwo} {nounOnePlural}. One day it so happened that the monkey gave him some extra {nounOnePlural} to take home for his wife. When the {nounTwo} took the {nounOnePlural} to his wife, she {advpp} it. But she was a very {adjTwo} {nounTwo}. She told her husband that she wanted the monkey's heart which will be much sweeter than the {nounOnePlural}. So the next day the {nounTwo} went to the monkey and said his wife had invited him home for dinner. Happily, the monkey agreed.\n" +
                $"But when they got to the middle of the river, the {adjThree} {nounTwo} told him the truth, that his wife wants to heat the monkey's heart for {nounThree}. The monkey was smart, so he quickly told him that he had left his heart in the {nounOne} tree, so he had to go get it. Happily, the {nounTwo} agreed. But when they got to the banks, the monkey {verbpp} to the highest branch and saved himself. He then told the {nounTwo} that he would never trust him again. The foolish {nounTwo} was sad, and he had to go home to his evil wife without the monkey's heart.");
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadKey();
        }
        public void StoryTwo(string playerName)
        {
            Console.Clear();
            Console.WriteLine($"Alright, {playerName}, let's begin!");
            Console.WriteLine("Give us a adjective.");
            string adjOne = Console.ReadLine().ToLower();
            Console.WriteLine("Awesome! Now another aadjective.");
            string adjTwo = Console.ReadLine().ToLower();
            Console.WriteLine("Just one more adjective to go!");
            string adjThree = Console.ReadLine().ToLower();            
            Console.Clear();
            Console.WriteLine("Thank you! Now we need a noun.");
            string nounOne = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("And another noun!");
            string nounTwo = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Just one more noun to go!");
            string nounThree = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Wonderful! We need four plural nouns");
            Console.WriteLine("Just two more words to complete your story!");
            Console.WriteLine("You need a four verb (ending in -ing)."); 
            Console.WriteLine("plural noun 1:");
            string pluralNounOne = Console.ReadLine().ToLower();
            Console.WriteLine("plural noun 2:");
            string pluralNounTwo = Console.ReadLine().ToLower();
            Console.WriteLine("plural noun 3:");
            string pluralNounThree = Console.ReadLine().ToLower();
            Console.WriteLine("plural noun 4:");
            string pluralNounFour = Console.ReadLine().ToLower();
            Console.Clear();
            string verbINGOne = Console.ReadLine().ToLower();
            Console.WriteLine(" verb ING");
            string verbINGTwo = Console.ReadLine().ToLower();
            Console.WriteLine(" verb ING");
            string verbINGThree = Console.ReadLine().ToLower();
            Console.WriteLine(" verb ING");
            string verbINGFour = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine(" a place");
            string aPlace = Console.ReadLine().ToLower();
            Console.WriteLine(" a body part");
            string partOfBody = Console.ReadLine().ToLower();
            Console.WriteLine(" game name");
            string game = Console.ReadLine().ToLower();
            Console.WriteLine(" number");
            string number = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Finally, now you just need you to name a plant");
            string plant = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Thank you for giving those words. Press any key to continue and see your story!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"A vacation is when you take a trip to some {adjOne} place with your {adjTwo} family. Usually you go to some place that is near a/an {nounOne} or up on a/an {nounTwo}. A good vacation place is one where you can ride {pluralNounOne} or play {game} or go hunting for {pluralNounTwo}. I like to spend my time {verbINGOne} or {verbINGTwo}. When parents go on a vacation, they spend their time eating three {pluralNounThree} a day, and fathers play golf, and mothers sit around {verbINGThree}. Last summer, my little brother fell in a/an {nounThree} and got poison {plant} all over his {partOfBody}. My family is going to go to (the) {aPlace}, and I will practice {verbINGFour}. Parents need vacations more than kids because parents are always very {adjThree} and because they have to work {number} hours every day all year making enough {pluralNounFour} to pay for the vacation.");
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadKey();
        }
        public void MadLibsCredits()
        {
            Console.Clear();
            Console.WriteLine("App Developers: Latoya & Justinian; EFA Studios");
            Console.WriteLine("Story One Name: The Crocodile and the Monkey");
            Console.WriteLine("Story One Author: Unknown");
            Console.WriteLine("Story One provided by Vaishnavi Nagaraj via parenting.firstcry.com");
            Console.WriteLine("\n");
            Console.WriteLine("Story Two Credits:");
            Console.WriteLine("From VACATION FUN MAD LIBS® • Copyright © 1988 by Price Stern Sloan, a division of Penguin Putnam Books for Young Readers, New York.");            
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}