using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Win32App
{
    public static class FormHelpers
    {
        public static MainForm CurrentMainForm { get; private set; }

        static FormHelpers()
        {
            if (CurrentMainForm == null)
            {
                CurrentMainForm = new MainForm();
            }
        }
    }
}
