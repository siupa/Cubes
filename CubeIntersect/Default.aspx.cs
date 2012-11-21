using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cube;

namespace CubeIntersect
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIntersect_Clicked(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                IntersectionManager<decimal> mgr = new IntersectionManager<decimal>(new Cube.Calculations.DecimalCalculator());

                decimal res = mgr.GetIntersectionVolumeOfCubes(
                    decimal.Parse(cbfrmCubeA.Size),
                    decimal.Parse(cbfrmCubeA.X),
                    decimal.Parse(cbfrmCubeA.Y),
                    decimal.Parse(cbfrmCubeA.Z),
                    decimal.Parse(cbfrmCubeB.Size),
                    decimal.Parse(cbfrmCubeB.X),
                    decimal.Parse(cbfrmCubeB.Y),
                    decimal.Parse(cbfrmCubeB.Z));

                if (res != decimal.MinValue)
                    ltlResults.Text = String.Format("Cubes intersect and the intersected volume is: {0}", res);
                else
                    ltlResults.Text = String.Format("Cubes do not intersect", res);
            }
        }
    }
}