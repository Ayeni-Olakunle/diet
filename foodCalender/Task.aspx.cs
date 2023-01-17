using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Web.Script.Serialization;

namespace foodCalender
{
    public partial class Task : System.Web.UI.Page
    {
        private static int i;
        int MyCount = 0;
        string[] cars = { "Bread and Beans", "Garri and Yam", "Corn and Rice", "Plantain and Garri" };
        string json = System.IO.File.ReadAllText(@"C:\Users\DELL\Documents\C#\foodCalender\foodCalender\Scripts\foodarray.json");
        string jsonResponse = System.IO.File.ReadAllText(@"C:\Users\DELL\Documents\C#\foodCalender\foodCalender\Scripts\foodarray.json");


        void Page_Load(Object sender, EventArgs e)
        {
        }
        protected void Increment(object sender, EventArgs e)
        {
            JArray jArray = JArray.Parse(jsonResponse);
            i++;
            string me = jArray[i].ToString();
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            object routes_list = json_serializer.DeserializeObject(json);
            Label1.Text = jArray[i].ToString();

            foreach (JObject jObject in jArray)
            {
                Console.WriteLine($"{(string)jObject["food"]} -> {(string)jObject["day"]}");
            }
            Console.WriteLine("text");
        }

        protected void Decrement(object sender, EventArgs e)
        {
            MyCount -= 1;
            Label1.Text = cars[MyCount];
        }

        protected void Increment2(object sender, EventArgs e)
        {
            MyCount += 1;
            Label1.Text = cars[MyCount];
        }

        protected void Decrement2(object sender, EventArgs e)
        {
            MyCount -= 1;
            Label1.Text = cars[MyCount];
        }

        protected void Increment3(object sender, EventArgs e)
        {
            MyCount += 1;
            Label1.Text = cars[MyCount];
        }

        protected void Decrement3(object sender, EventArgs e)
        {
            MyCount -= 1;
            Label1.Text = cars[MyCount];
        }

        protected void Morning(object sender, EventArgs e)
        {
            morning.Attributes["Class"] = "show";
            afternoon.Attributes["Class"] = "noShow";
            night.Attributes["Class"] = "noShow";

            Button3.Attributes["Class"] = "active";
            Button4.Attributes["Class"] = "notActive";
            Button5.Attributes["Class"] = "notActive";
        }
        protected void After_Noon(object sender, EventArgs e)
        {
            morning.Attributes["Class"] = "noShow";
            afternoon.Attributes["Class"] = "show";
            night.Attributes["Class"] = "noShow";

            Button3.Attributes["Class"] = "notActive";
            Button4.Attributes["Class"] = "active";
            Button5.Attributes["Class"] = "notActive";
        }
        protected void Night(object sender, EventArgs e)
        {
            morning.Attributes["Class"] = "noShow";
            afternoon.Attributes["Class"] = "noShow";
            night.Attributes["Class"] = "show";

            Button3.Attributes["Class"] = "notActive";
            Button4.Attributes["Class"] = "notActive";
            Button5.Attributes["Class"] = "active";
        }
    }
}