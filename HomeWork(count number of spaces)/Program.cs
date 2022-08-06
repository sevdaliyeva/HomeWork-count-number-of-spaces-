// See https://aka.ms/new-console-template for more information


int count = 0, index = 0, lastIndex = 0;
string s = "    this is a string";

index = s.IndexOf(" ");
while (index > -1)
{
    count++;
    index = s.IndexOf(" ", index + 1);

    if ((index - lastIndex) > 1)
        break;

    lastIndex = index;
}

Console.WriteLine(count);

