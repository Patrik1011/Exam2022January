namespace ExamFirstSemester
{
    public class Bike
    {
        private string _model;
        private int _yearOfPurchase;
        private string _frameColor;
        private int _chasisNumber;

        public Bike(string model, int yearOfPurchase, string frameColor, int chasisNumber)
        {
            _model = model;
            _yearOfPurchase = yearOfPurchase;
            _frameColor = frameColor;
            _chasisNumber = chasisNumber;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int YearOfPurchase
        {
            get { return _yearOfPurchase; }
            set { _yearOfPurchase = value; }
        }

        public string FrameColor
        {
            get { return _frameColor; }
            set { _frameColor = value; }
        }

        public int ChasisNumber
        {
            get { return _chasisNumber; }
        }

        public override string ToString()
        {
            return $"Bike whose model is: {Model}, YearOfPurchase: {YearOfPurchase}, frame color: {FrameColor} , ChasisNumber {ChasisNumber}";
        }


    }
}