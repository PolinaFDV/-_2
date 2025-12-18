using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Light : GameObject, ITriggerable
    {
        private bool isOn;
        public bool IsOn
        {
            get
            {
                return isOn;
            }
            set
            {
                isOn = value;
            }
        }
        public Light(int id, string name, bool isActive, bool isOn) : base(id, name, isActive)
        {
            this.isOn = isOn;
        }

        public override string Info()
        {
            return "Меня можно триггерить";
        }

        public void Trigger()
        {
            if (isOn)
            {
                isOn = false;
            }
            else
            {
                isOn = true;
            }
        }
    }
}
