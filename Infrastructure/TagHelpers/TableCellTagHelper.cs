using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement("td", Attributes="wrap")]
    public class TableCellTagHelper : TagHelper
    {
        public bool Wrap { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<b><i>");
            output.PostContent.SetHtmlContent("</b></i>");
        }
    }
}