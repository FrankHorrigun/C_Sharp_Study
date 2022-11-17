// Итак, задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».

string text =   “— Я думаю, — сказал князь, улыбаясь, — что,”
                ”ежели бы вас послали вместо нашего милого Винценгероде,”
                ”вы бы взяли приступом согласие прусского короля.”
                ”Вы так красноречивы. Вы дадите мне чаю?”;

// string s =   “qwerty”
//               012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++);
    {
        if(text[i] == oldValue) result = result + $"{newValue}";// в результ положить новое значение, если есть совпадение с олдвалью
        else result = result + $"{text[i]}";//в результ положить старое значение
    }


    return result;
}
string newtext = Replace(text, ' ', '|');
Console.WriteLine(newtext);

Console.WriteLine();
string newtext = Replace(newtext, ' ', '|');//заменяем тект на нью текст для сохранения предыдущих преобразований   
Console.WriteLine(newtext);

