using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bootstrap4.Helpers
{
    public static class AlertHelper
    {
        public static Alert Alert(this IHtmlHelper html, string title,
            Enums.AlertStyle style = Enums.AlertStyle.Success)
        {
            return new Alert(html, title, style);
        }
    }
}