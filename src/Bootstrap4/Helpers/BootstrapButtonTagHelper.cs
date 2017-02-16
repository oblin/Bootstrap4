using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bootstrap4.Helpers
{
    public class BootstrapButtonTagHelper : TagHelper
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Clear();
            output.Attributes.Add("class", $"btn btn-{Color} btn-{Size}");
        }
    }
}
