﻿using System.Text.Json.Serialization;

namespace Net6.with.MongoDB.Demo.Models;

public class UpdateBookDto : CreateBookDto
{
    public string Id { get; set; }

    [JsonIgnore]
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}