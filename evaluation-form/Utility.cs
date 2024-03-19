using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluation_form
{
    static class Utility
    {
        public static Form formExists(Type t)
        {
            foreach (Form f in Application.OpenForms)
                if (f.GetType() == t)
                    return f;
            return null;
        }


    }
}
