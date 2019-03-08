<p align="center">
   <img src="https://assets1.unidays.world/v5/main/assets/images/logo_v003.svg" width="60%"/>
 </p>
<br/>

# UNiDAYS SCSS Coding Style Guide

[SCSS File Naming Convention](#scss-file-naming-convention)

[SCSS Code Styles](#scss-code-styles)
  * [Naming Conventions](#naming-conventions)
  * [Modifiers](#modifiers)
  * [Nesting](#nesting)
  * [Avoid Tag Selectors](#avoid-tag-selectors)


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

#### Naming Conventions
Think of your CSS in a component based way.
For example, you should never have to create two different button styles, instead use modifiers.

Prefix class names according to the following:<br> 
`.t-` typography styles<br>
This related to any typography specific styles for headers or body copy. 

`.c-` component styles<br>
This related to component specific styles. Aim to make these are reusable as possible and avoid adding layout specific styles to these - for example avoid adding set margins, floats etc as these might need to be changed according to the layout these components live in. 

`.l-` layout styles<br>
These classes are used to define the layout of pages and determine how and where the components sit within the page.  

#### Modifiers

Modifiers should be used for giving a component an alternative style and should always be prefixed with a double hyphen.

`.--highlight`

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
