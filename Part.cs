using System.Collections.Generic;
using System.Linq;

namespace OSP {
    public class Part {
        public List<PartModule> Modules { get; }

        public Part() {
            Modules = new List<PartModule>();
        }

        public void AddModule(PartModule module) {
            Modules.Add(module);
        }

        public void RemoveModule(PartModule module) {
            Modules.Remove(module);
        }

        public IEnumerable<T> GetModulesOfType<T>() where T : PartModule {
            return Modules.Where(mod => mod is T).Cast<T>();
        }
    }
}
