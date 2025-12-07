//Task 1
Vector3D v1 = new Vector3D(9, 10, 11);
Vector3D v2 = new Vector3D(12, 13, 14);

Console.Write("v1 = ");
v1.Show();
Console.Write("v2 = ");
v2.Show();

Console.WriteLine();

Vector3D.Mult(v1, 2);
Vector3D.Sum(v1, v2);
Vector3D.Diff(v1, v2);


//Task 2
DEC n1 = new DEC(252);
DEC n2 = new DEC(1421);


Console.Write("First number: ");
n1.Show();
Console.Write("Second number: ");
n2.Show();

Console.WriteLine();

n1.ToBIN();
n2.ToBIN();

Console.WriteLine();

n1.ToOCT();
n2.ToOCT();

Console.WriteLine();

n1.ToHEX();
n2.ToHEX();


//Task 3
RGBColor color1 = new RGBColor(52,12,199);
RGBColor color2 = new RGBColor(42,1,123);

Console.Write("First color:");
color1.Show();
Console.Write("Second color:");
color2.Show();

Console.WriteLine();

color1.ToHEX();
color2.ToHEX();

Console.WriteLine();

color1.ToHSL();
color2.ToHSL();

Console.WriteLine();

color1.ToCMYK();
color2.ToCMYK();

