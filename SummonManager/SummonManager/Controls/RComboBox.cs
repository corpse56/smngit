using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SummonManager
{
    public partial class RComboBox : ComboBox
    {
        public RComboBox()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        private static extern int FindWindowExA(int hWnd1, int hWnd2, string lpsz1, string lpsz2);

        [DllImport("user32")]
        private static extern int SendMessageA(int hWnd, int wMsg, Int16 wParam, Int16 lParam);

        private const int EM_SETREADONLY = 0xCF;
        private const int WM_ENABLE = 0xA;

        public static void SetReadOnly(Control comBox, bool ReadOnly)
        {
            int hWndEdit;
            comBox.Enabled = !ReadOnly;

            hWndEdit = FindWindowExA(comBox.Handle.ToInt32(), 0, "Edit", "");
            if (hWndEdit != 0)
            {
                SendMessageA(hWndEdit, WM_ENABLE, Convert.ToInt16(true), 0);
                SendMessageA(hWndEdit, EM_SETREADONLY, Convert.ToInt16(ReadOnly), 0);
            }
        }

        public bool ReadOnly
        {
            set
            {
                SetReadOnly(this, value);
            }
        }
    }
}
