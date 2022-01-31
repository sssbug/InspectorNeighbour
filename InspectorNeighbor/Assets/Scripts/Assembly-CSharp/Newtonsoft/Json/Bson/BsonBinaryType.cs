namespace Newtonsoft.Json.Bson
{
	internal enum BsonBinaryType : byte
	{
		Binary = 0,
		Function = 1,
		Data = 2,
		Uuid = 3,
		Md5 = 5,
		UserDefined = 128,
	}
}
