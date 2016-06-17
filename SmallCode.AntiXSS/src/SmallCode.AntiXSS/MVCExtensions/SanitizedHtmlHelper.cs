using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using SmallCode.AntiXSS;

namespace Microsoft.AspNetCore.Mvc
{
    public static class SanitizedHtmlHelper
    {

        public static IHtmlContent Sanitized(this IHtmlHelper self,
                                               string html)
        {
            HtmlContentBuilder hcb = new HtmlContentBuilder();
            hcb.AppendHtml(HtmlFilter.Instance.SanitizeHtml(html));
            return hcb;
        }

        public static IHtmlContent SanitizedFor<TModel>(this IHtmlHelper<TModel> self, string html)
        {
            HtmlContentBuilder hcb = new HtmlContentBuilder();
            hcb.AppendHtml(HtmlFilter.Instance.SanitizeHtml(html));
            return hcb;
        }
    }
}
