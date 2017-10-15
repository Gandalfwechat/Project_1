using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laerning_bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           // with only one controller control two TVs 
            ActualRemoteController mycontroller = new ActualRemoteController();
            //ConcreteTVTCL TCLTV = new ConcreteTVTCL();

            mycontroller.ImpleTV = new TCL();
            mycontroller.IsOn();
            mycontroller.IsOff();
            mycontroller.SwitchChennal();

            mycontroller.ImpleTV = new SAMSUNG();
            mycontroller.IsOn();
            mycontroller.IsOff();
            mycontroller.SwitchChennal();



            Console.ReadKey();

        }
    }

    public abstract class TV
    {
        public abstract void IsOn();

        public abstract void IsOff();

        public abstract void switchChennal();
           
    }

    public class TCL : TV
    {
        public override void IsOff()
        {
           Console.WriteLine("TCL TV would be off ! Good Night！");
        }

        public override void IsOn()
        {
            Console.WriteLine("TCL TV is on!");
        }

        public override void switchChennal()
        {
            Console.WriteLine("TCL TV is preparing new chennal!");
        }
    }

    public class  SAMSUNG : TV
    {
        public override void IsOff()
        {
            Console.WriteLine("SAMSUNG TV would be off! Good Night！");
        }

        public override void IsOn()
        {
            Console.WriteLine("SAMSUNG TV is on!");
        }

        public override void switchChennal()
        {
            Console.WriteLine("SAMSUNG TV is preparing new chennal!");
        }
    }



    public class Controller
    {
        public TV ImpleTV
        {
            set;
            get;
        }
        public virtual void IsOn()
        {
            ImpleTV.IsOn();
        }
        public virtual void IsOff()
        {
            ImpleTV.IsOff();
        }

        public virtual void SwitchChennal()
        {
            ImpleTV.switchChennal();
        }

        public void usage()
        {
            Console.WriteLine("This is the controller working!");
        }

    }

    public class ActualRemoteController: Controller
    {


    }

    






}
