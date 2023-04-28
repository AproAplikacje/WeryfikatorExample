using Soneta.Business;
using Soneta.Handel;
using Soneta.Types;
using System.Linq;

namespace WorkerExample
{
    public class WeryfikatorDokumentHandlowy : RowVerifier
    {
        public WeryfikatorDokumentHandlowy(Row dokHandlowy) : base(dokHandlowy) { }

        private new DokumentHandlowy Row => (DokumentHandlowy)base.Row;

        public override string Description => "Ilośc produktów przekroczona!";

        public override VerifierType Type => VerifierType.Error;

        protected override bool IsValid()
        {
            return Row.Pozycje.Sum(p => p.Ilosc.Value) <= 100;
        }
    }
}
