using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSharp
{
    /// <summary>
    /// The main class of the program that defines the program entry point, creates the ATM and the bank
    /// and starts the ATM
    /// </summary>
    class AtmApplication
    {
        /// <summary>
        /// The main method that starts the program. The args parameter that Visual Studio generates was
        /// removed as it is not used. C# allows the Main() method not to have an args parameter
        /// </summary>
        static void Main()
        {
            //use exception handling to ensure the application does not crash
            try
            {
                AtmApplication app = new AtmApplication();
                app.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred with the following message: {0}", e.Message);
            }
        }

        /// <summary>
        /// Truly the main method of the application object. Invoked as soon as an
        /// application object is created. Will create a bank object and start an ATM
        /// that operates in the context of the bank
        /// </summary>
        private void Run()
        {
        }

    }
}
