using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLesson
{
    class RangeOfArray
    {
        public int Maximum { get; set; } //-9
        public int Minimum { get; set; } //2
        private int[] _salary;
        public int this[int index]
        {
            get
            {
                int counter = 0;
                if (Maximum < Minimum)
                {
                    for (int i = Minimum; i < Maximum; i--)
                    {
                        if (index == i)
                        {
                            break;
                        }
                        counter++;
                    }
                }
                else
                {
                    for (int i = Minimum; i < Maximum; i++)
                    {
                        if (index == i)
                        {
                            break;
                        }
                        counter++;
                    }
                }
                
                return _salary[counter];
            }
            set
            {
                int counter = 0;
                if (Maximum < Minimum)
                {
                    for (int i = Minimum; i < Maximum; i--)
                    {
                        if (index == i)
                        {
                            break;
                        }
                        counter++;
                    }
                }
                else
                {
                    for (int i = Minimum; i < Maximum; i++)
                    {
                        if (index == i)
                        {
                            break;
                        }
                        counter++;
                    }
                }
                _salary[counter] = value;
            }
        }
        public RangeOfArray(int size)
        {
            _salary = new int[size];
        }
            
    }
}
