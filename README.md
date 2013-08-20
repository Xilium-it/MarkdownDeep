markdowndeep
============

Open-source implementation of Markdown for C# and Javascript

This fork of original [topsoftware/markdowndeep] project implements some new feature:

* table with colspan
* cell style in table
* table with header in top and/or left side

## Table with colspan

Like MultiMarkdown, fspezi/markdowndeep implements table colspan:

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
