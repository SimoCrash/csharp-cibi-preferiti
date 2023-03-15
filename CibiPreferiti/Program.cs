string[] cibiPreferiti = { "Pizza", "Biscotti", "Pancakes", "Hamburger", "Tortellini", "Bacon", "Ciambelle" };

Console.WriteLine("I miei cibi preferiti sono:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    
Console.WriteLine(cibiPreferiti[i]);
}
Console.WriteLine("I miei cibi preferiti sono totalmente: " + cibiPreferiti.Length);
Console.WriteLine("La posizione in classifica in ordine è : " + cibiPreferiti[0] + ", " + cibiPreferiti[5] + ", " + cibiPreferiti[1] + ", " + cibiPreferiti[4] + ", " + cibiPreferiti[2] + ", " + cibiPreferiti[6] + ", " + cibiPreferiti[3]);
Console.WriteLine("Il mio cibo top è la " + cibiPreferiti[0] + ", ma 10 a 0 proprio");
Console.WriteLine("Il meno preferito è l'" + cibiPreferiti[3] + ", non che faccia schifo!");