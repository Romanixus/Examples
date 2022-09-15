Console.Clear();

int Ax = 50, Ay = 0;
int Bx = 0, By = 50;
int Cx = 100, Cy = 50;
int x = Ax, y = Ay;

Console.SetCursorPosition(Ax, Ay);
Console.Write("#");
Console.SetCursorPosition(Bx, By);
Console.Write("#");
Console.SetCursorPosition(Cx, Cy);
Console.Write("#");

int count = 0;
while (count < 100000)
{
    int ran = new Random().Next(0,3);
    if (ran == 0)
    {
        x = (x + Ax)/2;
        y = (y + Ay)/2;
    }
    if (ran == 1)
    {
        x = (x + Bx)/2;
        y = (y + By)/2;
    }
    if (ran == 2)
    {
        x = (x + Cx)/2;
        y = (y + Cy)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("#");
    count++;
}
Console.SetCursorPosition(0, 51);