using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CubeIntersect.Controls
{
    public class CubeFormValueChangedEventArgs : EventArgs
    {
        public string Size { get; private set; }
        public string X { get; private set; }
        public string Y { get; private set; }
        public string Z { get; private set; }

        public CubeFormValueChangedEventArgs(string s, string x, string y, string z)
            : base()
        {
            Size = s;
            X = x;
            Y = y;
            Z = z;
        }
    }

    public partial class CubeForm : System.Web.UI.UserControl
    {
        public string Title { get { return lblTitle.Text; } set { lblTitle.Text = value; } }
        public string Size { get { return txtSize.Text; } set { txtSize.Text = value; } }
        public string X { get { return txtXCoord.Text; } set { txtXCoord.Text = value; } }
        public string Y { get { return txtYCoord.Text; } set { txtYCoord.Text = value; } }
        public string Z { get { return txtZCoord.Text; } set { txtZCoord.Text = value; } }

        public event EventHandler OnValueChanged;

        protected void ValueChanged(object sender, EventArgs e)
        {
            if (OnValueChanged != null)
                OnValueChanged(sender, new CubeFormValueChangedEventArgs(Size, X, Y, Z));
        }

        protected void cvSize_Validate(object sender, ServerValidateEventArgs e)
        {
            decimal temp;
            e.IsValid = decimal.TryParse(e.Value, out temp) && temp > 0;
        }

        protected void cvCoord_Validate(object sender, ServerValidateEventArgs e)
        {
            decimal temp;
            e.IsValid = decimal.TryParse(e.Value, out temp);
        }

    }
}