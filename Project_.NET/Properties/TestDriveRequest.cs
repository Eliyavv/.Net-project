namespace Project_.NET.Properties
{
    public class TestDriveRequest
    {
       private int id { get; set; }  // מזהה ייחודי לבקשה לנסיעת מבחן
        private int customerId { get; set; }  // מזהה הלקוח שביקש את הנסיעה
        private Customer customer { get; set; }  // אובייקט לקוח (מכיל פרטי לקוח) לשאול את המורה אם הכרחי או שניתן להשתמש רק במזהה האיי-די
        private int carId { get; set; }  // מזהה הרכב המבוקש לנסיעת מבחן
        private DateTime requestedDate { get; set; }  // תאריך שהלקוח ביקש את הנסיעה
        private string status { get; set; }  // סטטוס הבקשה (למשל: "ממתין", "הושלם", "נדחה")


        public TestDriveRequest( int id, int customerId, Customer customer, int carId, DateTime requestDate, string status)
        {
            this.id = id;
            this.customerId = customerId;
            this.customer = customer;
            this.carId = carId;
            this.requestedDate = requestDate;
            this.status = status;
            
        }
        // שיטה שכעת עדיפה על טוסטרינג
        public string GetRequestDetails()
        {
            return $"נסיעת מבחן ל-{requestedDate.ToShortDateString()} עבור הלקוח {customerId} - סטטוס: {status}";
        }
    }
}
