using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoManager.Web.API
{
    public class StatusMessage
    {
        [JsonProperty("error")]
        public bool Error { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
