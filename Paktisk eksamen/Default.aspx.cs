using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLayer;

namespace Paktisk_eksamen
{
    public partial class Default : System.Web.UI.Page
    {
        private BL bl = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewFilter.DataSource = bl.Elev();
            GridViewFilter.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string Etternavn = TextBoxSearch.Text;
            GridViewSearch.DataSource = bl.SearchElev(Etternavn);
            GridViewSearch.DataBind();
        }
        protected void ButtonNorsk_Click(object sender, EventArgs e)
        {
            string Fag = "Norsk";
            GridViewFilter.DataSource = bl.SearchFag(Fag);
            GridViewFilter.DataBind();
        }
        protected void ButtonEngelsk_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonGym_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonMatte_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonNaturfag_Click(object sender, EventArgs e)
        {

        }
    }
}