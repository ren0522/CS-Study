using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P205
    {
        class car 
        {
            int carNumber;
            DateTime inTime;
            DateTime outTime;

            public void SetInTime() 
            {
                this.inTime = DateTime.Now;
            }

            public void SetOutTime() 
            {
                this.outTime = DateTime.Now;
            }

        }
    }
}
