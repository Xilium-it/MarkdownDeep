markdowndeep
============

Open-source implementation of Markdown for C# and Javascript

This fork of original [topsoftware/markdowndeep] project implements some new **Table** feature:

* **multiple header rows**: any row before separator-row will be added in `thead` tag of table.
* **colspan**: you can define how many columns will be occuped by cell.
* **Header style**: if content starts with # the tagname of cell will be `th` instead of `td`.
* **cell alignment**: you can customize alignment cell by cell.

This fork solves some minor issue in table:

* cell count wrong in tables with bad formatting

## Multiple header rows

Any row inserted before the "separator row" will be added in `thead` tag of table.

```
| Your name  | Your name |   Home  | Home  | Office  | Office |   Office    |
| First name | Last name | address | city  | address | city   | Email       |  
|------------|-----------|---------|-------|---------|--------|-------------|
| Mark       | Deep      | ss...   | NY    | ss....  | WH     | aa@acme.com |
| James      | White     | ss...   | NY    | ss..    | CA     | bb@acme.com |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
| ...        | ...       | ...     | ...   | ...     | ...    | ...         |
```

## colspan

Like MultiMarkdown, **fspezi/markdowndeep** implements table colspan:

```
|       Your name       ||       Home     ||         Office              |||  
| First name | Last name | address | city  | address | city  | Email       |  
|------------|-----------|---------|-------|---------|-------|-------------|
| Mark       | Deep      | ss...   | NY    | ss....  | WH    | aa@acme.com |
| James      | White     | ss...   | NY    | ss..    | CA    | bb@acme.com |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
| ...        | ...       | ...     | ...   | ...     | ...   | ...         |
```

Any `|` added to the end of cell will be counted to determine the **colspan value**.


## Header style

You can mark any cell to declare it as *Header cell*.

```
|       Your name       ||       Home     ||         Office              |||  
| First name | Last name | address | city  | address | city  | Email       |  
|------------|-----------|---------|-------|---------|-------|-------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
```

Start the cell with `# ` string: Markdown will be render that cell with `th` tag instead of `td`.

**Note:** this feature don't works with header cells.

## Cell alignment

You can customize horizontal alignment of any cell.

```
|:       Your name     :||:      Home    :||:         Office            :|||
| First name | Last name | address | city  | address | city  | Email       |
|------------|-----------|---------|-------|---------|-------|-------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...         |
```

Use the same syntax of alignment when you define it in separator-row.

**Note:** if you want define "left or center alignment" and "header style" together, type `:` before `#`.

```
|:       Your name     :||:      Home    :||:          Office              :|||
| First name | Last name | address | city  | address | city  | Email          |
|------------|-----------|---------|-------|---------|-------|----------------|
|# Mark      |# Deep     | ss...   | NY    | ss....  | WH    | aa@acme.com    |
|# James     |# White    | ss...   | NY    | ss..    | CA    | bb@acme.com    |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|# ...       |# ...      | ...     | ...   | ...     | ...   | ...            |
|                                                       ||||||:# 6 employees :|
```
