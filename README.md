markdowndeep
============

Open-source implementation of Markdown for C# and Javascript

This fork of original [topsoftware/markdowndeep] project implements some new **Table** feature:

* **[multiple header rows](#multiple-header-rows)**: any row before separator-row will be added in `thead` tag of table.
* **[colspan](#colspan)**: you can define how many columns will be occuped by cell.
* **[Header style](#header-style)**: if content starts with # the tagname of cell will be `th` instead of `td`.
* **[cell alignment](#cell-alignment)**: you can customize alignment cell by cell.

This fork solves some minor issue in table:

* cell count wrong in tables with bad formatting

## Multiple header rows

Any row inserted before the "separator row" will be added in `thead` tag of table.

###### markdown text

```
| Your name  | Your name |   Home  | Home  | Office  | Office |   Office    |
| First name | Last name | address | city  | address | city   | Email       |
|:-----------|:----------|:--------|:-----:|:--------|:------:|:------------|
| Mark       | Deep      | ss...   | NY    | ss....  | WH     | aa@acme.com |
| James      | White     | ss...   | NY    | ss..    | CA     | bb@acme.com |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
```

###### Preview

<table>
<thead>
<tr>
	<th align="left">Your name</th>
	<th align="left">Your name</th>
	<th align="left">Home</th>
	<th align="center">Home</th>
	<th align="left">Office</th>
	<th align="center">Office</th>
	<th align="left">Office</th>
</tr>
<tr>
	<th align="left">First name</th>
	<th align="left">Last name</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">Email</th>
</tr>
</thead>
<tbody>
<tr>
	<td align="left">Mark</td>
	<td align="left">Deep</td>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss....</td>
	<td align="center">WH</td>
	<td align="left">aa@acme.com</td>
</tr>
<tr>
	<td align="left">James</td>
	<td align="left">White</td>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss..</td>
	<td align="center">CA</td>
	<td align="left">bb@acme.com</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
</tbody>
</table>


## colspan

Like MultiMarkdown, **fspezi/markdowndeep** implements table colspan:

###### markdown text

```
|       Your name       ||       Home     ||         Office              |||
| First name | Last name | address | city  | address | city  | Email       |
|:-----------|:----------|:--------|:-----:|:--------|:-----:|:------------|
| Mark       | Deep      | ss...   | NY    | ss....  | WH    | aa@acme.com |
| James      | White     | ss...   | NY    | ss..    | CA    | bb@acme.com |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
```

###### Preview

<table>
<thead>
<tr>
	<th align="left" colspan="2">Your name</th>
	<th align="left" colspan="2">Home</th>
	<th align="left" colspan="3">Office</th>
</tr>
<tr>
	<th align="left">First name</th>
	<th align="left">Last name</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">Email</th>
</tr>
</thead>
<tbody>
<tr>
	<td align="left">Mark</td>
	<td align="left">Deep</td>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss....</td>
	<td align="center">WH</td>
	<td align="left">aa@acme.com</td>
</tr>
<tr>
	<td align="left">James</td>
	<td align="left">White</td>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss..</td>
	<td align="center">CA</td>
	<td align="left">bb@acme.com</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
</tbody>
</table>



Any `|` added to the end of cell will be counted to determine the **colspan value**.


## Header style

You can mark any cell to declare it as *Header cell*.

###### markdown text

```
|       Your name       ||       Home     ||         Office              |||
| First name | Last name | address | city  | address | city  | Email       |
|:-----------|:----------|:--------|:-----:|:--------|:-----:|:------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
```

###### Preview

<table>
<thead>
<tr>
	<th align="left" colspan="2">Your name</th>
	<th align="left" colspan="2">Home</th>
	<th align="left" colspan="3">Office</th>
</tr>
<tr>
	<th align="left">First name</th>
	<th align="left">Last name</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">Email</th>
</tr>
</thead>
<tbody>
<tr>
	<th align="left">Mark</th>
	<th align="left">Deep</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss....</td>
	<td align="center">WH</td>
	<td align="left">aa@acme.com</td>
</tr>
<tr>
	<th align="left">James</th>
	<th align="left">White</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss..</td>
	<td align="center">CA</td>
	<td align="left">bb@acme.com</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
</tbody>
</table>



Start the cell with `# ` string: Markdown will be render that cell with `th` tag instead of `td`.

**Note:** this feature don't works with header cells.

## Cell alignment

You can customize horizontal alignment of any cell.

###### markdown text

```
|:       Your name     :||:      Home    :||:         Office            :|||
| First name | Last name | address | city  | address | city  | Email       |
|:-----------|:----------|:--------|:-----:|:--------|:-----:|:------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
```

###### Preview

<table>
<thead>
<tr>
	<th align="center" colspan="2">Your name</th>
	<th align="center" colspan="2">Home</th>
	<th align="center" colspan="3">Office</th>
</tr>
<tr>
	<th align="left">First name</th>
	<th align="left">Last name</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">Email</th>
</tr>
</thead>
<tbody>
<tr>
	<th align="left">Mark</th>
	<th align="left">Deep</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss....</td>
	<td align="center">WH</td>
	<td align="left">aa@acme.com</td>
</tr>
<tr>
	<th align="left">James</th>
	<th align="left">White</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss..</td>
	<td align="center">CA</td>
	<td align="left">bb@acme.com</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
</tbody>
</table>



Use the same syntax of alignment when you define it in separator-row.

**Note:** if you want define "left or center alignment" and "header style" together, type `:` before `#`.

###### markdown text

```
|:       Your name     :||:      Home    :||:          Office              :|||
| First name | Last name | address | city  | address | city  | Email          |
|:-----------|:----------|:--------|:-----:|:--------|:-----:|:---------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com    |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com    |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|                                                       ||||||:# 6 employees :|
```

###### Preview

<table>
<thead>
<tr>
	<th align="center" colspan="2">Your name</th>
	<th align="center" colspan="2">Home</th>
	<th align="center" colspan="3">Office</th>
</tr>
<tr>
	<th align="left">First name</th>
	<th align="left">Last name</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">address</th>
	<th align="center">city</th>
	<th align="left">Email</th>
</tr>
</thead>
<tbody>
<tr>
	<th align="left">Mark</th>
	<th align="left">Deep</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss....</td>
	<td align="center">WH</td>
	<td align="left">aa@acme.com</td>
</tr>
<tr>
	<th align="left">James</th>
	<th align="left">White</th>
	<td align="left">ss...</td>
	<td align="center">NY</td>
	<td align="left">ss..</td>
	<td align="center">CA</td>
	<td align="left">bb@acme.com</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<th align="left">...</th>
	<th align="left">...</th>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
	<td align="center">...</td>
	<td align="left">...</td>
</tr>
<tr>
	<td align="left" colspan="6"></td>
	<th align="center">6 employees</th>
</tr>
</tbody>
</table>



## The MIT License (MIT)

Copyright (c) 2013 Xilium di Flavio Spezi - Italy

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
documentation files (the "Software"), to deal in the Software without restriction, including without limitation
the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions
of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
IN THE SOFTWARE.
