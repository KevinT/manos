

using System;
using System.Reflection;


namespace Manos {

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class HeadAttribute : HttpMethodAttribute {

		public HeadAttribute ()
		{
		}

		public HeadAttribute (params string [] patterns) : base (patterns)
		{
			Methods = new string [] { "HEAD" };
		}
	}
}


