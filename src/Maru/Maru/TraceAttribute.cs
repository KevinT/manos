
using System;
using System.Reflection;


namespace Maru {

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class TraceAttribute : HttpMethodAttribute {

		public TraceAttribute ()
		{
		}

		public TraceAttribute (params string [] patterns) : base (patterns)
		{
			Methods = new string [] { "TRACE" };
		}
	}
}


