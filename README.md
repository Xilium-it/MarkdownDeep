markdowndeep
============

Open-source implementation of Markdown for C# and Javascript

This fork of original [topsoftware/markdowndeep] project implements some new feature:

* table with colspan
* cell style in table
* table with header in top and/or left side

## Table with colspan

Like MultiMarkdown, fspezi/markdowndeep implements table colspan:

|       Your name        |  Home address  | Office address |
| First name | Last name | address | city | address | city |
|------------|-----------|---------|------|---------|------|
| Mark       | Deep      | ss...   | NY   | ss....  | WH   |
| James      | White     | ss...   | NY   | ss..    | CA   |
| ...        | ...       | ...     | ...  | ...     | ...  |
| ...        | ...       | ...     | ...  | ...     | ...  |
| ...        | ...       | ...     | ...  | ...     | ...  |
| ...        | ...       | ...     | ...  | ...     | ...  |
