using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comandas
{
    class Utils {
        public static string St(string text) { return Regex.Replace(text, "(.{" + 35 + "})", "$1" + Environment.NewLine); }
        public static float DrawLine(string args, float heigth, Font font, PrintPageEventArgs ev) {
            ev.Graphics.DrawString(St(args), font, Brushes.Black, 15, heigth, new StringFormat());
            return ev.Graphics.MeasureString(St(args), font).Height;
        }
        public static void showMessage(object msg) { MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
}
