namespace rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;

        }
        public override string Attack()
        {
            return this.name + " lançou uma magia";
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.Attack() + " forte com bônus de ataque de " + bonus;
            }
            else
            {
                return this.Attack() + " fraca com bônus de ataque de " + bonus;
            }

        }
    }
}