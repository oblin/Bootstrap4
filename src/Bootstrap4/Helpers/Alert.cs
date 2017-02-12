using System;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Bootstrap4.Helpers
{
    public class Alert : IDisposable
    {
        private readonly TextWriter _writer;

        public Alert(IHtmlHelper helper, string title, 
            Enums.AlertStyle style = Enums.AlertStyle.Success)
        {
            _writer = helper.ViewContext.Writer;
            var alertDiv = new TagBuilder("div");
            alertDiv.AddCssClass("alert");
            alertDiv.AddCssClass($"alert-{style.ToString().ToLower()}");
            alertDiv.Attributes.Add("role", "alert");
            alertDiv.TagRenderMode = TagRenderMode.StartTag;

            var strong = new TagBuilder("strong");
            strong.InnerHtml.Append(title);
            string html = ToString(alertDiv) + ToString(strong);

            _writer.Write(html);
        }

        public static string ToString(Microsoft.AspNetCore.Html.IHtmlContent content)
        {
            var writer = new System.IO.StringWriter();
            content.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
            return writer.ToString();
        }

        public void Dispose()
        {
            _writer.Write("</div>");
        }
    }
}