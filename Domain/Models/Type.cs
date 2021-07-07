using System.ComponentModel;

namespace LowPrice.API.Domain.Models
{
    public enum Type
    {
        [Description("Bebida")]
        Bebidas = 0,
        [Description("Galletitas")]
        Galletitas = 1,
        [Description("Almacen")]
        Almacen = 2,
        Snacks = 3 
    }
}