using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private Func func;
        String name;
        double returnValue;

        public SingleMission(Func f, String name)
        {
            this.func = f;
            this.name = name;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public String Type
        {
            get
            {
                return "Single";
            }
        }

        // todo 
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            return this.returnValue = this.func(value);
        }
    }
}
