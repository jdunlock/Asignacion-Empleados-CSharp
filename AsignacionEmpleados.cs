using System;

class AsignacionEmpleados
{
    static void Main()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("          DR Service");
        Console.WriteLine(" CEO: Elian Rijo y Edgar De León");
        Console.WriteLine("=======================================\n");
        Console.WriteLine("Sistema de Asignación de Empleados a Departamentos\n");

        string[] empleados = new string[5];
        string[] departamentos = new string[5];
        string[] asignaciones = new string[5];

        Console.WriteLine("Ingrese los nombres de 5 empleados:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Empleado {i + 1}: ");
            empleados[i] = Console.ReadLine();
        }

        Console.WriteLine("\nIngrese los nombres de 5 departamentos:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Departamento {i + 1}: ");
            departamentos[i] = Console.ReadLine();
        }

        for (int i = 0; i < 5; i++)
        {
            asignaciones[i] = empleados[i] + " - " + departamentos[i];
        }

        Console.WriteLine("\nLista de empleados con sus departamentos asignados:");
        foreach (string asignacion in asignaciones)
        {
            Console.WriteLine(asignacion);
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
