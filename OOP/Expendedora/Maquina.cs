using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    internal class Maquina
    {
        private List<Line> lines;

        private string Name { get; set; }

        public Maquina(List<Line> lines, string name)
        {
            this.lines = lines;
            Name = name;
        }

        public List<Line> GetLines() => lines;

        public void SetLines(List<Line> lines) => this.lines = lines;

        public string GetName() => Name;

        public void SetName(string name) => Name = name;

        public static AddProduct()
        {

        }
    }
}
