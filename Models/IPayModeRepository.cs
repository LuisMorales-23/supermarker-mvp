using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models //namespace Supermarket_mvp.Models // Espacio de nombres que organiza el código en grupos lógicos
{
    //Comportamiento de la entidad PayMode
    internal interface IPayModeRepository // Interfaz que define métodos para manejar modos de pago
    {
        void Add(PayModeModel payModeModel); // Método para agregar un nuevo modo de pago
        void Edit(PayModeModel payModeModel); // Método para editar un modo de pago existente
        void Delete(int id); // Método para eliminar un modo de pago basado en su ID
        IEnumerable<PayModeModel> GetAll(); // Método para obtener todos los modos de pago
        IEnumerable<PayModeModel> GetByValue(string value); // Método para obtener modos de pago que coinciden con un valor específico
       
    }
}

