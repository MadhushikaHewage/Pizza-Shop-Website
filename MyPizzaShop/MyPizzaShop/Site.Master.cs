using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPizzaShop {
    public partial class Site : System.Web.UI.MasterPage {
        public string currentYear; 
        protected void Page_Load(object sender, EventArgs e) {
            currentYear = DateTime.Now.ToString("yyyy");
        }
    }
}