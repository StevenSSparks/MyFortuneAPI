using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFortuneAPI.Models
{
    // this is the data for the API as well as the code to access the data
    public class FortuneRepository : IFortuneRepository
    {

        private List<Fortune> _fortunes;
        public int MaxFortune { get { return 59; } }
        public Fortune ErrorFortune
        {
            get
            {
                return new Fortune { id = 999, phrase = "Dark cloud rain on person who try to break fortune API!" };
            }
        }

        public FortuneRepository()
        {
            if (_fortunes == null)
            {
                InitFortunes();
            }
        }

        private void InitFortunes()
        {
            _fortunes = new List<Fortune>
            {
                // One Fortune for every second in a minute 0 to 59
                new Fortune { id = 0, phrase = "Steve S was here. Stole API fortune." },
                new Fortune { id = 1, phrase = "Some days you are pigeon, some days you are statue. Today, bring umbrella."},
                new Fortune { id = 2, phrase = "If a API doesn’t have a server, is it naked or homeless?" },
                new Fortune { id = 3, phrase = "You think it’s a secret, but API knows all." },
                new Fortune { id = 4, phrase = "Hard work pays off in the future. Laziness pays off now." },
                new Fortune { id = 5, phrase = "Ask your mom instead of an API" },
                new Fortune { id = 6, phrase = "Avoid taking unnecessary gambles. Lucky numbers: 12, 15, 23, 28, 37" },
                new Fortune { id = 7, phrase = "You have error in your code." },
                new Fortune { id = 8, phrase = "May your API someday be carbon neutral" },
                new Fortune { id = 9, phrase = "You are not illiterate." },
                new Fortune { id = 10, phrase = "Don’t let statistics do a number on you" },
                new Fortune { id = 11, phrase = "Some fortune APIs contain no fortune" },
                new Fortune { id = 12, phrase = "You will receive a fortune API result." },
                new Fortune { id = 13, phrase = "No snowflake feels responsible in an avalanche." },
                new Fortune { id = 14, phrase = "You love Chinese API." },
                new Fortune { id = 15, phrase = "There is no mistake so great as that of being always right." },
                new Fortune { id = 16, phrase = "That wasn’t chicken." },
                new Fortune { id = 17, phrase = "Someone will invite you to a API Karaoke party." },
                new Fortune { id = 18, phrase = "All fortunes are wrong except from this API." },
                new Fortune { id = 19, phrase = "It is a good day to call your mother API." },
                new Fortune { id = 20, phrase = "Only listen to the fortune API; disregard all other fortune telling systems" },
                new Fortune { id = 21, phrase = "Never wear your best pants when you go to fight for freedom." },
                new Fortune { id = 22, phrase = "Never forget a friend. Especially if he owes you." },
                new Fortune { id = 23, phrase = "Help! I am being held prisoner in a fortune API factory." },
                new Fortune { id = 24, phrase = "Fortune not found? API was sleepy." },
                new Fortune { id = 25, phrase = "Because of your melodic nature, the moonlight never misses an appointment." },
                new Fortune { id = 26, phrase = "You can always find happiness at work on Friday" },
                new Fortune { id = 27, phrase = "The road to riches is paved with API developers." },
                new Fortune { id = 28, phrase = "The world may be your oyster, but it doesn't mean you'll get its API." },
                new Fortune { id = 29, phrase = "We don’t know the future, but here’s a API." },
                new Fortune { id = 30, phrase = "Some men dream of fortunes, others dream of APIs." },
                new Fortune { id = 31, phrase = "He who throws dirt is losing ground." },
                new Fortune { id = 32, phrase = "He who laughs at himself never runs out of things to laugh at." },
                new Fortune { id = 33, phrase = "Flattery will go far tonight." },
                new Fortune { id = 34, phrase = "Do not mistake temptation for opportunity." },
                new Fortune { id = 35, phrase = "An alien of some sort will be appearing to you shortly." },
                new Fortune { id = 36, phrase = "You will live long enough to call many fortune APIs." },
                new Fortune { id = 37, phrase = "If you look back, you’ll soon be going that way." },
                new Fortune { id = 38, phrase = "Person who rests on laurels gets thorn in backside." },
                new Fortune { id = 39, phrase = "He who dies with most toys, still dies." },
                new Fortune { id = 40, phrase = "Probability of being seen directly proportional to stupidity of act." },
                new Fortune { id = 41, phrase = "You will soon have an out of money experience" },
                new Fortune { id = 42, phrase = "Wise person need either good manners or fast reflexes." },
                new Fortune { id = 43, phrase = "Okay to look at past and future. Just don’t stare." },
                new Fortune { id = 44, phrase = "Person who call fortune api get best fortune." },
                new Fortune { id = 45, phrase = "You are cleverly disguised as responsible adult" },
                new Fortune { id = 46, phrase = "When chosen for jury duty, tell judge fortune API say guilty!" },
                new Fortune { id = 47, phrase = "Your inferiority complex not good enough. Try harder" },
                new Fortune { id = 48, phrase = "Two days from now, tomorrow will be yesterday." },
                new Fortune { id = 49, phrase = "Wise person never try to get even. Wise person get odder." },
                new Fortune { id = 50, phrase = "The fortune you seek is in another API." },
                new Fortune { id = 51, phrase = "A closed mouth gathers no feet." },
                new Fortune { id = 52, phrase = "An uncalled API provides no result." },
                new Fortune { id = 53, phrase = "A conclusion is simply the place where you got tired of thinking." },
                new Fortune { id = 54, phrase = "A cynic is only a frustrated optimist" },
                new Fortune { id = 55, phrase = "Your reality check about to bounce." },
                new Fortune { id = 56, phrase = "A foolish man listens to his heart. A wise man listens to APIs." },
                new Fortune { id = 57, phrase = "A fanatic is one who can't change his mind, and won't change the subject." },
                new Fortune { id = 58, phrase = "API says Magic 8 ball is fake. Try again later. " },
                new Fortune { id = 59, phrase = "Time is up, you need to make that choice soon." }
               


            };
        }

        public IEnumerable<Fortune> GetAllFortunes()
        {
            // add no one like cheater code
            return _fortunes;
        }

        public Fortune GetFortuneById(int fortuneId)
        {
            try
            {
                if (fortuneId < 0 || fortuneId > MaxFortune) return ErrorFortune;
                return _fortunes.FirstOrDefault(f => f.id == fortuneId);
            }
            catch
            {
                return ErrorFortune;
            }

        }

        public Fortune GetFortune()
        {
            try
            {
                int sec = DateTime.Now.Second;
                return _fortunes.FirstOrDefault(f => f.id == sec);
            }
            catch
            {
                return ErrorFortune;
            }
           
        }



    }

}
