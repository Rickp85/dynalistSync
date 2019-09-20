using System;
using System.Net.Http;
using DynalistSync.Models;

namespace DynalistSync.BusinessLogic
{
    public class DynalistAPI
    {
        private string API_KEY = "Tcc0rM4bazE9CumRaViWxpNacvhcxCYuBMspCrd_yWz5Z4n72wC4b6SqS0TE_bqO1a9xriR-roYdqakwecfNAncer8T0g0cMXaePhxXtl534SCqC4ykKxOx5u99pZM_2";
        
        public DynalistAPI()
        {
        }

        public async System.Threading.Tasks.Task<DynResp> getFromDynalistAsync()
        {
            DynResp resp = new DynResp();

            HttpClient client = new HttpClient();
            Token tok = new Token();
            tok.token = API_KEY;
            using (HttpResponseMessage response = await client.PostAsJsonAsync("https://dynalist.io/api/v1/file/list", tok))
            {
                if (response.IsSuccessStatusCode)
                {
                    resp = await response.Content.ReadAsAsync<DynResp>();
                }
            }
            return resp;



        }

        public async System.Threading.Tasks.Task<DynDoc> getDocFromID(string id)
        {
            DynDoc resp = new DynDoc();

            HttpClient client = new HttpClient();
            TokenIDFile tok = new TokenIDFile();
            tok.token = API_KEY;
            tok.file_id = id;
            using (HttpResponseMessage response = await client.PostAsJsonAsync("https://dynalist.io/api/v1/doc/read", tok))
            {
                if (response.IsSuccessStatusCode)
                {
                    resp = await response.Content.ReadAsAsync<DynDoc>();
                }
            }

            return resp;



        }
    }
}
