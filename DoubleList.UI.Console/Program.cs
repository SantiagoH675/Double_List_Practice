using Double_List;

var list = new DoubleLinkedList<string>();
list.InsertAtBeginning("Perro");
list.InsertAtBeginning("Gato");
list.InsertAtBeginning("Loro");
Console.WriteLine(list.GetForward());
Console.WriteLine(list.GetBackward());