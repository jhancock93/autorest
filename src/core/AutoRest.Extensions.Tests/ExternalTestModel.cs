using System;
using Newtonsoft.Json;

namespace AutoRest.Tests.ExternalModels
{
    [JsonObject()]
    public class ExternalTestModel
    {
        public string Id { get; set; }

        public DateTime? DateTime { get; set; }
    }
}