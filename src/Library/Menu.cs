//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();
        
        /// <summary>
        /// Agrega un platillo a la lista de platillos del menú.
        /// </summary>
        /// <param name="dish">El platillo a agregar.</param>
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        /// <summary>
        /// Elimina un platillo de la lista del menú.
        /// </summary>
        /// <param name="dish">El platillo a eliminar.</param>
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }
            return null;
        }
    }
}