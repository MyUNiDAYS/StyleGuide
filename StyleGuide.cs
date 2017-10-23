// Usings at the top, outside the namespace
using System;

// Namespace next
// Braces on new lines
namespace UD.Core
{
	// Tabs over spaces


	/// <summary>
	/// Classes
	///		sealed by default
	///		internal (no explicit modifier) by default
	///		Braces on new lines
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
		///		Braces on new lines
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

			// Use braces for the THEN/ELSE block of an IF when it only has one line, when the other block is multiline (and has braces)
			if (this.anExamplePrivateField == "some value")
			{
				this.anExamplePrivateField = "some other value";
			}
			else
			{
				this.anExamplePrivateField = "some different value";
				this.AnExamplePublicField = "a new value";
			}

			// Local variables
			//		Prefer var of explicit types
			//		Variabes should have semantic names
			//		Lower case first letter
			//		Camel Case
			var ageInYears = 21;

			// DateTimes
			//		Named as eventOn
			//		Always specify as UTC
			var bornOn = new DateTime(2017, 10, 23, 12, 32, 45, DateTimeKind.UTC);
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
