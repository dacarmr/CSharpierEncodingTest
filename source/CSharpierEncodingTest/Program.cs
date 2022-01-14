using System.Diagnostics;

const char test = '。';
const string test1 = "こにちは、世界！";
var encoding = System.Text.Encoding.Default;
Console.OutputEncoding = encoding;
Console.InputEncoding = encoding;

// Outputting to console may/may not work correctly. At least in my environment I have to change the font to MSMincho or MSGothic.
Console.WriteLine(test);
// This line should output correctly.
Debug.WriteLine($"{test} {test1}");
