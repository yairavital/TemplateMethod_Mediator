using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    internal abstract class ExerciseBase
    {
        public string name;
        public abstract void Run();
        public abstract void Training();
        public abstract void Game();
        public void TrainingProgram()
        {
            Console.WriteLine("The Training program is for: "+name);
            Run();
            Training();
            Game();
        }


    }
}
