using PatronSingleton;

Singleton objeto1 = Singleton.Instance;
Singleton objeto2 = Singleton.Instance;

Console.WriteLine("Dirección de objeto 1: " + objeto1.GetHashCode());
Console.WriteLine("Dirección de objeto 2: " + objeto2.GetHashCode());