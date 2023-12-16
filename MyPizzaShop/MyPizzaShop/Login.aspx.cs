using MyPizzaShop.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPizzaShop {
    public partial class Login : System.Web.UI.Page {

        readonly ServiceClient client = new ServiceClient();

        protected void Page_Load(object sender, EventArgs e) {

            HttpCookie reqCookies = Request.Cookies["user"];
            if (reqCookies != null) {
                string logout = Request.QueryString["logout"];
                if (logout == "true") {
                    reqCookies.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(reqCookies);
                } else {
                    Response.Redirect("Home.aspx?redirect=done");
                }
            }
        }

        protected void SignIn_Click(object sender, EventArgs e) {
            User user = new User {
                UName = Username.Text,
                Pw = Password.Text
            };

            string msg = client.Authentication(user);
            HttpCookie userInfo = new HttpCookie("user");

            if (msg == string.Empty) {

                userInfo["username"] = user.UName;
                userInfo.Expires.Add(new TimeSpan(0, 1, 0));
                Response.Cookies.Add(userInfo);

                Response.Redirect("Home.aspx");

            } else {
                Error.Text = msg;
            }
        }
    }
}