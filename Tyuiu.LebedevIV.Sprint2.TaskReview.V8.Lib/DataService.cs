using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LebedevIV.Sprint2.TaskReview.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y <= 4 && y <= Math.Pow(x, 2))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
