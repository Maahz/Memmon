using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;


namespace Memmon
{
    class Program
    {
        internal const ulong kLimit = 2147483648;  //Warning limit

        internal static ComputerInfo ci = new ComputerInfo();
        static void Main(string[] args)
        {
            while (true)
            {
                //If memory is lower than the limit, show warning
                if (MemoryLow()) 
                    MessageBox.Show("System running out of memory!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Threading.Thread.Sleep(10000);
            }
        }

        //Check if memory is lower than the limit
        private static bool MemoryLow()
        {
            if (ci.AvailablePhysicalMemory < kLimit) return true;
            return false;
        }
    }
}
