using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    class Taxi
    {
        private string DriverName;
        private bool OnDuty;
        private int numPassenger;
        public string Driver_Name
        {
            get { return DriverName; }
            set { DriverName = value; }
        }

        public bool On_Duty
        {
            get { return OnDuty; }
            set { OnDuty = value; }
        }

        public int NumPassenger
        {
            get { return numPassenger; }
            set { numPassenger = value; }
        }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver: {0}", this.DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("Sedang Beroperasi: Yes");
            }
            else
            {
                Console.WriteLine("Sedang Beroperasi: No");
            }
            Console.WriteLine("Nomor Penumpang: {0}", numPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", DriverName);
        }



    }
}
