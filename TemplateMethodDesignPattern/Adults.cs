using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    internal class Adults : ExerciseBase
    {
        public Adults()
        {
            name = "Adults";
        }

        public override void Game()
        {
            Console.WriteLine("The game is football");
        }


    public override void Run()
        {
            Console.WriteLine("You needs to run 2000 m");
        }

        public override void Training()
        {
            Console.WriteLine("The training is about 20 minuts");        }
    }
}
