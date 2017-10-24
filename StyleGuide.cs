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
	///		No line wrapping for : extends/implements
	///		Ordering of contents:
	///			private members
	///			public members
	///			constructors
	///			public and private methods, placed in a logical order
	///			Interface implementations to be in the same order as on the interface
	/// 
	/// Attributes
	///		Prefer one per line, rather than comma separated
	/// </summary>
	[Attribute]
	[Attribute]
	sealed class StyleGuide : IDisposable
	{
		/// <summary>
		/// Private fields
		///		Lower case first letter
		///		Camel Casing
		///		No explicit private modifier
		///		Placed at top of class
		/// </summary>
		string anExamplePrivateField;

		/// <summary>
		/// Public fields
		///		Upper case first letter
		///		Camel Casing
		///		Placed at top of class, after private members
		/// </summary>
		public string AnExamplePublicField;

		/// <summary>
		/// Public Property
		///		Upper case first letter
		///		Camel Casing
		///		Place at top of class, after private members
		/// </summary>
		public string PublicProperty { get; set; }

		/// <summary>
		/// Getter only property
		///		Prefer lambdas over { get { return "example"; } } where sensible
		/// </summary>
		string getter => "example;";

		/// <summary>
		/// Constructors
		///		Next in class after public members
		/// </summary>
		public void StyleGuide()
		{		
		}

		/// <summary>
		/// Private method
		///		Upper case first letter
		///		Camel Casing
		///		No explicit private modifier
		///		Braces on new lines
		///		Below constructors within class
		/// </summary>
		void PrivateMethod()
		{
		}


		void GeneralSyntax()
		{
			// explicit this. for member access
			this.anExamplePrivateField = "new value";

			// explicit this. for member calls
			this.PrivateMethod();

			// No braces for single line IFs (same for all blocks)
			if (this.anExamplePrivateField == "some value")
				this.anExamplePrivateField = "some other value";

			// No braces for single line LOCKS (same for all blocks)
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
			//		Prefer var over explicit types
			//		Variabes should have semantic names
			//		Lower case first letter
			//		Camel Case
			var ageInYears = 21;

			// DateTimes
			//		Named as <event>On, eg. bornOn, startedOn, endsOn
			//		Always specify as UTC when new()ing a DateTime
			var bornOn = new DateTime(2017, 10, 23, 12, 32, 45, DateTimeKind.UTC);


			var listOfWords = new[] { "one", "two", "three" };

			// Keep "LINQ" lambdas legible with clear formatting
			listOfWords
				.Where(item => item.Length <= 3)
				.Select(item => item[0])
				.OrderBy(item => item)
				.ToArray();
		}


		/// <summary>
		/// Methods that contain logic
		/// </summary>
		int CyclomaticComplexity()
		{
			// Keep nesting to a minimum, avoid redundant elses

			if (this.anExamplePrivateField == null)
				return 0;
			
			if (this.AnExamplePublicField == null)
				return 0;
			
			// Keep logic inside IFs simple.
			// If it is complex or involves multiple operands, consider using local variables
			if (this.anExamplePrivateField == "winner" && this.AnExamplePublicField = "Chicken Dinner")
				return 10;
		}

		/// <summary>
		/// Methods with return values
		///		Prefer semantic abstract data types to wrap multiple return values, over OUT or REF arguments
		///		Obey CQS, don't cause side effects and return a value where possible (except operation results)
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

		/// <summary>
		/// Static methods
		///		Make methods static where possible
		/// </summary>
		static void DoAThing()
		{
			// no references in here to `this.`
		}
		
		/// <summary>
		/// No #Regions around Interface Implementations, or at all
		/// </summary>
		public void Dispose()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Private classes
		///		Encapsulate private classes that are only used for internal (to the parent class) data, rather than putting them outside the class, available for other uses
		///		Place them at the bottom of the file
		/// </summary>
		sealed class SomeAbstractType
		{
			public string ReturnValue1 { get; set; }
			public int ReturnValue2 { get; set; }
		}
	}
}
