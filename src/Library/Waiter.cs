//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private ArrayList assignedTables = new ArrayList();


        /// <summary>
        /// Obtiene el nombre del mozo.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Crea un mozo con el nombre indicado.
        /// </summary>
        /// <param name="name">El nombre del mozo.</param>
        public Waiter(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Asigna una mesa al mozo.
        /// </summary>
        /// <param name="table">La mesa a asignar.</param>
        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        /// <summary>
        /// Toma un pedido para una mesa específica y agrega el platillo a la orden de esa mesa.
        /// </summary>
        /// <param name="table">La mesa para la que se toma el pedido.</param>
        /// <param name="dish">El platillo pedido.</param>
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}
