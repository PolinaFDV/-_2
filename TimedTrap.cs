using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class TimedTrap : Trap, IUpdatable
    {
        public int delay;

        public TimedTrap(int id, string name, bool isActive, int damage, int delay) : base(id, name,isActive, damage)
        {
            this.delay = delay;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
