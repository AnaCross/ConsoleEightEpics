using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class NewGame
    {
        static NewGame newGame = new NewGame();
        bool isHeroRandom;
        int numberThreats;
        public List<Hero> heroList = new List<Hero>();
        List<Hero> randomHeroList = new List<Hero>();
        public List<Threats> threatList = new List<Threats>();
        List<Threats> randomThreatList = new List<Threats>();
        List<Challenge> challengeList = new List<Challenge>();

        private NewGame() { }
        public static NewGame CreateNewGame()
        {
            return newGame;
        }

        public void setLevel(EnumGameLevel gl)
        {
            switch (gl)
            {
                case EnumGameLevel.EASY:
                    isHeroRandom = false;
                    numberThreats = 5;
                    break;
                case EnumGameLevel.MEDIUM:
                    isHeroRandom = true;
                    numberThreats = 5;
                    break;
                case EnumGameLevel.HARD:
                    isHeroRandom = true;
                    numberThreats = 8;
                    break;
            }
            createHeroList();
            createThreatList();
        }

        void createThreatList()
        {
            createChallenge();
            createThreat();
            Random rnd = new Random();
            int hero;
            while (randomThreatList.Count != numberThreats)
            {
                hero = rnd.Next(8);
                if (randomThreatList.Exists(h => h.ident == hero).Equals(false))
                {
                    randomThreatList.Add(threatList[hero]);
                    //Console.WriteLine(threatList[hero].name);
                }
            }
        }

        void createHeroList()
        {
            
            if (isHeroRandom == false)
            {
                createHero();
            }
            else
            {
                createHero();
                Random rnd = new Random();
                int hero;
                //Console.WriteLine("Hero List");
                while (randomHeroList.Count != 8)
                {
                    hero = rnd.Next(8);
                    if (randomHeroList.Exists(h => h.ident == hero).Equals(false))
                    {
                        randomHeroList.Add(heroList[hero]);
                        //Console.WriteLine(heroList[hero].name);
                    }
                }
            }
        }

        void createHero()
        {
            Hero Auriel = new Hero(5, "Auriel", EnumHeroName.AURIEL, 0);
            Hero Caroosh = new Hero(6, "Caroosh", EnumHeroName.CAROOSH, 1);
            Hero Gron = new Hero(6, "Gron", EnumHeroName.GRON, 2);
            Hero Jarroth = new Hero(5, "Jarroth", EnumHeroName.JAROTH, 3);
            Hero Khantos = new Hero(6, "Khantos", EnumHeroName.KHANTOS, 4);
            Hero Leafwind = new Hero(6, "Leafwind", EnumHeroName.LEAFWIND, 5);
            Hero Ophinia = new Hero(4, "Ophinia", EnumHeroName.OPHINIA, 6);
            Hero Sylliph = new Hero(5, "Sylliph", EnumHeroName.SYLLIPH, 7);
            heroList.Add(Auriel);
            heroList.Add(Caroosh);
            heroList.Add(Gron);
            heroList.Add(Jarroth);
            heroList.Add(Khantos);
            heroList.Add(Leafwind);
            heroList.Add(Ophinia);
            heroList.Add(Sylliph);
        }

        void createChallenge()
        {
            Challenge less = new Challenge(EnumThreatChallenge.LESS);
            Challenge more = new Challenge(EnumThreatChallenge.MORE);
            Challenge sameNumber = new Challenge(EnumThreatChallenge.SAME_NUMBER);
            Challenge other = new Challenge(EnumThreatChallenge.OTHER);
            challengeList.Add(less);
            challengeList.Add(other);
            challengeList.Add(more);
            challengeList.Add(sameNumber);
        }


        void createThreat()
        {
            Threats Broxix = new Threats("Broxix", 8, EnumThreatName.BROXIX,0);
            Threats Durge = new Threats("Durge", 8, EnumThreatName.DURGE, 1);
            Threats Hronthar = new Threats("Hronthar", 3, EnumThreatName.HRONTHAR,2);
            Threats Makano = new Threats("Makano", 4, EnumThreatName.MAKANO,3);
            Threats Narssis = new Threats("Narssis", 4, EnumThreatName.NARSSIS,4);
            Threats Pirn = new Threats("Pirn", 3, EnumThreatName.PIRN,5);
            Threats Serrin = new Threats("Serrin", 2, EnumThreatName.SERRIN,6);
            Threats Uluwash = new Threats("Uluwash", 3, EnumThreatName.ULUWASH,7);
            //Console.WriteLine("Broxix");
            Broxix.setChallengeList(new Challenge(EnumThreatChallenge.MORE));
            Broxix.completeChallenge(15, 3);
            //Console.WriteLine("Durge");
            Durge.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            Durge.completeChallenge(1, 5, 1);
            Durge.completeChallenge(2, 2, 2);
            Durge.completeChallenge(3, 1, 3);
            //Console.WriteLine("Hronthar");
            Hronthar.setChallengeList(new Challenge(EnumThreatChallenge.MORE));
            Hronthar.completeChallenge(32, 1, 6);
            Hronthar.completeChallenge(40, 1, 7);
            Hronthar.completeChallenge(48, 1, 8);
            //Console.WriteLine("Makano");
            Makano.setChallengeList(challengeList);
            Makano.completeChallenge(10, 1, 8);
            Makano.completeChallenge(0, 1, 8);
            Makano.completeChallenge(45, 1, 8);
            Makano.completeChallenge(0, 1, 8);
            //Console.WriteLine("Narssis");
            Narssis.setChallengeList(new Challenge(EnumThreatChallenge.OTHER));
            Narssis.completeChallenge(0, 6);
            //Console.WriteLine("Pirn");
            Pirn.setChallengeList(new Challenge(EnumThreatChallenge.SAME_NUMBER));
            Pirn.completeChallenge(0, 1, 6);
            Pirn.completeChallenge(0, 1, 7);
            Pirn.completeChallenge(0, 1, 8);
            //Console.WriteLine("Serrin");
            Serrin.setChallengeList(new Challenge(EnumThreatChallenge.OTHER));
            Serrin.completeChallenge(0, 8);
            //Console.WriteLine("Uluwash");
            Uluwash.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            Uluwash.completeChallenge(10, 1, 6);
            Uluwash.completeChallenge(9, 1, 7);
            Uluwash.completeChallenge(8, 1, 8);

            threatList.Add(Broxix);
            threatList.Add(Durge);
            threatList.Add(Hronthar);
            threatList.Add(Makano);
            threatList.Add(Narssis);
            threatList.Add(Pirn);
            threatList.Add(Serrin);
            threatList.Add(Uluwash);
        }
    }
}
