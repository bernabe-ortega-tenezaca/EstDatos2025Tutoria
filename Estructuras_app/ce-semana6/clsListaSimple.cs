public class ListaSimple
{
    clsNodo head;

    public ListaSimple()
    {
        head = null;
    }

    public void InsertarInicio(string dato)
    {
        var nuevoNodo = new clsNodo(dato);

        nuevoNodo.Siguiente = head;
        head = nuevoNodo;
    }

    public void InsertarFinal(string dato)
    {
        clsNodo nuevoNodo = new clsNodo(dato);

        if (head == null)
        {
            head = nuevoNodo;
        }
        else
        {
            clsNodo actual = head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void EliminarInicio()
    {
        if (head != null)
        {
            head = head.Siguiente;
        }
    }

    public void EliminarFinal()
    {
        if (head != null)
        {
            if (head.Siguiente == null)
            {
                head = null;
            }
            else
            {
                clsNodo actual = head;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = null;
            }
        }
    }

    public clsNodo? buscar(string dato)
    {
        clsNodo? actual = head;
        if (head != null)
            while (actual != null && actual.Data != dato)
            {
                actual = actual.Siguiente;
            }
        return actual;
    }

    public void DibujarLista()
    {
        clsNodo? actual = head;
        Console.Write("head -->");
        while (actual != null)
        {
            Console.Write("[" + actual.Data + " |*]");
            if (actual.Siguiente != null)
            {
                Console.Write("-->");
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("--> null");
        System.Console.WriteLine();
    }
}