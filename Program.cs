// See https://aka.ms/new-console-template for more information

using Clipper2Lib;

Console.WriteLine("Hello, World!");

PathsD polyline = new PathsD();

double[] path = new[]
{
    100.100,
    1500.100,
    100.1500,
    1500.1500
};

polyline.Add(Clipper.MakePath(path));

// Offset polyline
PathsD solution = Clipper.InflatePaths(polyline, 200, JoinType.Miter, EndType.Square);

// Debug polyline
foreach (PathD pathObj in solution)
{
    Console.WriteLine(pathObj.ToString());
}