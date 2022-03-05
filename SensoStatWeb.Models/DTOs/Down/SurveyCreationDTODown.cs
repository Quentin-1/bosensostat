using System;
using Newtonsoft.Json;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Models.DTOs.Down
{
	public class SurveyCreationDTODown
	{
        //[JsonProperty("id")]
        //public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        //[JsonProperty("instructions")]
        //public List<Instruction>? Instructions { get; set; }

        //[JsonProperty("questions")]
        //public List<Question>? Questions { get; set; }

        [JsonProperty("userProducts")]
        public List<UserProduct>? UserProducts { get; set; }

        [JsonProperty("adminId")]
        public int AdminId { get; set; }

        [JsonProperty("users")]
        public List<User>? Users { get; set; }

        [JsonProperty("products")]
        public List<Product>? Products { get; set; }

        //[JsonProperty("creationDate")]
        //public DateTime? CreationDate { get; set; }

        //[JsonProperty("users")]
        //public User User { get; set; }
    }
}

