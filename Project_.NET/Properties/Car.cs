using System.Reflection;

namespace Project_.NET.Properties
{
    public class Car
    {
        private int id { get; set; }  // מזהה ייחודי לרכב
        private string model { get; set; }  // דגם הרכב
        private string make { get; set; }  // יצרן (מותג)
        private int year { get; set; }  // שנת יצור
        private double price { get; set; }  // מחיר הרכב
        private bool isNew { get; set; }  // האם הרכב חדש או משומש
        private string color { get; set; }  // צבע הרכב
        private string vin { get; set; }  // מספר רישוי (VIN)



        public Car(int id, string model, string make, int year, double price, bool isNew, string color, string vin)
        {
            this.id = id;
            this.model = model;
            this.make = make;
            this.year = year;
            this.price = price;
            this.isNew = isNew;
            this.color = color;
            this.vin = vin;
            
        }

        //שיטה שכעת עדיפה על טוסטרינג
        public string GetCarDescription()
        {
            return $"{make} {model} ({year}) - {price:C}";
        }
    }
}
