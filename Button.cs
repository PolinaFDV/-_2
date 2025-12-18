using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Button : GameObject, IInteractable
    {
        ITriggerable triggerable;

        public Button(int id, string name, bool isActive) : base(id, name, isActive)
        {
        }

        public override string Info()
        {
            return "Я кнопка";
        }

        public string Interact(Player player)
        {
            triggerable.Trigger();
            return "Кнопка нажата";
        }
    }
}
