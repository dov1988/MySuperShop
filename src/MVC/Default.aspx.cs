using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Web.ModelBinding;
using System.IO;
using Domein;

namespace MVC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Customer customer = new Customer();

                IValueProvider provider =
                    new FormValueProvider(ModelBindingExecutionContext);
                    Context context = new Context();
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
    }
}