using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Proxy_Samir
{
    class ProxyTranslator
    {
        private Dictionary<string, string> _theWords;

        public ProxyTranslator()
        {
            _theWords = new Dictionary<string, string>();
        }

        public string Translate(string text)
        {
            var word = text.ToLower();
            if (_theWords.ContainsKey(word))
                return _theWords[word];
            else
            {
                var yandexApi = YandexApi.GetInstance();
                var russianWord = yandexApi.Translate(word);
                _theWords.Add(word, russianWord);
                return _theWords[word];
            }
        }
    }

    class YandexApi
    {
        public Uri Url { get; set; }
        private static YandexApi Translator;

        public YandexApi()
        {
            Url = new Uri(@"https://translate.yandex.net/api/v1.5/tr.json/translate");
            Url = Url.AddParameter("key", @"trnsl.1.1.20171221T171359Z.7c952e5cee5cce49.4522dd804535b842a0959725f4275cc4bf261f60");
            Url = Url.AddParameter("lang", @"en-ru");
        }

        static public YandexApi GetInstance()
        {
            Translator = Translator ?? new YandexApi();
            return Translator;
        }

        public string Translate(string text)
        {
            Url = Url.AddParameter("text", text);
            using (var webClient = new WebClient())
            {
                var data = Encoding.UTF8.GetString(webClient.DownloadData(Url));
                dynamic obj = JObject.Parse(data);
                return obj.text[0];
            }
        }
    }
}
