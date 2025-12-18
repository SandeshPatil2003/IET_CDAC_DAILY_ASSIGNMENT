namespace Properties
{
    public class TestClass
    {

        private int _property1;

        private string _property2;

        public int property1
        {

            set
            {
                _property1 = value;
            }

            get
            {
                return _property1;
            }


        }

        public string property2
        {
            set { _property2 = value; }
            get { return _property2; }
        }
    }
}