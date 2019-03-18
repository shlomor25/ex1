using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Func(double d);

    public class FunctionsContainer
    {
        private Dictionary<String, Func> dict = new Dictionary<string, Func>();
        
        public Func this[String s]
        {
            get
            {
                if (!dict.ContainsKey(s))
                    dict.Add(s, value => value);
                return dict[s];
            }
            set
            {
                if (dict.ContainsKey(s))
                    dict[s] = value;
                else
                    dict.Add(s, value);
            }
        }

        public List<String> getAllMissions()
        {
            return this.dict.Keys.ToList();
        }
    }
}
