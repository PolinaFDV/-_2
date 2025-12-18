using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Checkpoint : GameObject, IInteractable
    {   
        Player player;

        public Checkpoint(int id, string name, bool isActive) : base(id, name, isActive)
        {
        }

        public override string Info()
        {
            return "Я чекпоинт";
        }

        public string Interact(Player player)
        {
            player.LastCheckpointId = Id;
            return "Checkpoint is done";
        }
    }
}
