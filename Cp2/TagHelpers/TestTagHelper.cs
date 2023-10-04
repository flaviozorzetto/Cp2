using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CP2.TagHelpers
{
    public class AlertTagHelper : TagHelper
    {
        public string? Msg { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(string.IsNullOrEmpty(Msg))
            {
                return;
            }
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "alert alert-success");
            output.Content.SetContent(Msg);
        }
    }
}
