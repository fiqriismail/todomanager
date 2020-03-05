using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TodoManager.Web.Data.Enums;
using static TodoManager.Web.Data.Enums.StatusEnum;

namespace TodoManager.Web.Data.Entities
{
    public class ToDo : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("due")]
        public DateTime Due { get; set; }
        [JsonProperty("completed")]
        public DateTime? Completed { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
