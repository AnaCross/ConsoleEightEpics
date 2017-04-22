﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpicsConsole.Challenges;

namespace EightEpicsConsole
{
    class NewGame
    {
        static NewGame newGame = new NewGame();
        bool isHeroRandom;
        int numberThreats = 0;
        public List<Hero> heroList = new List<Hero>();
        public List<Hero> randomHeroList = new List<Hero>();
        List<Threats> threatList = new List<Threats>();
        public List<Threats> randomThreatList = new List<Threats>();
        List<Challenge> challengeList = new List<Challenge>();
        static Random rnd = new Random();
        public EnumGameLevel gameLevel;

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
                    gameLevel = gl;
                    break;
                case EnumGameLevel.MEDIUM:
                    isHeroRandom = true;
                    numberThreats = 5;
                    gameLevel = gl;
                    break;
                case EnumGameLevel.HARD:
                    isHeroRandom = true;
                    numberThreats = 8;
                    gameLevel = gl;
                    break;
            }
            createHeroList();
            createThreatList();
        }

        void createThreatList()
        {
            createChallenge();
            createThreat();
            int hero;
            while (randomThreatList.Count != numberThreats)
            {
                hero = rnd.Next(8);
                if (randomThreatList.Exists(h => h.ident == hero).Equals(false))
                {
                    randomThreatList.Add(threatList[hero]);
                    Console.WriteLine(threatList[hero].name);
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
            heroList = new List<Hero>{
                new Hero(5, "Auriel", EnumHeroName.AURIEL, 0),
                new Hero(6, "Caroosh", EnumHeroName.CAROOSH, 1),
                new Hero(6, "Gron", EnumHeroName.GRON, 2),
                new Hero(5, "Jarroth", EnumHeroName.JAROTH, 3),
                new Hero(6, "Khantos", EnumHeroName.KHANTOS, 4),
                new Hero(6, "Leafwind", EnumHeroName.LEAFWIND, 5),
                new Hero(4, "Ophinia", EnumHeroName.OPHINIA, 6),
                new Hero(5, "Sylliph", EnumHeroName.SYLLIPH, 7)
            };
        }

        void createChallenge()
        { challengeList = new List<Challenge> {
                new ChallengeLess(),
                new ChallengeMore(),
                new ChallengeSameNumber(),
                new ChallengeOther(),
            };
            
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
            //Durge.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            Durge.completeChallenge(1, 5, 1, new Challenge(EnumThreatChallenge.LESS));
            Durge.completeChallenge(2, 2, 2, new Challenge(EnumThreatChallenge.LESS));
            Durge.completeChallenge(3, 1, 3, new Challenge(EnumThreatChallenge.LESS));
            //Console.WriteLine("Hronthar");
            //Hronthar.setChallengeList(new Challenge(EnumThreatChallenge.MORE));
            Hronthar.completeChallenge(32, 1, 6, new Challenge(EnumThreatChallenge.MORE));
            Hronthar.completeChallenge(40, 1, 7, new Challenge(EnumThreatChallenge.MORE));
            Hronthar.completeChallenge(48, 1, 8, new Challenge(EnumThreatChallenge.MORE));
            //Console.WriteLine("Makano");
            //Makano.setChallengeList(challengeList);
            Makano.completeChallenge(10, 1, 8, new Challenge(EnumThreatChallenge.LESS));
            Makano.completeChallenge(0, 1, 8, new Challenge(EnumThreatChallenge.OTHER));
            Makano.completeChallenge(45, 1, 8, new Challenge(EnumThreatChallenge.MORE));
            Makano.completeChallenge(0, 1, 8, new Challenge(EnumThreatChallenge.SAME_NUMBER));
            //Console.WriteLine("Narssis");
            Narssis.setChallengeList(new Challenge(EnumThreatChallenge.OTHER));
            Narssis.completeChallenge(0, 6);
            //Console.WriteLine("Pirn");
            //Pirn.setChallengeList(new Challenge(EnumThreatChallenge.SAME_NUMBER));
            Pirn.completeChallenge(0, 1, 6, new Challenge(EnumThreatChallenge.SAME_NUMBER));
            Pirn.completeChallenge(0, 1, 7, new Challenge(EnumThreatChallenge.SAME_NUMBER));
            Pirn.completeChallenge(0, 1, 8, new Challenge(EnumThreatChallenge.SAME_NUMBER));
            //Console.WriteLine("Serrin");
            Serrin.setChallengeList(new Challenge(EnumThreatChallenge.OTHER));
            Serrin.completeChallenge(0, 8);
            //Console.WriteLine("Uluwash");
            //Uluwash.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            //warość, liczba_challenge, liczba kości
            Uluwash.completeChallenge(10, 1, 6, new Challenge(EnumThreatChallenge.LESS));
            Uluwash.completeChallenge(9, 1, 7, new Challenge(EnumThreatChallenge.LESS));
            Uluwash.completeChallenge(8, 1, 8, new Challenge(EnumThreatChallenge.LESS));

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
