using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoManager.Web.Data.Entities
{
    public class User : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}
