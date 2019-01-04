using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticAlgorithm.Models
{
    public class Vector
    {
        protected Guid VectorId { get; set; } = Guid.NewGuid();

        public Guid NodeId { get; set; }

        public string Degree { get; set; }
    }
}
