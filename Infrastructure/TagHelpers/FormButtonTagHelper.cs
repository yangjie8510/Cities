using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement("formbutton")]
    public class FormButtonTagHelper : TagHelper
    {
        public string Type { get; set; } = "submit";

        public string BgColor { get; set; } = "primary";

        public override void Process(TagHelperContext context, TagHelperOutput output) {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", $"btn btn-{this.BgColor}");
            output.Attributes.Add("type", this.Type);
            output.Content.SetContent(this.Type == "submit" ? "Submit" : "Reset");
        }
    }
}