string[] cibiPreferiti = { "Pizza", "Biscotti", "Pancakes", "Hamburger", "Tortellini", "Bacon", "Ciambelle" };

Console.WriteLine("I miei cibi preferiti sono:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    
Console.WriteLine(cibiPreferiti[i]);
}
Console.WriteLine("I miei cibi preferiti sono totalmente: " + cibiPreferiti.Length);
Console.WriteLine("La top 3 in ordine è : " + cibiPreferiti[0] + ", " + cibiPreferiti[5] + ", " + cibiPreferiti[1]);