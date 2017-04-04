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
    }
}
