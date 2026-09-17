bool a = true;
bool b = false;
bool c = false;

bool domyslnie = a || b && c;
bool zNawiasami = (a || b) && c;

Console.WriteLine($"a || b && c = {domyslnie}");
Console.WriteLine($"(a || b) && c = {zNawiasami}");