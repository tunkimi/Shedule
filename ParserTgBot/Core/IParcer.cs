
using AngleSharp.Html.Dom;

namespace ParserTgBot.Core
{
    interface IParcer<T> where T : class
    {
        T Parce(IHtmlDocument document);
    }
}
