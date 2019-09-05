using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 

            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            root.Add(new PrimitiveElement("Soy el Adoptado"));

            // Create a branch

            CompositeElement comp = new CompositeElement("Two Circles");
            CompositeElement otro = new CompositeElement("Hermano Feo");

            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            
            comp.Add(otro);
            otro.Add(new PrimitiveElement("El hijo Feo"));
            otro.Add(new PrimitiveElement("El hijo Mas Feo"));
            root.Add(comp);
            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
