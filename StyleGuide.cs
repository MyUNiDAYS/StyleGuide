// Usings at the top, outside the namespace
using System;

// Namespace next
namespace UD.Core
{
	// Tabs over spaces


	/// <summary>
	/// Classes
	///		sealed by default
	///		internal (no explicit modifier) by default
	/// </summary>
	sealed class StyleGuide : IDisposable
	{
		/// <summary>
		/// Private fields
		///		Lower case first letter
		///		Camel Casing
		///		No explicit private modifier
		/// </summary>
		string anExamplePrivateField;

		/// <summary>
		/// Public fields
		///		Upper case first letter
		///		Camel Casing
		/// </summary>
		public string AnExamplePublicField;

		/// <summary>
		/// Public Property
		///		Upper case first letter
		///		Camel Casing
		/// </summary>
		public string PublicProperty { get; set; }

		/// <summary>
		/// Getter only property
		///		Prefer labmdas over { get { return "example"; } } where sensible
		/// </summary>
		string getter => "example;";

		/// <summary>
		/// Private method
		///		Upper case first letter
		///		Camel Casing
		///		No explicit private modifier
		/// </summary>
		void PrivateMethod()
		{
			// explicit this. for member access
			this.anExamplePrivateField = "new value";

			// explicit this. for member calls
			this.PrivateMethod();

			// No braces for single line IFs (all blocks)
			if (this.anExamplePrivateField == "some value")
				this.anExamplePrivateField = "some other value";

			// No braces for single line LOCKS (all blocks)
			lock (this.anExamplePrivateField)
				this.anExamplePrivateField = "some other value";

			// No braces on outer Using when multiple present, no indentation on inner
			using (this)
			using (this)
			{
				// do something
			}


		}


		/// <summary>
		/// Methods with return values
		///		Prefer semantic abstract data types to wrap multiple return values, over OUT or REF arguments
		/// </summary>
		SomeAbstractType PerformGetOperation()
		{
			// prefer object initializers
			// no redundant () for default constructor use
			return new SomeAbstractType
			{
				ReturnValue1 = "value 1",
				ReturnValue2 = 2
			};
		}


		sealed class SomeAbstractType
		{
			public string ReturnValue1 { get; set; }
			public int ReturnValue2 { get; set; }
		}

		/// <summary>
		/// No #Regions around Interface Implementations, or at all
		/// </summary>
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
