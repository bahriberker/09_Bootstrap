using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_Bootstrap.Library
{
    public static class MyExtensions
    {
        public static MvcHtmlString Alert(this HtmlHelper helper, string id="alert1",string color="success",string text="")
        {

        //     < div role = "alert" class="alert alert-success">
        //              Ipsum gravida vel pretium tellus tincidunt
        //      </div>
            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass("alert alert-" + color);
            tag.GenerateId(id);
            tag.Attributes.Add(new KeyValuePair<string, string>("role", "alert"));

            tag.SetInnerText(text);

            return MvcHtmlString.Create(tag.ToString());

        }
    }
}