using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    internal class HogwartsStudentTish : HogwartsStudent
    {
        public override string Name { get { return "Tishey"; } }

        public HogwartsStudentTish() : base(100, 50, House.Gryffindor) { }

        protected override string SayCatchPhrase()
        {
            return "You forget a thousand things everyday pal, how about you make sure this is one of them";
        }

        protected override string CastSpell()
        {
            return "SNIPER SHOT";
        }
    }
}
