using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsultarArchivosConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Request x = new Request();

            string url = @"http://10.151.0.1:8003/api/Lists/List_GetItems";
            x.ListId = 45;
            x.FatherItemId = -1;
            x.header = new Header() {User= "wmapi", Token= "i7jKkSpNxuyL3RapMUY1MuBEog6xeZMB" };

            GetRequest(url, x);





            Console.ReadKey();
        }


        async static void GetRequest(string url,Request p)
        {
            using (HttpClient cliente = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(p);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await cliente.PostAsync(url, byteContent);
                

                string resultado = response.Content.ReadAsStringAsync().Result;

                var resultado2 = JsonConvert.DeserializeObject<Respuesta>(resultado);

                foreach (var item in resultado2.Data)
                {
                    Console.WriteLine(item.Nombre);
                }

                Console.WriteLine(resultado2.Rows);
            }
        }
    }

}
