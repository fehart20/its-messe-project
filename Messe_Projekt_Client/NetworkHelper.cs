﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Messe_Projekt_Client
{
    internal class NetworkHelper
    {

        static async public Task<InfoItem> CheckWebapi(string vorname, string nachname, string strasse, string hausnummer, int plz, string ort, string firma, List<Interesse> interessen)
        {



            InfoItem result = null;
            string baseURL = "https://localhost:7159/";
            InfoItem transfer = new InfoItem();
            transfer.Vorname = vorname;
            transfer.Nachname = nachname;
            transfer.Strasse = strasse;
            transfer.Hausnummer = hausnummer;
            transfer.Plz = plz;
            transfer.Ort = ort;
            transfer.Firma = firma;
            transfer.Interessen = interessen;
            transfer.Confirmed= false;
            transfer.Username = "-";
            transfer.RequestTime= DateTime.Now;
           
            string payload2 = JsonConvert.SerializeObject(transfer);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
              

                var httpContent = new StringContent(payload2, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://localhost:7159/Messe", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    Task<string> antwort = response.Content.ReadAsStringAsync();
                    string desSource = antwort.Result;
                    InfoItem buffer = JsonConvert.DeserializeObject<InfoItem>(desSource);
                    if (buffer.Confirmed)
                    {
                        result = buffer;
                    }
                }

            }
          
                return result;

        }



    }
}
