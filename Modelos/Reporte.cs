using System.ComponentModel.DataAnnotations;
using System.Data;



public class ValidarFecha : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime fecha = Convert.ToDateTime(value);
        return ! (fecha <= DateTime.Now.AddYears(1));
    }
}

class Reporte {


    public string Id = Guid.NewGuid().ToString();

    [Required (ErrorMessage = "El campo Fecha es requerido")]

    public DateTime Fecha {get; set;} = DateTime.Now;

    [Required (ErrorMessage ="El campo Descripción es requerido")]
    [MinLength(10, ErrorMessage ="La descripción debe tener al menos 10 caracteres")]
    public string Descripcion {get; set;} = "";
    public double CostoEstimado {get; set;} = 0;

    public int Muertos {get; set;} = 0;

    public int Heridos {get; set;} = 0;

    public int VehiculosInvolucrados { get; set; } = 0;


}