using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTgBot.Core.Shedule
{
    class SheduleParcer : IParcer<string[]>
    {
        public string[] Parce(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").
                Where(item => item.ClassName != null
                    && item.ClassName.Contains("btn btn-soft-secondary btn-xs mb-1 fw-medium btn-group"));
            foreach (var item in items)
                list.Add(item.TextContent);
            return list.ToArray();
        }
    }
}
