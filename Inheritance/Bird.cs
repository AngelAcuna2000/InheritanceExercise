using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Domain = "Eukarya";
            Kingdom = "Animalia";
            Phylum = "Chordata";
            Class = "Aves";
 
        }

        public string BirdType { get; set; }
        public bool CanFly { get; set; }
        public bool CanSing { get; set; }
        public bool CanTalk { get; set; }

        public void BirdInformation()
        {
            Console.WriteLine($"Bird Type: {BirdType}\nCan Fly: {CanFly}\nCan Sing: {CanSing}\nCan Talk: {CanTalk}\n\n");
        }

    }
}
