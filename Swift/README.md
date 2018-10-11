<p align="center">
  <img src="../assets/UNiDAYS_Logo.png" />
</p>
<br/>

# UNiDAYS Swift Coding Style Guide
[Code Formatting](#code-formatting)
  * [Spacing](#spacing)
  * [Line Length](#line-length)
  * [Braces](#braces)
  * [Semicolons](#semicolons)

[Code Styles](#code-styles)
  * [Enums](#enums)
  * [Type Inference](#type-inference)
  * [Syntactic Sugar](#type-inference)
  * [Happy Path](#happy-path)

## Code Formatting
### Spacing
Use 4 spaces for tabs. Ensure that there is a no trailing whitespace anywhere and ensure that there is a newline at the end of every file. All of these can be configured in `Xcode -> Preferences -> Text Editing`.

### Line Length
Each line should have a maximum of 160 characters per line, you may find it useful to setup page guides `Xcode -> Preferences -> Text Editing -> Page Guide at column`.

### Braces
Open braces on the same line as the statement but close on a new line.
#### Preferred:
```
if user.isStudent {
    // Do something
}
```

#### Not Preferred:
```
if user.isStudent
{
    // Do something
}
```

### Semicolons
Semicolons are only required if you wish to combine multiple statements on a single line. Do not write multiple statements on a single line separated with semicolons.

#### Preferred:
```
let x = 1
let y = 2
```

#### Not Preferred:
```
let x = 1; let y = 2;
```

## Code Styles
### Enums
Enums should use upper-case first letter camel casing for the type name and each case should have its own line and should be camcel cased. Where practical, enums should have their values explicitly declared.
#### Preferred:
```
enum MyEnum {
    case aRedEnum
    case aBlueEnum
}

enum SomeEnum: Int {
    case aRedEnum = 1
    case aBlueEnum = 2
}
```

#### Not Preferred:
```
enum myEnum {
    case aRedEnum
    case aBlueEnum
}

enum SomeEnum: Int {
    case ARedEnum = 1
    case ABlueEnum = 2
}
```

### Type Inference
Let the compiler infer the type for constants. Only specify the specific type when required, such as `CGFloat`.
#### Preferred:
```
let name = "UNiDAYS"
let colour = getMedianColour()
let width: CGFloat = 15.0
```

#### Not Preferred:
```
let name: String = "UNiDAYS"
let colour: UIColor = getMedianColour()
```

### Syntactic Sugar
Avoid using the full generics syntax for type declarations.
#### Preferred:
```
var names: [String]
var students: [Int: String]
var yearOfStudy: Int?
```

#### Not Preferred:
```
var names: Array<String>
var students: Dictionary<Int, String>
var yearOfStudy: Optional<Int>
```

### Happy Path
When dealing with conditionals, the left-hand margin of the code should be the happy path. Do not nest `if` statements and make use of `guard` statements.
#### Preferred:
```
func sendEmail(student: Student?, content: String?) {
    guard let student = student else {
        return
    }
    guard let content = content else {
        return
    }
    // Do something
}
```

#### Not Preferred:
```
func sendEmail(student: Student?, content: String?) {
    if let student = student {
        if let content = content {
            // Do something
        } else {
            return
        }
    } else {
        return
    }
}
```
