﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperDemo.Infrastructure.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "wrap")]
    public class InsideTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<b><i>");
            output.PostContent.SetHtmlContent("</i></b>");
        }
    }
}