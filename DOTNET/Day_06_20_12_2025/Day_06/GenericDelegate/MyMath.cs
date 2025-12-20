namespace GenericDelegate
{
    internal class MyMath
    {

        public void Test<T1,T2,T3,T4>(MyDelegate3<T1,T2> del,T3 para1,T4 para2)
        {
            dynamic p1 = para1;
            dynamic p2 = para2;

            del(p1,p2);

        }
    }
}