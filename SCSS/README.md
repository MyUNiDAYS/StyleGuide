<p align="center">
   <img src="https://assets1.unidays.world/v5/main/assets/images/logo_v003.svg" width="60%"/>
 </p>
<br/>

# UNiDAYS SCSS Coding Style Guide

[General Rules](#general-rules)

[SCSS File Naming Convention](#scss-file-naming-convention)

[SCSS Code Styles](#scss-code-styles)
  * [Class Naming Conventions](#class-naming-conventions)
  * [Modifiers](#modifiers)
  * [Formatting](#formatting)
  * [Nesting](#nesting)
  * [Avoid Tag Selectors](#avoid-tag-selectors)
  * [Mixins Extends and Placeholders](#mixins-extends-and-placeholders)
  * [Colour Palette](#colour-palette)

### General Rules

Keep your code DRY (Don't Repeat Yourself)
The aim with this isn't to avoid *all* repetition but to minimise repeated code where it is thematically related and/or meaningful to do so. 

The best approach is to write your code out fully (without using mixins, placeholders, variables etc) and then iterate; extracting out repeated chunks as necessary. 

### SCSS File Naming Convention

All files should be named using kebab-case where applicable.
For example: `c-component-name.scss`

File names should be the same name of the parent class within that file.

For example:
`c-menu-nav.scss`
```
.c-menu-nav
{
	//styles here
}
```




### SCSS Code Styles

#### Class Naming Conventions
Think of your CSS in a component based way and make your classes as reusable as possible. 

Prefix class names according to the following:<br> 
`.t-` typography styles<br>
This relates to any typography specific styles for headers or body copy. 

`.c-` component styles<br>
This relates to component specific styles. Aim to make these as reusable as possible. 
Avoid adding layout specific styles to these unless these styles will never be changed. For example avoid adding set margins and floats etc as these might need to be changed according to the layout these components live in. 

`.l-` layout styles<br>
These classes are used to define the layout of pages and determine how and where the components and text elements sit within the page.  

#### Modifiers

Modifiers are a varient or extension of a class. They should be used for giving a component an alternative style (for example an alternative colour) and should always be prefixed with a double hyphen.

For example:

```
.--highlighted
{
	background-color: #1dd577;
}
```

#### Formatting

Curly braces should start on a new line 

```
// Bad
.l-layout-class {
	.c-component-nested {
		float: left;
	}
}

// Good
.l-layout-class
{
	> .c-component-nested
	{
		float: left;
	}
}

```

#### Nesting

Do not nest selectors unnecessarily. This will increase specificity and limit the reusability of these styles. 

When nesting, use a child selector where possible.

```
// Bad
.l-example-class
{
	.c-example-nested
	{
		display: block;
	}
}

// Good
.l-example-class
{
	> .c-example-nested
	{
		display: block;
	}
}

```

#### Avoid Tag Selectors

Use classnames whenever possible. Tag selectors are fine, but they lessen the reusability of your styles and could come at a small performance penalty.

When you do need to use html tag selectors, try ensure they are nested within a class.  

```
// Bad
> picture
{
	> img
	{
	}
}

// Good
.c-image-holder
{
	> .c-image
	{
	}
}

```

#### Mixins Extends and Placeholders

Use these lightly, and only where it makes sense to use them. 

For example, this is a bad implementation because while border-radius is being repeated, using a mixin for it actually creates more code than neccessary and these two classes are not thematically related. 

```
// Bad
@mixin border-radius
{
	border-radius: 4px;
}

> .c-button
{
	@include border-radius;
}

> .c-content-block
{
	@include border-radius;
}
```

This is a good implementation as the button mixin has a number of properties that are used by all the different button types. The code is thematically related and is avoiding unecessary repetition. 

```
// Good
@mixin c-button
{
	display: block;
	box-sizing: border-box;
	height: 48px;
	width: 248px;
	padding: 16px 0;
	cursor: pointer;
}

.c-button-primary
{
	@include c-button;
	color: map-get($monotone, light);
	background-color: map-get($blue, base);
}

.c-button-secondary 
{
	@include c-button;
	background-color: map-get($monotone, light);
	color: map-get($blue, base);
	border: 2px solid map-get($blue, base);
}

```



#### Colour Palette

For our colour palettes we make use of SCSS maps to group colours together.  

An example of a colour map that groups all monotone shades together: 
```
$monotone: (
	xxDark: #000000,
	xDark: #676767,
	midDark: #999999,
	base: #cccccc,
	midLight: #efefef,
	light: #ffffff
);
```

To access the colours in a map use the following SCSS function `map-get($map, $key)`<br>
For example: 
```
.t-title
{
	color: map-get($monotone, xxDark)
}

.c-button
{
	border-color: 1px solid map-get($monotone, xxDark)
}
```
