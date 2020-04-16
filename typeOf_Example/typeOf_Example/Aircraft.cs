namespace typeOf_Example
{
    class Aircraft
    {
        //Declare the properties of the user defined class
        public string Brand { get; set; }
        public string Model { get; set; }
        public int releaseYear { get; set; }
        public bool stillInService { get; set; }

        //Declare the constructor
        public Aircraft(string _brand, string _model, int _releaseYear, bool _stillInService)
        {
            this.Brand = _brand;
            this.Model = _model;
            this.releaseYear = _releaseYear;
            this.stillInService = _stillInService;
        }

        //declare an example free method.
        public void exampleMethod()
        {

        }
    }
}
