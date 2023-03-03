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

foreach (var item in CreateListOfCharacters(dataFromTxtFile,3)) {
  Console.WriteLine(item);
}

//this function is responsible for creation of lists which will contain only specific number of chars
static IEnumerable<string> CreateListOfCharacters(string[] data, short numberOfChars) {
  return data.Where(str => str.Length == numberOfChars).ToList();
}

//this function will create enumeration of combined words by specifing lenght of chars that one want to combine (1-5 in our case)
static IEnumerable<CombinedWord> CreateCombinationList(string[] data, short firstNumber, short secondNumber) {
  return CreateListOfCharacters(data, firstNumber).SelectMany(s => CreateListOfCharacters(data, secondNumber).Select(c => new CombinedWord { FirstWord = s, SecondWord = c })).Distinct();
}

//this struct will be responsible for containing combined word
struct CombinedWord {
  public string FirstWord { get; set; }
  public string SecondWord { get; set; }
}