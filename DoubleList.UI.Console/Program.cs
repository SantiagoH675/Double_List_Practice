using Double_List;

var list = new DoubleLinkedList<string>();
var opc = "0";

do
{
    opc = Menu();
    switch (opc)
    {
        case "0":
            Console.WriteLine("¡Regresa para otra lista.");
            break;

        case "1":
            Console.WriteLine("Ingresa el dato: ");
            list.InsertOrdered(Console.ReadLine()!);
            break;

        case "2":
            Console.WriteLine(list.GetForward());
            break;

        case "3":
            Console.WriteLine(list.GetBackward());
            break;

        case "4":
            list.InvertOrder();
            Console.WriteLine("La lista ha sido invertida (forma descendente).");
            break;

        case "5":
            Console.WriteLine("Entre el dato a buscar: ");
            list.Contains(Console.ReadLine()!);
            break;

        case "6":
            Console.WriteLine("Ingrese ocurrencia: ");
            var dataRemove = Console.ReadLine();
            list.Remove(dataRemove!);
            Console.WriteLine("Ocurrencia eliminada (si existía).");
            break;

        case "7":
            Console.WriteLine("Ingrese ocurrencias a eliminar: ");
            var dataRemoveAll = Console.ReadLine();
            int eliminated = list.RemoveAll(dataRemoveAll!);
            if (eliminated > 0)
                Console.WriteLine("Ocurrencias eliminadas correctamente.");
            else
                Console.WriteLine("No se encontraron coincidencias o lista vacía.");
            break;

        case "8":
            Console.WriteLine("Moda(s):");
            list.ShowModes();
            break;

        case "9":
            list.ShowGraph();
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opc != "0");
string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1. Adicionar dato.");
    Console.WriteLine("2. Mostrar hacia adelante.");
    Console.WriteLine("3. Mostarr hacia atras.");
    Console.WriteLine("4. Ordenar descendentemente");
    Console.WriteLine("5. Existe.");
    Console.WriteLine("6. Eliminar  una ocurrencia.");
    Console.WriteLine("7. Eliminar todas ocurrencias.");
    Console.WriteLine("8. Mostrar la(s) moda(s).");
    Console.WriteLine("9. Mostrar gráfico.");
    Console.WriteLine("0. Exit.");
    Console.WriteLine("ENTER YOUR OPTION");
    return Console.ReadLine()!;
}