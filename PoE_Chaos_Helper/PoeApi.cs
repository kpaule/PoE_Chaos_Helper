using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace PoE_Chaos_Helper
{
    class PoeApi
    {
        private string poessid;
        private string league;
        private string accountName;

        private HttpClient client;


        public PoeApi(string poessid, string league, string accountName)
        {
            this.poessid = poessid;
            this.league = league;
            this.accountName = accountName;

            var baseAddress = new Uri("https://pathofexile.com/");
            var cookieContainer = new CookieContainer();
            client = new HttpClient(new HttpClientHandler { CookieContainer = cookieContainer } );
            client.BaseAddress = baseAddress;
            cookieContainer.Add(client.BaseAddress, new Cookie("POESESSID", poessid));
        }

        public PoE.Stash GetStashItems(int index)
        {
            var requestUri = string.Format("character-window/get-stash-items?league={0}&accountName={1}&tabs=1&tabIndex={2}", league, accountName, index);
            var response = client.GetAsync(requestUri).Result;

            PoE.Stash stash;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;

                stash = JsonConvert.DeserializeObject<PoE.Stash>(json);
            }
            else
            {
                stash = new PoE.Stash();
            }

            return stash;
        }

    }
}
