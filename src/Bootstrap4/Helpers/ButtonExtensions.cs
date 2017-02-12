using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bootstrap4.Helpers
{
    public static class ButtonExtensions
    {
        public static IHtmlContent BootstrapButton(this IHtmlHelper helper,
            string caption, Enums.ButtonStyle style, Enums.ButtonSize size)
        {
            if (size != Enums.ButtonSize.Normal)
                return new HtmlString(
                    $"<button type='button' class='btn btn-{style.ToString().ToLower()} btn-{ ButtonHelper.ToBootstrapSize(size) }'>{caption}</button>"
                );
            return new HtmlString(
                $"<button type='button' class='btn btn-{style.ToString().ToLower()}'>{caption}" + 
                $"<span class='fa fa-adn'></span></button>"
            );
        }
    }
}
