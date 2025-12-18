using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal abstract class GameObject
    {
        protected int id;
        protected string name;
        protected bool isActive = true;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            private set
            {
                isActive = value;
            }
        }
        public GameObject(int id, string name, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.isActive = isActive;
        }

        public void Enable()
        {
            isActive = true;
        }

        public void Disable()
        {
            isActive = false;
        }

        public abstract string Info();
    }
}
