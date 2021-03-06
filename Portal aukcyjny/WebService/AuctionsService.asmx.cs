﻿using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.Web.Services.Protocols;

namespace WebService
{
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuctionsService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetActualAuctionsByCatId(int catId)
        {
            AuctionsRepository auctionsRepo = new AuctionsRepository();
            var auctions = auctionsRepo.GetByCategoryId(catId);

            return JsonConvert.SerializeObject(auctions);
        }
    }
}
