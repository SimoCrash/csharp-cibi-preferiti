string[] cibiPreferiti = { "Pizza", "Biscotti", "Pancakes", "Hamburger", "Tortellini", "Bacon", "Ciambelle" };

Console.WriteLine("I miei cibi preferiti sono:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    
Console.WriteLine(cibiPreferiti[i]);
}
Console.WriteLine("I miei cibi preferiti sono totalmente: " + cibiPreferiti.Length);
Console.WriteLine("La posizione in classifica in ordine è : " + cibiPreferiti[0] + ", " + cibiPreferiti[5] + ", " + cibiPreferiti[1] + ", " + cibiPreferiti[4] + ", " + cibiPreferiti[2] + ", " + cibiPreferiti[6] + ", " + cibiPreferiti[3]);