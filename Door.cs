using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Door : GameObject, IInteractable
    {
        private bool requiredAccess;

        public Door(int id, string name, bool isActive, bool requiredAccess) : base(id, name, isActive)
        {
            this.requiredAccess = requiredAccess;
        }

        public override string Info()
        {
            return $"{id} - {name}";
        }

        public string Interact(Player player)
        {
            if (requiredAccess)
            {

                return "Door opened";
            }
            return "Access denied";
        }
    }
}
