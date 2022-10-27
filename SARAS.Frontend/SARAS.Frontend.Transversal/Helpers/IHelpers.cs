using System.Net.Http;

namespace SARAS.Frontend.Transversal.Helpers
{
    public interface IHelpers
    {
        int[] Errores { get; set; }
        StringContent JsonToStringContent<T>(T entity);
        bool ValidarModelo(object modelo);
        string FormateadorDecimales(string monto);
        string obtenerComision(string parametro);
    }
}
