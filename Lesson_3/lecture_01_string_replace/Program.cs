/*
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "C" заменить маленькими "c".
*/

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result =  result + newValue;
        }
        else
        {
            result = result + text[i];
        }
    }
    return result;
}


string text = "Помните, что вы будете отвечать за все последствия. Cтрого Cказал князь Василий,";
Console.WriteLine(text);
string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'C', 'с');
Console.WriteLine(newText);