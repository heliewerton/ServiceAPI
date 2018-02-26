﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    public class TokenResult
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }

        public string userName { get; set; }
        public DateTime issued {get;set;}

        public DateTime expires { get; set; }

        public bool IsAuthenticated()
        {
            return expires_in > 0 && string.IsNullOrWhiteSpace(access_token) == false;
        }
    }
}
