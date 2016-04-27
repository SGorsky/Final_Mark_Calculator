using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Mark_Calculator
{
    class Evaluation
    {
        float mark;
        public float Mark
        {
            get { return mark; }
        }

        float weight;
        public float Weight
        {
            get { return weight; }
        }

        public float GradeMark
        {
            get { return mark * weight / 100; }
        }

        public Evaluation(float evalMark, float evalWeight)
        {
            mark = evalMark;
            weight = evalWeight;
        }
    }
}
