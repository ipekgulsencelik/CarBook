namespace CarBook.EntityLayer.Concrete
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public string FeatureName { get; set; }
        public bool HasFeature { get; set; }
        public bool Status { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}