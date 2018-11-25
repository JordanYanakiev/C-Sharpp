using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Write a program for a class GSMPhone which 
 *  holds the inormation for the phone model, owner, manufacturer
 *  also about the battery (create enum field which to use as a catalog for types 
 *  of batteries) technology, standby time, talk time and the display (size, colors
 *  technology used). 
 *  Create class which holds information for made call from the phone. 
 * */
namespace GsmNested
{
    class GSMPhone
    {
        //static field containing information for Nokia N95
        public static string nokiaN95 = "Manufacturer: NOKIA, Model: N95, Price: $30, Owner: Preowned";

        public static void NokiaN95()
        {
            Console.WriteLine(nokiaN95);
        }

        //Initialize fields
        public string manufacturer;
        public string model;
        public string price;
        public string owner;
        
        //Constructor with all parameters for the phone
        public GSMPhone(string manufacturer, string model, string price, string owner)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
        }

        //Empty constructor in case if we have information different from the full 
        public GSMPhone()
        {

        }
        //method for displaying information for the GSM Phone
        public void GSMPhoneInfo()
        {
            Console.WriteLine(this.manufacturer + this.model + this.price + this.owner);
        }

        public class GSMBattery
        {
            public enum BatteryType { none , NiCa, NiMe, LiIon, LiPoly };
            public BatteryType type;
            public string standbyHours;
            public string callHours;

            //Constructor for the Battery object
            public GSMBattery(BatteryType type, string standbyHours, string callHours)
            {
                this.type = type;
                this.standbyHours = standbyHours;
                this.callHours = callHours;
            }

            //Empty constructor
            public GSMBattery()
            {

            }

            //Method or displaying info for the object Battery
            public void GSMBatteryInfo()
            {
                Console.WriteLine(this.type + " " + this.standbyHours + " " + this.callHours); 
            }
        }

        public class GSMDisplay 
        {
            public string size;
            public string technology;
            public string colors;
           
            //Constructor for the object Display
            public GSMDisplay(string size, string technology, string colors)
            {
                this.size = size;
                this.technology = technology;
                this.colors = colors;
            }

            //Empty constructor 
            public GSMDisplay()
            {

            }

            //Method for displaying info for the object Display
            public void GSMDisplayInfo()
            {
                Console.WriteLine(this.size + this.technology + this.colors);
            }
        }

        public class Call
        {
            public DateTime date = DateTime.Today;
            public DateTime start = DateTime.Now;
            public DateTime end = DateTime.Now;
            
            public Call(DateTime date, DateTime start, DateTime end)
            {
                this.date = date;
                this.start = date;
                this.end = end;
            }

            public void DurationCall()
            {
                long Start = start.Ticks;
                //System.Threading.Thread.Sleep(duration);
                long End = end.Ticks;
                long DurationCall = (End - Start) / 10000000;
                Console.WriteLine("Duration call: {0} seconds", DurationCall);
            }

        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the constructors for the phone, the battery and the display
            GSMPhone nokia = new GSMPhone("Nokia ", "N95 ", "$130 ", "Bai Kolyo ");
            GSMPhone.GSMDisplay okia = new GSMPhone.GSMDisplay("13 inch ", "TFT touchscreen ", "16 milion");
            GSMPhone.GSMBattery bat = new GSMPhone.GSMBattery();
            bat.standbyHours = "2790 h";
            bat.type = GSMPhone.GSMBattery.BatteryType.NiMe;
            bat.callHours = "18 h";
            GSMPhone.GSMBattery nokiaBatery = new GSMPhone.GSMBattery(GSMPhone.GSMBattery.BatteryType.LiIon, " unavailable ", "unavailable");
            GSMPhone.GSMBattery lgBattery = new GSMPhone.GSMBattery();
            GSMPhone.GSMDisplay lgDisplay = new GSMPhone.GSMDisplay("12 inch", "TFT Touchscreen", "16 milion");
            lgDisplay.GSMDisplayInfo();
            lgBattery.type = GSMPhone.GSMBattery.BatteryType.NiCa;
            lgBattery.GSMBatteryInfo();
            nokia.GSMPhoneInfo();
            okia.GSMDisplayInfo();
            nokiaBatery.GSMBatteryInfo();
            bat.GSMBatteryInfo();
            GSMPhone.NokiaN95();

            //Testing the claa Call
            DateTime todayIs = DateTime.Today;
            Console.WriteLine(todayIs);
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(DateTime.Now.Ticks);
            System.Threading.Thread.Sleep(15000);
            DateTime end = new DateTime(DateTime.Now.Ticks);
            GSMPhone.Call nokiaCall = new GSMPhone.Call(now, start, end);
            nokiaCall.DurationCall();
        }
    }
}
