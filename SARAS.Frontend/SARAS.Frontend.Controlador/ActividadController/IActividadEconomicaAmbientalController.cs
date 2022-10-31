using System.Threading.Tasks;

namespace SARAS.Frontend.Controlador.ActividadController
{
    public interface IActividadEconomicaAmbientalController 
    {
        public string[] Wizard { get; set; }
        public bool MostrarLoader { get; set; }
        public string BarraPorcentaje { get; set; }
        public bool MostrarBotonesWizard { get; set; }
        void AtrasStep();
        Task Siguiente();
    }
}
