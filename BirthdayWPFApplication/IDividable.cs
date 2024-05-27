using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentCreditsApplication
{
    public interface IDividable
    {
        public string Read();
        public List<string> ReadChunks();
        public IEnumerable<string> NextRow(string chunk);
    }
}
