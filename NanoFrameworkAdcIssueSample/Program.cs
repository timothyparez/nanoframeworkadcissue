using System;
using System.Diagnostics;
using System.Threading;
using nanoFramework.M5Core2;
using nanoFramework.M5Stack;
using nanoFramework.Presentation.Media;
using Console = nanoFramework.M5Stack.Console;
using System.Device.Adc;

namespace Example
{
    public class Program
    {
        public static void Main()
        {                        
            M5Core2.InitializeScreen();
            AdcChannel adc = M5Core2.GetAdcGpio(36);

            //The code below is never executed
            //If you remove the line above and set value explicitly it works

            while(true)
            {
                Console.CursorTop = 1;
                Console.CursorLeft = 0;                                
                var value = adc.ReadValue();
                Console.WriteLine(value.ToString());
                Console.WriteLine("-----------------");
                Thread.Sleep(500);
            }
        }
    }
}