using System.Drawing;
using System.Windows.Forms;

namespace Testing.Classes
{
    public static class Groupbox_Display
    {
        public static void Displays_Groupbox_Center_Form(GroupBox groupBox, int width_Form, int height_Form)
        {
            groupBox.Location = new Point((width_Form - groupBox.Width) / 2, (height_Form - groupBox.Height) / 2);
            groupBox.Visible = true;
        }
    }
}
