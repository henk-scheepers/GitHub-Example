using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    public class HogwartsStudentRey : HogwartsStudent
    {
        public HogwartsStudentRey() : base(90, 270, House.Gryffindor)
        {
        }
        public override string Name 
        {
            get { return "Reynard"; }
        }

        protected override string SayCatchPhrase()
        {
            string catchPhrase = "It do be like that sometimes";
            return catchPhrase;
        }
        protected override string CastSpell()
        {
            string spell = "AtomicBombious";
            return spell;
        }
    }
}
