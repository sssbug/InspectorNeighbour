using System.ComponentModel;
using System;

namespace Newtonsoft.Json.Linq
{
	public class JPropertyDescriptor : PropertyDescriptor
	{
		public JPropertyDescriptor(string name, Type propertyType) : base(default(MemberDescriptor))
		{
		}

		public override object GetValue(object component)
		{
			return default(object);
		}

		public override void SetValue(object component, object value)
		{
		}

		public override void ResetValue(object component)
		{
		}

		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}

		public override Type ComponentType
		{
			get { return default(Type); }
		}
		public override bool IsReadOnly
		{
			get { return default(bool); }
		}
		public override Type PropertyType
		{
			get { return default(Type); }
		}

	}
}
