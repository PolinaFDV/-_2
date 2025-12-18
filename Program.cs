using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> objects = new List<GameObject>();
            objects.Add(new Door(1, "first door", true, true));
            objects.Add(new Trap(2, "dangerous trap", true, 30));
            objects.Add(new Light(3, "light", false, true));
            Scene scene = new Scene(objects);

            Player player = new Player(100, true, 5);
            while (true)
            {
                scene.PrintAll();
                Console.WriteLine();

                Console.WriteLine("Интерактивные объекты:");
                Console.WriteLine(scene.Objects.Count);
                for (int i = 0; i < scene.Objects.Count; i++)
                {
                    Console.WriteLine(scene.Objects[i] is IInteractable);
                    if (scene.Objects[i] is IInteractable)
                    {
                       Console.WriteLine(scene.Objects[i].Info());
                    }
                }

                Console.WriteLine("Введите Id объекта");
                int new_Id = int.Parse(Console.ReadLine());

                for (int i = 0; i < scene.Objects.Count; i++)
                {
                    if (scene.Objects[i].Id == new_Id)
                    {
                        if (scene.Objects[i] is IInteractable interactable)
                        {
                            interactable.Interact(player);
                            scene.Objects[i].Disable();
                        }
                        else
                        {
                            Console.WriteLine("Object is not interactable");
                        }
                    }

                }
                Console.WriteLine("Действие закончено");
                Console.WriteLine();
            }
        }
    }
}
