using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Trap : GameObject, IInteractable, IDamageable
    {
        Player player;
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public Trap(int id, string name, bool isActive, int damage) : base(id, name, isActive) 
        { 
            this.damage = damage;
        }

        public void ApplyDamage(int amount)
        {
            int new_hp = player.Hp - amount;
            if (new_hp >= 0)
            {
                player.Hp = new_hp;
            }
            else
            {
                player.Hp = 0;
            }
            Disable();
            Console.WriteLine("Ловушка сломана");
        }

        public override string Info()
        {
            return $"{id} - {name}";
        }

        public string Interact(Player player)
        {
            player.Hp -= damage;
            return "Вы попали в ловушку и поранились";
        }
    }
}
