using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm.Models
{
    public class Node
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public long Degree { get; set; }

        public List<Vector> Vectors { get; set; }
    }
}
