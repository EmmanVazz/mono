//
// System.OutOfMemoryException.cs
//
// Authors:
//   Joe Shaw (joe@ximian.com)
//   Duncan Mak (duncan@ximian.com)
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		const int Result = unchecked ((int)0x8007000E);

		// Constructors
		public OutOfMemoryException ()
			: base (Locale.GetText ("Out of memory."))
		{
			HResult = Result;
		}

		public OutOfMemoryException (string message)
			: base (message)
		{
			HResult = Result;
		}

		public OutOfMemoryException (string message, Exception innerException)
			: base (message, innerException)
		{
			HResult = Result;
		}

		protected OutOfMemoryException (SerializationInfo info, StreamingContext context)
			: base (info, context)
		{
		}
	}
}
