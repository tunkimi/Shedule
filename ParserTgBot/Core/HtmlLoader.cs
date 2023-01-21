using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ParserTgBot.Core
{
    class HtmlLoader
    {
        readonly HttpClient _httpClient;
        readonly string _url;
        public HtmlLoader(IParcerSettings settings)
        {
            _httpClient = new HttpClient();
            _url = $"{settings.BaseUrls}/{settings.Prefix}";
        }
        public async Task<string> GetSourceByInstituteNumber(int num)
        {
            var curUrl = _url.Replace("currentNum", num.ToString());
            var response = await _httpClient.GetAsync(curUrl);
            string source = null;

            if(response!=null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
