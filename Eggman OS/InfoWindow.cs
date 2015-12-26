using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eggman_OS
{
    public class InfoWindow
    {
        public IntPtr Handle = IntPtr.Zero;
        public FileInfo File = new FileInfo(Application.ExecutablePath);
        public string Title = Application.ProductName;
        public override string ToString()
        {
            return File.Name + " > " + Title;
        }
    }//CLASS
}
