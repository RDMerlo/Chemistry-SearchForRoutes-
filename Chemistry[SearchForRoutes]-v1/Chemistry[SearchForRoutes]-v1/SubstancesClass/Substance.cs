using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemistry_SearchForRoutes__v1.SubstancesClass
{
    public class Substance
    {
        /// <summary>
        /// Количество вещества
        /// </summary>
        private int _count;
        /// <summary>
        /// Имя вещества
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Print() 
        {
            return Convert.ToString(Count) + "" + Name;
        }
    }
}
