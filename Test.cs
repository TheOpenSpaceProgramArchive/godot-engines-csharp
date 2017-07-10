using System.Collections.Generic;
using System.Linq;

namespace OSP {
    public class Test {
        public static void Main() {
            Part p = new Part();
            Engine e1 = new Engine();
            Engine e2 = new Engine();
            PartModule pm = new PartModule();
            p.AddModule(e1);
            p.AddModule(pm);
            p.AddModule(e2);

            System.Console.WriteLine(p.GetModulesOfType<Engine>().ToList().Count);
        }
    }
}
