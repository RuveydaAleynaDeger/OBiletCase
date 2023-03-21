﻿using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class ConnectionRequest
{
    [JsonProperty("ip-address")]
    public string IpAddress { get; set; }

    [JsonProperty("port")]
    public string Port { get; set; }
}