using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Domain = "Eukarya";
            Kingdom = "Animalia";
            Phylum = "Chordata";
            Class = "Reptilia";
        }

        public string ReptileType { get; set; }
        public bool HasScales { get; set; }
        public bool HasEyelids { get; set; }
        public bool HasForkedTongue { get; set; }

        public void ReptileInformation()
        {
            Console.WriteLine($"Reptile Type: {ReptileType}\nHas Scales: {HasScales}\nHas Eyelids: {HasEyelids}\nHas Forked Tongue: {HasForkedTongue}");
        }
    }
}
