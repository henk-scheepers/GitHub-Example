using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Example
{
    public class HogwartStudentCait : HogwartsStudent
    {
        public HogwartStudentCait() : base(70, 69, House.Gryffindor) { }
        public override string Name { get { return " Cait"; }}

        protected override string SayCatchPhrase()
        {
            string ct = "BOOM BOOM BAKUDAN";
            return ct;
        }
        protected override string CastSpell()
        {
            string cs = "Explosive arson";
            return cs;

        }

       
    }
}

