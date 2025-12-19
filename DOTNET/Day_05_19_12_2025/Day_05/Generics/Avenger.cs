namespace Generics
{
    internal class Avenger
    {
        private string _Name;
        private string _City;

        public Avenger(string v1, string v2)
        {
            this._Name = v1;
            this._City = v2;
        }

        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                _Name = value;
            }
        
        }
        public string City {
            get
            {
                return this._City;
            }
            set
            {
                _City = value;
            }
        
        }
    }
}