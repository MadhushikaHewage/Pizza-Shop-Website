using MyPizzaShop.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPizzaShop {
    public partial class Home : System.Web.UI.Page {

        readonly ServiceClient client = new ServiceClient();

        protected void Page_Load(object sender, EventArgs e) {

            HttpCookie user = Request.Cookies["user"];

            // Generating Pizza List from SOAP
            StringBuilder sb = new StringBuilder();
            var pizzas = client.PizzaList();

            for (int i = 0; i < pizzas.Length; i++) {
                sb.Append(@"
                    <div class='portfolio-item-separator portfolio-item-separator1 odd_element'>
                        <div class='clear'></div>
                        <div class='post-separator'>
                            <img src='images/separator.png' alt='' />
                        </div>
                    </div>
                    <div class='portfolio-items-single columns3'>
                        <img class='portfolio-frame' src='images/frame.png' />
                        <div class='portfolio-frame-shadow'></div>
                        <a class='portfolio-url-thumb' href='#' title='Mexicans'>
                            <img class='portfolio-inner-frame' src='images/inner-shadow.png' />
                            <div class='view-overlay-icon pe-7s-plus'></div>
                            <div class='view-overlay-bg'></div>
                        </a>
                        <div class='portfolio-items-single-thumb' href='#' title='Mexican'>
                            <img src='./images/items/" + pizzas[i][3] + @"' width='313' height='220' alt='mexican' />
                        </div>
                        <div class='clear'></div>
                        <div class='portfolio-items-single-description-wrapper'>
                            <div class='portfolio-items-single-icon'>
                                <img src='images/pizza-slice-black.png'>
                            </div>
                            <div class='portfolio-items-single-description'>
                                <a class='portfolio-items-single-title' href='#' title='Mexican'>" + pizzas[i][0] + @"</a>
                                <div class='portfolio-items-single-content'>
                                    <p>" + pizzas[i][1] + @"</p>
                                </div>
                                <div class='portfolio-items-single-details'>
                                    <div class='portfolio-detail'>
                                        <div class='portfolio-detail-caption'>Medium</div>
                                        <div class='portfolio-detail-value'> Rs. " + Convert.ToDouble(pizzas[i][2]).ToString("00.00") + @"</div>
                                    </div>
                                    <div class='clear'></div>
                                </div>
                                <div class='portfolio-items-single-content'>
                                    <button id='order'>Order Now</button>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            Pizzas.Controls.Add(new LiteralControl(sb.ToString()));
        }
    }
}