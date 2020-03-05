using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("dueDate")]
        public DateTime DueDate { get; set; }
        [JsonProperty("completedDate")]
        public DateTime CompletedDate { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
