using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HeroesStorage
    {
        private HeroesStorage(){
            heroes.Add(Hero.build( 0, "Albania"));
            heroes.Add(Hero.build( 1, "Bosnia"));
            heroes.Add(Hero.build( 2, "Croatia"));
        }
        private static HeroesStorage instance = new HeroesStorage();
        private IList<Hero> heroes = new List<Hero>();

        public static HeroesStorage getInstance(){return instance;}

        public IList<Hero> getAll(){return heroes;}

        public string getHero(int id)
        {
            int found = find(id);
            if (found > -1){return heroes[found].name;}
            else{return "";}
        }

        public void updateHero(int id, string name)
        {
            if (name == null || name.Trim().Equals("")){return;}
            if (id < 0)
            {
                int max_id = -1;
                foreach (Hero hero in heroes)
                {
                    if (max_id < hero.id){max_id = hero.id;}
                }
                id = max_id + 1;
            }
            int found = find(id);
            if (found > -1){heroes[found].name = name;}
            else {heroes.Add(Hero.build(id, name));}
        }

        public void removeHero(int id)
        {
            int found = find(id);
            if (found > -1){heroes.RemoveAt(found);}
        }

        private int find(int id)
        {
            foreach (Hero h in heroes)
            {
                if (h.id == id){return heroes.IndexOf(h);}
            }
            return -1;
        }
    }
}