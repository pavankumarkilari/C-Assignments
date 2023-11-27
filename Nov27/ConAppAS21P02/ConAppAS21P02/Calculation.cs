using System;

namespace ConAppAS21P02
{
    public class Calculation<T>
    {
        public static T Add(T n1, T n2)
        {
            dynamic A = n1;
            dynamic B = n2;
            return (A + B);
        }
        public static T Subtract(T n1, T n2)
        {
            dynamic A = n1;
            dynamic B = n2;
            return (A - B);
        }
        public static T Multiply(T n1, T n2)
        {
            dynamic A = n1;
            dynamic B = n2;
            return (A * B);
        }
        public static T Divide(T n1, T n2)
        {
            dynamic A = n1;
            dynamic B = n2;
            return (A / B);
        }
    }
}
