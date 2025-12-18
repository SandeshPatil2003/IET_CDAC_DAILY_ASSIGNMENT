

using CustomMathLib;

namespace CustomMathImpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomMath cmath = new CustomMath();

            cmath.Add(3, 4);

            CustomAccess customAccess = new CustomAccess();

            customAccess.CustomMul(3, 4);
            customAccess.CustomSqr(3);

        }
    }


    public class CustomAccess : CustomMath
    {

        public void CustomMul(int x,int y)
        {
            this.Mul(x, y);
        }

        public void CustomSqr(int x)
        {
            this.Sqr(x);
        }


    }
}
