using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class AngleBtwHr_Min
    {
        public float Angle(int hr,int min)
        {
            float minAngle = min * 6;
            float hrAngle = Convert.ToInt32((hr * 30) + (min * 0.5));
            float angle = Math.Abs(hrAngle - minAngle);
            if (angle > 180)
            {
                angle = 360 - angle;
            }
            return angle;
        }
    }
    public class Q33_AngleBtwHr_Min
    {
        public static void Main()
        {
            AngleBtwHr_Min ahm = new AngleBtwHr_Min();
            Console.WriteLine(ahm.Angle(9,30));
        }
    }
}
