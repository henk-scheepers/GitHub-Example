using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    internal class HogwartStudentLirisa : HogwartsStudent
    {
        public HogwartStudentLirisa() : base(50, 60, House.Gryffindor)
        {
        }

        public override string Name { get { return "Lirisa"; } }
        protected override string CastSpell()
        {
            return "Avada Kedavra!";
        }

        protected override string SayCatchPhrase()
        {
            return "Life's a beach";
        }
    }
}
