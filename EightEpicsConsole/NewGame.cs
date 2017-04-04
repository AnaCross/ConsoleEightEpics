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
        List<Hero> heroList = new List<Hero>();
        List<Hero> randomHeroList = new List<Hero>();
        List<Threats> threatList = new List<Threats>();
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
                while (randomHeroList.Count != 7)
                {
                    hero = rnd.Next(8);
                    if (randomHeroList.Exists(h => h.ident == hero).Equals(false))
                    {
                        randomHeroList.Add(heroList[hero]);
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
            Threats Broxix = new Threats("Broxix", 8, EnumThreatName.BROXIX);
            Threats Durge = new Threats("Durge", 8, EnumThreatName.DURGE);
            Threats Hronthar = new Threats("Hronthar", 3, EnumThreatName.HRONTHAR);
            Threats Makano = new Threats("Makano", 4, EnumThreatName.MAKANO);
            Threats Narssis = new Threats("Narssis", 4, EnumThreatName.NARSSIS);
            Threats Pirn = new Threats("Pirn", 3, EnumThreatName.PIRN);
            Threats Serrin = new Threats("Serrin", 2, EnumThreatName.SERRIN);
            Threats Uluwash = new Threats("Uluwash", 3, EnumThreatName.ULUWASH);
            Broxix.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.MORE));
            Durge.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.LESS));
            Hronthar.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.MORE));
            Makano.setChallengeList(challengeList);
            Narssis.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.OTHER));
            Pirn.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.SAME_NUMBER));
            Serrin.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.OTHER));
            Uluwash.setChallengeList(challengeList.Find(h => h.enumThretChallange == EnumThreatChallenge.LESS));
        }
    }
}
