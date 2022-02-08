using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TesteAPIFake.Models
{
    public partial class UserResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
        public override string ToString()
        {
            return
                "\n|" + Id +
                "\n|" + Name +
                "\n|" + Email +
                "\n|" + Phone +
                "\n|" + Website +
                "\n|" + Address.Street +
                "\n|" + Address.Suite +
                "\n|" + Address.Zipcode +
                "\n|" + Address.Geo.Lat +
                "\n|" + Address.Geo.Lng +
                "\n|" + Company.Name +
                "\n|" + Company.CatchPhrase +
                "\n|" + Company.Bs;
        }
    }
}
