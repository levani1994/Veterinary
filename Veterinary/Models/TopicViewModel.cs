using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary.Models
{
    public class TopicViewModel
    {
        [JsonProperty]
        public string TopicViewName { get; set; }
        public string TopicViewCategory { get; set; }
    }
}