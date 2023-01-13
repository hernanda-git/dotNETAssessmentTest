# .NET Assessment Test by AKASIA

## The Tasks:
1. Write a program that prints the numbers from 1 to 100. However, for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

Example:
If the number is 3, 6, 9 etc… (multiple of 3) print “Fizz”.
If the number is 5, 10, 15 etc… (multiple of 5) print “Buzz”.
If the number is 15, 30 etc… (multiple of 3 and 5) print “FizzBuzz”. 	
If the number is none of the above print the number.

The program is to be written as a C# console application.
The program should show clear separation of concerns in your application design. i.e. you should be separating your application logic by its function.
The application should be written in C# using .Net Framework 4.5 or higher.

Your application/solution should be buildable and runnable.


2. Create a HTML page showing a list of 5 items from which the user can choose one at a time. The page will have the following features/functions.
- When the user clicks an item in the list, an alert box will be displayed showing the content of the item that was clicked.
- The text of the item which is clicked will turn bold.
- When a new item is clicked the format from the first item will be removed (the first item will no longer be bold).
- When the user hovers over an item, the item will be highlighted.
- The list should be centered on the page both horizontally and vertically.
- Your CSS and JavaScript should be cross-browser compatible and at minimum work in the latest versions of Internet Explorer, Chrome and Firefox.
- You can include your JavaScript and CSS within the .HTML file if desired.

3. Consider a table with an [Id] column as well as BIT columns named [A] to [E] and some initial values:

CREATE TABLE #TEST2 ([Id] INT, [A] BIT, [B] BIT, [C] BIT, [D] BIT, [E] BIT)
INSERT INTO #TEST2 ([Id], [A], [C], [E]) VALUES (1, 'true', 'false', 'true')
INSERT INTO #TEST2 ([Id], [A], [B], [C]) VALUES (2, 'true', 'true', 'true')
INSERT INTO #TEST2 ([Id], [C], [D], [E]) VALUES (1, 'false', 'false', 'true')
Create a procedure which will accept parameters ([Id] INT, [Column] CHAR (1))

and then invert the value in table #TEST2 for row matched by [Id] and column named [Column]. 
No change is made if existing value is NULL.
