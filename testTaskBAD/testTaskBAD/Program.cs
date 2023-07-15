using testTaskBAD;

string string_first = @"The Tao gave birth to machine language.  Machine language gave birth
to the assembler.
The assembler gave birth to the compiler.  Now there are ten thousand
languages.
Each language has its purpose, however humble.  Each language
expresses the Yin and Yang of software.  Each language has its place within
the Tao.
But do not program in COBOL if you can avoid it.
        -- Geoffrey James, ""The Tao of Programming"" ";

string string_second = "C makes it easy for you to shoot yourself in the foot. C++ makes that harder, but when you do, it blows away your whole leg. (с) Bjarne Stroustrup";


LetterChecker checker = new LetterChecker();

Console.WriteLine(checker.find_least_repeated_letter(string_first));
Console.WriteLine(checker.find_least_repeated_letter(string_second));