using System;
using PortableClassLibrary1;

namespace PclSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a = new Class1();
            var b = a.TheTime();
        }
    }
}