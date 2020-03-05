using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoManager.Web.Data.Entities
{
    interface IEntity
    {
        [JsonProperty("id")]
        int Id { get; set; }
    }
}
