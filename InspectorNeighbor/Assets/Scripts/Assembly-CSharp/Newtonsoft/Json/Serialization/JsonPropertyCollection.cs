using System.Collections.ObjectModel;
using System;

namespace Newtonsoft.Json.Serialization
{
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		public JsonPropertyCollection(Type type)
		{
		}

		protected override string GetKeyForItem(JsonProperty item)
		{
			return default(string);
		}

	}
}
