using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Player
    {
        private int hp;
        private bool hasAccessCard;
        private int lastCheckpointId;

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public Player(int hp, bool hasAccessCard, int lastCheckpointId)
        {
            this.hp = hp;
            this.hasAccessCard = hasAccessCard;
            this.lastCheckpointId = lastCheckpointId;
        }

        public bool HasAccessCard
        {
            get
            {
                return hasAccessCard;
            }
        }
        public int LastCheckpointId
        {
            get
            {
                return lastCheckpointId;
            }
            set
            {
                lastCheckpointId = value;
            }
        }
    }
}
