﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class BenchInfos
	{
		public string[] Tags { get; set; }
		[JsonConverter(typeof(JsonToByteArrayConverterBench))]
		public byte[] Logo { get; set; }
		internal sealed class JsonToByteArrayConverterBench : JsonConverter<byte[]?>
		{
			// Converts base64 encoded string to byte[].
			public override byte[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				if (!reader.TryGetBytesFromBase64(out byte[]? result) || result == default)
				{
					throw new Exception("Add your fancy exception message here...");
				}
				return result;
			}

			// Converts byte[] to base64 encoded string.
			public override void Write(Utf8JsonWriter writer, byte[]? value, JsonSerializerOptions options)
			{
				writer.WriteBase64StringValue(value);
			}
		}
	}
}
