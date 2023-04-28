using CisWorkery;
using Soneta.Business;
using Soneta.Handel;
using WorkerExample;

[assembly: ProgramInitializer(typeof(DokumentHandlowyVerifierInitializer))]
namespace CisWorkery
{
    public class DokumentHandlowyVerifierInitializer : IProgramInitializer
    {
        public void Initialize()
        {
            HandelModule.DokumentHandlowySchema.AddOnEditing((Row) =>
            {
                Row.Session.Verifiers.Add(new WeryfikatorDokumentHandlowy(Row));
            });
        }
    }
}
