<p align="center">
  <img src="../assets/UNiDAYS_Logo.png" />
</p>
<br/>

# UNiDAYS LESS Coding Style Guide

[LESS File Naming Convention](#less-file-naming-convention)

[LESS Code Styles](#LESS-code-styles)
  * [Naming Conventions](#naming-conventions)
  * [Modifiers](#modifiers)
  * [Nesting](#nesting)
  * [Avoid Tag Selectors](#avoid-tag-selectors)


### LESS File Naming Convention

All files should be named using kebab-case where applicable.


### LESS Code Styles

#### Naming Conventions
Think of your CSS in a component based way.
For example, you should never have to create two different button styles, instead use modifiers.

Prefix class names according to the following:<br> 
`.t-` typography styles<br>
`.c-` component styles<br>
`.l-` layout styles<br>

#### Modifiers

Modifiers should be used for giving a component an alternative style and should always be prefixed with a hyphen.

`.-secondary`

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