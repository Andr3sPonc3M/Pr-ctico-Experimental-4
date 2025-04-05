
// Práctico Experimental #4.

// Tema Escogido: Gráfica de árboles.

// Importa el espacio de nombres System
using System;
// Importa un espacio de nombres para usar listas genéricas
using System.Collections.Generic;

// Definimos una clase llamada Nodo para representar cada nodo del árbol
public class Nodo
{
    // Propiedad que almacena el valor (texto o dato) que contiene el nodo
    public string Valor { get; set; }

    // Lista que contiene los nodos hijos del nodo actual
    public List<Nodo> Hijos { get; set; }

    // Constructor de la clase Nodo que recibe un valor como parámetro
    public Nodo(string valor)
    {
        Valor = valor; // Asigna el valor recibido al nodo
        Hijos = new List<Nodo>(); // Inicializa la lista de hijos vacía
    }

    // Método que permite agregar un hijo al nodo actual
    public void AgregarHijo(Nodo hijo)
    {
        Hijos.Add(hijo); // Añade el nodo hijo a la lista de hijos
    }
}

// Clase principal del programa
public class Program
{
    // Método estático que imprime el árbol en formato jerárquico
    // Recibe un nodo, un prefijo opcional (para formato visual) y un booleano que indica si es el último hijo
    public static void ImprimirArbol(Nodo nodo, string prefijo = "", bool esUltimo = true)
    {
        // Imprime el prefijo correspondiente a la rama actual del árbol
        Console.Write(prefijo);

        // Imprime el conector según si es el último hijo o no (estética del árbol)
        Console.Write(esUltimo ? "└── " : "├── ");

        // Imprime el valor del nodo actual
        Console.WriteLine(nodo.Valor);

        // Define un nuevo prefijo para los nodos hijos, con formato visual adecuado
        string nuevoPrefijo = prefijo + (esUltimo ? "    " : "│   ");

        // Recorre todos los nodos hijos del nodo actual
        for (int i = 0; i < nodo.Hijos.Count; i++)
        {
            // Determina si el nodo hijo actual es el último en la lista
            bool esUltimoHijo = i == nodo.Hijos.Count - 1;

            // Llama recursivamente a ImprimirArbol para imprimir el hijo actual
            ImprimirArbol(nodo.Hijos[i], nuevoPrefijo, esUltimoHijo);
        }
    }

    // Método principal del programa
    public static void Main()
    {
        // Muestra un título en consola para el primer ejemplo
        Console.WriteLine("\nEjemplo 1: Árbol de decisión simple");

        // Crea la raíz del árbol con una pregunta como valor
        Nodo raizDecision = new Nodo("¿Fue aceptado para estudiar en la UEA?");
        // Crea un nodo hijo para la opción "Sí"
        Nodo si = new Nodo("Fue aceptado para estudiar");
        // Crea un nodo hijo para la opción "No"
        Nodo no = new Nodo("No fue aceptado para  estudiar");

        // Agrega los nodos hijos a la raíz del árbol de decisión
        raizDecision.AgregarHijo(si);
        raizDecision.AgregarHijo(no);

        // Llama al método para imprimir en consola el árbol de decisión
        ImprimirArbol(raizDecision);

        // Línea vacía y título para separar el segundo ejemplo
        Console.WriteLine("\nEjemplo 2: Árbol de categorías de productos");

        // Crea la raíz del árbol con la categoría general "Electrónicos"
        Nodo raizCategorias = new Nodo("Electrónicos");
        // Crea una subcategoría "Computadoras"
        Nodo computadoras = new Nodo("Computadoras");
        // Subcategorías de "Computadoras"
        Nodo laptops = new Nodo("Laptops");
        Nodo desktop = new Nodo("Desktop");
        // Otras subcategorías directas de "Electrónicos"
        Nodo televisores = new Nodo("Televisores");
        Nodo smartphones = new Nodo("Smartphones");

        // Construye la jerarquía del árbol añadiendo los nodos hijos correspondientes
        raizCategorias.AgregarHijo(computadoras);  // Computadoras como hijo de Electrónicos
        computadoras.AgregarHijo(laptops);         // Laptops como hijo de Computadoras
        computadoras.AgregarHijo(desktop);         // Desktop como hijo de Computadoras
        raizCategorias.AgregarHijo(televisores);   // Televisores como hijo de Electrónicos
        raizCategorias.AgregarHijo(smartphones);   // Smartphones como hijo de Electrónicos

        // Imprime el árbol de categorías de productos
        ImprimirArbol(raizCategorias);
    }
}
// Fin del programa.



// Universidad Estatal Amazónica.

// TIFFANY FERNANDA QUIÑONEZ QUINTERO 
// ERICK ARIEL PAZ CARDENAS 
// MANUEL ALEXANDER PINEDA SONGORO
// ANDRES RAFAEL PONCE MALDONADO 
