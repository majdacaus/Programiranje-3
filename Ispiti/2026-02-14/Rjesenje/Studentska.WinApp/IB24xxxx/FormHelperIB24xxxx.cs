using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.WinApp.IB24xxxx
{
    public static class FormHelperIB24xxxx
    {
        public static void PrikaziFormu(this Form forma, Action? onOk = null)
        {
            using (forma)
            {
                if (forma.ShowDialog() == DialogResult.Cancel)
                {
                    onOk?.Invoke();
                }
            }
        }
    }
}
