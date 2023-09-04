using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    public class HogwartsStudentNJ : HogwartsStudent
    {


        public HogwartsStudentNJ() : base(100, 100, House.Gryffindor)
        {


        }

        public override string Name { get { return "NJ"; } }

        protected override string SayCatchPhrase()
        {
            string catchPhrase = "I wanna Cry";
            return catchPhrase;
        }
        protected override string CastSpell()
        {
            string spell = "Expelliarmus";
            return spell;
        }
    }
}
