using System.Linq.Expressions;
using Microsoft.VisualBasic;

//Ici j'ai appris à gérer les liste et tableau 

System.Console.WriteLine($"Bienvenue dans le programme Collections !!, Ici nous allons abordées les listes et tableaux + Ienumerable");
////Créer un tableau 
string[] notreTableau = new string[5] {"test1", "test2", "test3", "test4", "test5"};
int[] nbr = [1,2,3,4,5,6,7,8,9];
var nbrTrier = nbr.OrderByDescending(x => x).ToList();
for (int i = 0; i < nbrTrier.Count(); i++)
{
    System.Console.WriteLine($"Numéro {nbrTrier[i]} tableau");
}

////Créer une List
List<string> notreList = new List<string>();
notreList.Add("Ajout numéro 1");
notreList.Add("TestWhere");
notreList.Add("TestWhere");
notreList.RemoveAt(1); //Supp par index
notreList.Count();
notreList.Order();
//-- Récupère tout les items avec ce paramètres en iEnumerable
var items = notreList.Where(item => item == "TestWhere");
//-- Compte toute les items correspondants
var count = notreList.Count(item => item == "TestWhere");
//-- Prend le premier item correpondant 
var item = notreList.First(item => item == "TestWhere");  
//-- Trier la liste
var itemTrier = notreList.Order();                       
foreach (var i in items)
{
    System.Console.WriteLine($"Résultats du where === {i}, {count} résultat(s) ont été trouvée");
    System.Console.WriteLine($"Résultat du First === {item}");
}
foreach (var i in itemTrier)
{
    System.Console.WriteLine($"{i} --");
}

////Exo Creér un fonction permettant de savoir si un item est dupliquer dans une list (2 méthodes)
//Prems Méthode
bool dupliquerCheck(string[] a){
     var listTrier = a.OrderBy(x => x).ToList();
        for (int i = 0; i < listTrier.Count() - 1; i++)  
        {
            if (listTrier[i] == listTrier[i + 1])
            {
                return true;
            }
        }
    return false;
}
System.Console.WriteLine($"test de ma fonction dupliquerCheck {dupliquerCheck(notreTableau)}");
//Deuxième méthode
bool checkCool<T>(IEnumerable<T> a){
    return a.ToHashSet().Count() != a.Count();
}
System.Console.WriteLine($"test de ma fonction checkCool {checkCool(notreTableau)}");




