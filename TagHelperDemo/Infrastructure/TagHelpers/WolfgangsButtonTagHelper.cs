using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperDemo.Infrastructure.TagHelpers
{
    [HtmlTargetElement("WolfgangsButton")]
    public class WolfgangsButton : TagHelper
    {
        public string Type { get; set; } = "Submit";

        public string BgColor { get; set; } = "success";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", $"btn btn-{BgColor}");
            output.Attributes.SetAttribute("type", Type);
            output.Content.SetContent(Type == "submit" ? "Add" : "Reset");
        }
    }
}