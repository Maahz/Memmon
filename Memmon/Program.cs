using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;


namespace Memmon
{
    class Program
    {
        internal const ulong kLimit = 2684354560;  //Warning limit

        internal static ComputerInfo ci = new ComputerInfo();
        static void Main(string[] args)
        {
            while (true)
            {
                //If memory is lower than the limit, show warning
                if (MemoryLow()) 
                    MessageBox.Show("Memory running low!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Threading.Thread.Sleep(10000);
            }
        }

        private static bool MemoryLow()
        {
            if (ci.AvailablePhysicalMemory < kLimit) return true;
            return false;
        }
    }
}
