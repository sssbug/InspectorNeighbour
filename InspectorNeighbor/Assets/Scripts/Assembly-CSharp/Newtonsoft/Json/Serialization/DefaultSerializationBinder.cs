using System.Runtime.Serialization;
using System;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultSerializationBinder : SerializationBinder
	{
		public override Type BindToType(string assemblyName, string typeName)
		{
			return default(Type);
		}

	}
}
