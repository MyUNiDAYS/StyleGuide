# UNiDAYS Javascript Coding Style Guide

### JS Hooks
Anywhere you are using Javascript to attach to the DOM, use js-hooks instead of CSS classes. 

`<p class="js-class-example-valid-device"></p>`

This will keep your JS logic seperate from the styling layout making it easier to change CSS properties 
and assign JS logic to many CSS component types.

### JS Code Styles

#### Naming Conventions
Avoid single letter names. Be descriptive with your naming.
```
// bad
function q() {
  // ...
}

// good
function query() {
  // ...
}
```

Use camelCase when naming objects, functions, and instances.
```
// bad
var OBJEcttsssss = {};
var this_is_my_object = {};
function c() {}

// good
var thisIsMyObject = {};
function thisIsMyFunction() {}
```

Use PascalCase only when naming constructors or classes.
```
// bad
function user(options) {
  this.name = options.name;
}

const bad = new user({
  name: 'nope',
});

// good
class User {
  constructor(options) {
    this.name = options.name;
  }
}

var good = new User({
  name: 'yup',
});
```

Do not use trailing or leading underscores in public methods or properties. 
Only private methods and properties start with single leading underscore. 
```
// bad
this.__firstName__ = 'Panda';
this.firstName_ = 'Panda';

// good for private only
this._firstName = 'Panda';

// good for public only
this.firstName = 'Panda';
```

#### Properties
Use dot notation when accessing properties.

```
var luke = {
  jedi: true,
  age: 28,
};

// bad
var isJedi = luke['jedi'];

// good
var isJedi = luke.jedi;
```

Use bracket notation `[]` when accessing properties with a variable.
```
var luke = {
  jedi: true,
  age: 28,
};

function getProp(prop) {
  return luke[prop];
}

var isJedi = getProp('jedi');
```


#### Comparison Operators & Equality
Use `===` and `!==` over `==` and `!=`
```
var i = 100;
var equalsComparison = (i === 100); // true
var notEqualsComparison = (i !== 100); // false
```

Use shortcuts for booleans, but explicit comparisons for strings and numbers.

```
// bad
if (isValid === true) {
  // ...
}

// good
if (isValid) {
  // ...
}

// bad
if (name) {
  // ...
}

// good
if (name !== '') {
  // ...
}

// bad
if (collection.length) {
  // ...
}

// good
if (collection.length > 0) {
  // ...
}
```
If specifically checking for null or undefined
```
//bad
if (thing !== null && thing !== undefined)

//good
if (thing != null)

```

#### Blocks
Use braces with all multi-line blocks
```
// bad
if (test)
  return false;

// good
if (test) return false;

// good
if (test) {
  return false;
}

// bad
function foo() { return false; }

// good
function bar() {
  return false;
}
```

If you're using multi-line blocks with `if` and `else`, put `else` on the same line as your `if` block’s closing brace. 
```
// bad
if (test) {
  thing1();
  thing2();
}
else {
  thing3();
}

// good
if (test) {
  thing1();
  thing2();
} else {
  thing3();
}
```

#### `null` vs `undefined`

`undefined` means a variable has been declared but has not yet been assigned a value.
```
var testValue;
console.log(testValue); // returns undefined
```

`null` is an assignment of a value when an object. It can be assigned to a variable as a representation of no value.
```
var testValue;
var i = 100;
if (i === 101) {
	testValue = 102;
} else {
	testValue = null;
}
```

#### Arrays

```
// bad
var items = new Array();

// good
var items = [];
```

```
var someStack = [];

// bad
someStack[someStack.length] = 'abracadabra';

// good
someStack.push('abracadabra');
```

#### Strings
Use single quotes `''` for strings

```
var name = 'J Rock';
```

Do not break long strings over multiple lines. This makes code less searchable and worse for merge conflicts.

```
// bad
var description = 'This is a super long error that was thrown because of Batman. ' +
	'When you stop to think about how Batman had anything to do with this, you would ' +
	'get nowhere fast.';
	
// good
var description = 'This is a super long error that was thrown because of Batman. When you stop to think about how Batman had anything to do with this, you would get nowhere fast.';
```

#### Functions
Use named function expressions. This will allow you to spot more easily when a function isn't already
defined.

```
// bad
function foo() {
	// ...
}

// good
var foo = function longDescriptionOfWhatThisFunctionIs() {
	// ...
};

```

#### jQuery
Prefix jQuery object variables with a `$`
```
// bad
var sidebar = $('.sidebar');

// good
var $sidebar = $('.sidebar');

// good
var $sidebarBtn = $('.sidebar-btn');
```

Cache jQuery lookups
```
// bad
function setSidebar() {
  $('.sidebar').hide();

  // ...

  $('.sidebar').css({
    'background-color': 'pink',
  });
}

// good
function setSidebar() {
  var $sidebar = $('.sidebar');
  $sidebar.hide();

  // ...

  $sidebar.css({
    'background-color': 'pink',
  });
}
```
