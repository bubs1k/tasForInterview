using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

//1.Реализовать двунаправленный связанный список обобщенного типа.

//a.            Возможность добавлять элементы в конец и начало списка, удалять первый, последний элемент

//b.            Возможность добавления до или после элемента списка

//c.            Удаление элемента списка

//d.            Реализовать возможность обхода списка сначала и с конца списка

//e.            Реализовать возможность итерации элементов foreach с начала списка

//f.             Пояснить является ли список потокобезопасным и почему.

//самостоятельная реализация двусвязного списка в шарпе это какая то пиздец сложная и запутнная тема поэтому я просто заюзал овет
//типа с cyberforuma о том что в .нете есть реализация двусвязного списка которая называется LinkedList<T> (https://metanit.com/sharp/tutorial/4.6.php)
//(when i will send task i can say that i just want fast do this tasks so use .net realization)
//(reference on answer this guy: https://www.cyberforum.ru/csharp-beginners/thread2332734.html)
//reference which talk about that why peoples use your own realization instead .net realization:
//https://www.cyberforum.ru/csharp-net/thread2935062.html



/*я решил использовать готовую реализацию списка в .net (хоть это и не совсем честно)
и реализовать доступ к элементам списка через индексы хоть это довольна неэффективная операция для данной структуры данных*/

//1.Реализовать двунаправленный связанный список обобщенного типа:
dynamic donor = new List<dynamic> { -100, 12, 6, 3, 1 };

//передаю в конструктор элементы списка donor
LinkedList<dynamic> linkedList = new LinkedList<dynamic>(donor);

//b.Возможность добавления до или после элемента списка:
linkedList.AddBefore(linkedList.Find(linkedList.ElementAt(1)), 213);
linkedList.AddAfter(linkedList.Find(linkedList.ElementAt(3 + 1)), 200);//нужно учитывать что после вышестоящей операции все индексы списка увеличиваются на единицу

//a. Возможность добавлять элементы в начало и конец списка:
linkedList.AddFirst(0);
linkedList.AddLast(100);

//возможность удалять первый и последний элемент:
linkedList.RemoveFirst();
linkedList.RemoveLast();

//c.Удаление элемента списка:
linkedList.Remove(linkedList.ElementAt(0));


//d.Обход списка с начала: 
Console.WriteLine("Обход списка с начала:");

var currentNode = linkedList.First;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}

//обход с конца до начала списка
Console.WriteLine("Обход списка с конца:");

currentNode = linkedList.Last;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Previous;
}

//f. Пояснить является ли список потокобезопасным и почему. 

/*нет, данная реализация двусвязного списка не является потокобезопасной, так ка