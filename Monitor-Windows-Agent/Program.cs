using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using JASONParser;
using PingServer;

namespace Monitor_Windows_Agent
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        
        [STAThread]
        static void Main()
        {
            //  Parser pars = new Parser();
            //ComputerInfo comp=  pars.ConfigParser();
            //String name = comp.name;
            //String result = JsonConvert.SerializeObject(comp);
            //String s = CreateJSON.getJSON();
            Ping p = new Ping();
            p.connection();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
