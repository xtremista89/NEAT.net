using NEAT.Abstrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAT.Abstrations
{
    public interface IConnectionGene : IHistoricalMarking, ICloneable<IConnectionGene>
    {
        INodeGene Input { get; set; }
        INodeGene Output { get; set; }
        float Weight { get; set; }
        bool Enabled { get; }
        void Disable();
        void Enable();
    }
}
