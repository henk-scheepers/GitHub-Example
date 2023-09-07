using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    public class HogwartsStudentRebecca : HogwartsStudent
    {

        public HogwartsStudentRebecca() : base(3, 49, House.Gryffindor){


        }

        public override string Name { get { return "Rebecca"; } }

        protected override string SayCatchPhrase()
        {
            string catchPhrase = "It's a Horse";
            return catchPhrase;
        }
        protected override string CastSpell()
        {
            string spell = "HenkHelp-iamus";
            return spell;
        }
    }
}
