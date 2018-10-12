Here's a guide to our code conventions.

The following guide should be considered a supplement to the Google Java style guide found at https://google.github.io/styleguide/javaguide.html

## Spacing
Single line space preceding blocks with more than one statement
e.g.

	public void methodBlock() {
	
		System.out.println("Hello world");
		System.out.println("A second line of text");
	}
	
	public void anotherMethodBlock() {
		System.out.println("Hello world");
	}

## Method Naming Conventions
_Verbs at the start, nouns at the end_
e.g.

	clickButton
	removeOption
	perform

**should**GuardingCondition
e.g. 

	boolean shouldShowCategoriesOption
	boolean shouldAllowLogin

**request**SomeContent
When attempting to get data asynchronously or in a manner which could potentially fail
e.g.

	void requestContentResponse

**notify**SomeEventHappened
Handles the notification to whoever cares that something happened
e.g.

	void notifyCountrySelectionChange

**on**SomeEventHappened
e.g.

	void onCountrySelectionChange
	void onActivityResume
	void onContentUpdated

**handle**Something
e.g.

	void handleContentReponse(...)

**set**FieldName
Should be primarily for setters of class fields - in some cases, it may also be appropriate to trigger further updates from within the setter
e.g.

	void setCustomerName(String customerName) {
	    this.customerName = customerName;
	}
	
	void setToolbarTitle(String toolbarTitle) {
	
		this.toolbarTitle = toolbarTitle;
		applyToolbarTitle();
	}

**get**FieldName
- Should be exclusively for getters of class properties.
- Should always return the field referenced by the method name.
- Should NOT perform calculations or IO operations.

**reset**

**clear**
Should be used to for cases where the intention is to empty or remove state 

**apply**
Should be used to using a pre-set field to do some one-way modification in which the resulting state may not be stored.
e.g.

	void applyToolbarTint()
	void applyPromobarScrollSupport()

someOperation**Internal**
e.g.

	public void handleNetworkConnectivityChange(int state) {
	    // blah
	    handleNetworkConnectivityChangeInternal(progress);
	}
	private void handleNetworkConnectivityChangeInternal(int state) {
	    // blah
	}

## Programming Practices

### Override

A method is marked with the `@Override` annotation whenever it is legal. This includes a class method overriding a superclass method, a class method implementing an interface method, and an interface method respecifying a superinterface method.

Exception: @Override may be omitted when the parent method is @Deprecated.

### Static members: qualified using class

When a reference to a static class member must be qualified, it is qualified with that class's name, not with a reference or expression of that class's type.

	Foo aFoo = ...;
	Foo.aStaticMethod(); // good
	aFoo.aStaticMethod(); // bad
	somethingThatYieldsAFoo().aStaticMethod(); // very bad`

### Exceptions

Caught are not ignored. Testing can be the exception where certain exceptions are expected as part of the test. 

With regards to Observables - the `TestSubscriber` can be used for testing as it can report and assert exception types. In main code Observables should not throw exceptions except potentially in `doOnError()` as this wraps the exception as an Observable Error. The common practice is to use `Observable.error()`.

### Finalizers

These are not used. There is a good explanation in the book Effective Java - Item 7.

## Logging
Logging should always be handled with Timber

### Errors
Should only be used in genuine fatal or business error case scenarios which should need to be investigated.

`Timber.e(throwable, message);`

### Warnings

`Timber.w(throwable, message);` or `Timber.w(message);`

### Info

`Timber.i(message);`

### Debug

`Timber.d(message);`

## Patterns
Activity 1-1 ActivityViewModel

Activity 1-\< Fragments

Fragment 1-1 FragmentViewModel

## Annotations
Where possible support annotations should be used as they strengthen Android Studio's ability to check nullity, resource references and usage. 

@Nullable

@NonNull

@StringRes

@LayoutRes

@ColorInt

@ColorRes

`@CheckResult` marks a method for which it’s implied functionality is dependent on the value it returns. For example in the builder pattern you must call `build()`, or in the Observable subscriber pattern you must call `subscribe()` without these additional method chains the original method might appear not to be functioning. In short, this annotation will give a reminder for when a returned value goes ignored.

## XML Files

### Layouts

Layout files following the naming convention `<WHAT>_<WHERE>.xml` . For example activity\_about.xml is a valid file name but about\_activity.xml is NOT.

### Ids

Ids should follow the convention `<WHERE>_<DESCRIPTION>_<WHAT>`. `review_fragment_dismiss_button` is a valid example. The first section should follow the same naming convention as the layout file name.

### Strings

These do not follow the standard naming convention when provided as a content String. This is due to them being provided as part of a 3rd party tool. When Strings are provided as non content they should be placed within the main `strings.xml` file with a key of `<WHERE>_<DESCRIPTION>` e.g. `settings_foo`.

### Drawables

For icons use the file name format `ic_foo.xml`

All icons should be VectorDrawables where possible (nearly everywhere). VectorDrawables are created from SVGs that are then imported via Android Studio. We do not offer support options in the build system as the minimum Android version that is supported handles VectorDrawables. This process is in place to prevent the App APK size from growing.