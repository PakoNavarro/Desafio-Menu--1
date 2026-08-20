//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private ArrayList order = new ArrayList();
        
        public int Number { get; private set;}
        
        /// <summary>
        /// Obtiene si la mesa está ocupada o no.
        /// </summary>
        public bool IsOccupied { get; private set;}
        
        /// <summary>
        /// Crea una mesa con el número indicado, inicialmente libre.
        /// </summary>
        /// <param name="number">El número identificador de la mesa.</param>
        public Table(int number)
        {
        Number = number;
        IsOccupied = false;
        }
        
        /// <summary>
        /// Marca la mesa como ocupada.
        /// </summary>
        public void Occupy()
        {
            IsOccupied = true;
        }
        
        /// <summary>
        /// Libera la mesa y vacía la lista de pedidos.
        /// </summary>
        public void Free()
        {
            IsOccupied = false;
            order.Clear();
        }
        
        /// <summary>
        /// Agrega un platillo a la lista de pedidos de la mesa.
        /// </summary>
        /// <param name="dish">El platillo a agregar.</param>
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        /// <summary>
        /// Indica si la mesa tiene órdenes asignadas.
        /// </summary>
        public bool HasOrders()
        {
            return this.order.Count > 0;

        }
    }
}

