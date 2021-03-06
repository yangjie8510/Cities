using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div", Attributes="title")]
    public class ContentWrapperTagHelper : TagHelper
    {
        public bool IncludeHeader { get; set; } = true;

        public bool IncludeFooter { get; set; } = true;

        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "m-1 p-1");
            var title = new TagBuilder("h1");
            title.InnerHtml.Append(this.Title);
            
            var container = new TagBuilder("div");
            container.Attributes["class"] = "bg-info m-1 p-1";

            container.InnerHtml.AppendHtml(title);

            if (this.IncludeHeader)
            {
                output.PreElement.SetHtmlContent(container);
            }
            if (this.IncludeFooter)
            {
                output.PostElement.SetHtmlContent(container);
            }
        }
    }
}