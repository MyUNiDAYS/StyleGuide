<p align="center">
  <img src="../assets/UNiDAYS_Logo.png" />
</p>
<br/>

# UNiDAYS DotNet Coding Style Guide

[DotNet Code Styles](#DotNet-code-styles)
  * [Usings](#usings)
  * [Namespaces](#namespaces)
  * [Classes](#classes)
  * [Private Fields](#private-fields)
  * [Public Fields](#public-fields)



### DotNet Code Styles

Tabs over spaces

### Usings

Usings should be at the top and outside of the namespace

### Namespaces

Namespaces are put after the usings.  Braces on new lines

```cs
namespace UD.Core
{

}
```
### Classes

- They are sealed by default
- Internal (no explicit modifier) by default
- Braces on new lines
- No Line Wrapping for extends or implements (`:`)
- Ordering of contents
    - Private Members
    - Public Members
    - Constructors
    - Public and Private Methods in a logical order
    - Interface implementations in the same order as on the interface

```cs
[Attribute]
[Attribute]
sealed class StyleGuide : IDisposable
{
    string anExamplePrivateField;
    public string AnExamblePublicField;
    public string PublicProperty {get; set;}
    string getter => "example;";

    public void StyleGuide()
    {

    }
}
```
### Private Fields
- Lower case first letter
- Camel Casing
- No explicit private modifier
- Placed at top of class

```cs
string anExamplePrivateField
```

### Public Fields
- Upper case first letter
- Camel Casing
- Placed after private members

```cs
public string AnExamplePublicField
```
