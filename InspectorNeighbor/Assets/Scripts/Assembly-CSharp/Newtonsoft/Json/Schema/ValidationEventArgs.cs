using System;

namespace Newtonsoft.Json.Schema
{
	public class ValidationEventArgs : EventArgs
	{
		internal ValidationEventArgs(JsonSchemaException ex)
		{
		}

	}
}
