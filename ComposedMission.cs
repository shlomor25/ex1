using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private String name;
        private List<Func> list;

        public ComposedMission(String name)
        {
            this.name = name;
            this.list = new List<Func>();
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
                return "Composed";
            }
        }

        //todo
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            foreach(var f in list)
            {
                value = f(value);
            }
            return value;
        }

        public ComposedMission Add(Func f)
        {
            this.list.Add(f);
            return this;
        }
    }
}
