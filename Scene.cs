using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Scene
    {
        public List<GameObject> Objects;


        public Scene(List<GameObject> Objects)
        {
            this.Objects = Objects;
        }

        public void PrintAll()
        {
            for (int i = 0;  i < Objects.Count; i++)
            {
                Console.WriteLine($"{i + 1} " + Objects[i].Info());
            }
        }

        public void Tick()
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                if (Objects[i] is IUpdatable updatable)
                {
                    updatable.Update();
                }
            }
        }
    }
}
