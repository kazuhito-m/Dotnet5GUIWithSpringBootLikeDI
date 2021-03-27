using Dotnet5GUIWithSpringBootLikeDI.Domain.Model.Miura;

namespace Dotnet5GUIWithSpringBootLikeDI.Appliraciton.Sevice.Miura
{
    class MiuraService
    {
        private readonly IMiuraRepository repository;

        public MiuraService(IMiuraRepository repository)
        {
            this.repository = repository;
        }

        public TheMiura Get() => repository.Get();
    }
}
