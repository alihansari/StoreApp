using Entities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Services.Abstract;

namespace StoreApp.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "products")]
    public class LastestProductTagHelper : TagHelper
    {
        private readonly IServiceManager _manager;
        [HtmlAttributeName("number")]
        public int Number { get; set; }
        public LastestProductTagHelper(IServiceManager manager)
        {
            _manager = manager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder div = new TagBuilder("div");
            div.AddCssClass("my-3");

            TagBuilder h6 = new TagBuilder("h6");
            h6.AddCssClass("lead");

            TagBuilder icon = new TagBuilder("i");
            icon.AddCssClass("fa fa-box text-secondary");

            h6.InnerHtml.AppendHtml(icon);
            h6.InnerHtml.AppendHtml(" Lastest Products");

            TagBuilder ul = new TagBuilder("ul");

            var products = _manager.ProductService.GetLastestProducts(Number, false);
            foreach (Product product in products)
            {
                TagBuilder a = new TagBuilder("a");
                a.Attributes.Add("href", $"/product/get/{product.Id}");
                a.InnerHtml.AppendHtml(product.ProductName);
                
                TagBuilder li = new TagBuilder("li");
                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);
            }

            div.InnerHtml.AppendHtml(h6);
            div.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(div);
        }
    }
}