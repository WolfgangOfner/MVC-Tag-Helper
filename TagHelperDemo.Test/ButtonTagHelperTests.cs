using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagHelperDemo.Infrastructure.TagHelpers;
using Xunit;

namespace TagHelperDemo.Test
{
    public class ButtonTagHelperTests
    {
        [Fact]
        public void Process_ShouldSetBsButtonClass()
        {
            var context = new TagHelperContext(new TagHelperAttributeList(), new Dictionary<object, object>(), "myuniqueid");
            var output = new TagHelperOutput("button", new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult<TagHelperContent>(new DefaultTagHelperContent()));
            var testee = new ButtonTagHelper
            {
                BsButtonColor = "danger"
            };

            testee.Process(context, output);

            output.Attributes["class"].Value.Should().Be($"btn btn-{testee.BsButtonColor}");
        }
    }
}