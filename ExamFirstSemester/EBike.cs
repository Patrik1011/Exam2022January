namespace ExamFirstSemester
{
    public class EBike:Bike
    {
        private string _motor;

        public EBike(string motor, string model, int yearOfPurchase, string frameColor, int chasisNumber) : base(model, yearOfPurchase, frameColor, chasisNumber)
        {
            _motor = motor;
        }

        public string Motor => _motor;

        public override string ToString()
        {
            return $"The EBike has a motor : {Motor} model is: {Model}, YearOfPurchase: {YearOfPurchase}, frame color: {FrameColor} , ChasisNumber {ChasisNumber}";
        }
    }
}