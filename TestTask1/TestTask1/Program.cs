using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

//1.Реализовать двунаправленный связанный список обобщенного типа.

//a.Возможность добавлять элементы в конец и начало списка, удалять первый, последний элемент

//b.Возможность добавления до или после элемента списка

//c.Удаление элемента списка

//d.Реализовать возможность обхода списка сначала и с конца списка

//e.Реализовать возможность итерации элементов foreach с начала списка

//f.Пояснить является ли список потокобезопасным и почему.

/*Я решил использовать "стандартную" реализацию списка в .net (хоть это было и не совсем честно)
и реализовать доступ к элементам списка через индексы, хоть это довольно неэффективная операция для данной структуры данных*/

//1.Реализовать двунаправленный связанный список обобщенного типа:
dynamic donor = new List<dynamic> { -100, 12, 6, 3, 1 };

//передаю в конструктор элементы списка donor
LinkedList<dynamic> linkedList = new LinkedList<dynamic>(donor);

//b.Возможность добавления до или после элемента списка:
linkedList.AddBefore(linkedList.Find(linkedList.ElementAt(1)), 213);
linkedList.AddAfter(linkedList.Find(linkedList.ElementAt(3 + 1)), 200);//Нужно учитывать, что после вышестоящей операции все индексы списка инкрементируются

//a.Возможность добавлять элементы в начало и конец списка:
linkedList.AddFirst(0);
linkedList.AddLast(100);

//возможность удалять первый и последний элемент:
linkedList.RemoveFirst();
linkedList.RemoveLast();

//c.Удаление элемента списка:
linkedList.Remove(linkedList.ElementAt(0));


//d.Обход списка с начала: 

var currentNode = linkedList.First;

while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);

    currentNode = currentNode.Next;
}

//Обход списка с конца 

currentNode = linkedList.Last;

while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);

    currentNode = currentNode.Previous;
}

//f.Пояснить является ли список потокобезопасным и почему. 

/*Нет, данная реализация двусвязного списка не является потокобезопасной, так как для записи данных из нескольких потоков данная конструкция непригодна,
*поэтому, для обеспечения потокобезопасности,
*нам потребуется вручную прописывать механизм синхронизации. Eсли нам требуется использовать потокобезопасные коллекции, 
*мы можем взять, например, BlockingCollection */





