using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace AthleteNetwork
{
    public async Task nationalize(string input)
    {
        var api = "https://api.nationalize.io";
        var url = string.Format(api, input);

        using (var httpClient = new httpClient())
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}