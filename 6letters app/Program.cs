/*
There's a file, that contains words of varying lengths (1 to 6 characters).
Your objective is to show all combinations of those words that together form a word of 6 characters.
That combination must also be present in the text file.
E.g.:
foobar
fo
obar
should result in the ouput:
fo+obar=foobar
You can start by only supporting combinations of two words and improve the algorithm at the end of the exercise to support any combinations.
Be mindful of changing requirements like a different maximum combination length, or a different source of the input data.
Don't spend too much time on this. When submitting the exercise, briefly write down where you would improve the code if you were given more time.
*/

//So to form 6 character string we need to take 1+5 or 2+4 or 3+3
// We are not counting 6+0 because combination requires at least two parts to be connected
// first of all we need to read all data from file

string[] dataFromTxtFile = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Data\\6letters (1).txt"));

