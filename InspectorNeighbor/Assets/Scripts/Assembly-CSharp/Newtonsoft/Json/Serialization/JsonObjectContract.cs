using System;

namespace Newtonsoft.Json.Serialization
{
	public class JsonObjectContract : JsonContract
	{
		public JsonObjectContract(Type underlyingType) : base(default(Type))
		{
		}

	}
}
