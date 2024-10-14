﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductsView
    {
        string ProductsId { get; set; } // Identificador del modo de pago
        string ProductsName { get; set; } // Nombre del modo de pago
        string ProductsPrice { get; set; } // Observación del modo de pago
        string ProductsStock { get; set; } // Observación del modo de pago
        string ProductsCategorieId { get; set; } // Observación del modo de pago
        string SearchValue { get; set; } // Valor para buscar modos de pago
        bool IsEdit { get; set; } // Indica si es una operación de edición
        bool IsSuccesful { get; set; }
        string Message { get; set; } // Mensaje que se mostrará en la vista

        // Eventos que se disparan en la interfaz
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductsListBildingSource(BindingSource productsList);// Método para establecer la fuente de datos para una lista de modos de pago

        void Show();//Metodo para mostar la vista
    }
}
