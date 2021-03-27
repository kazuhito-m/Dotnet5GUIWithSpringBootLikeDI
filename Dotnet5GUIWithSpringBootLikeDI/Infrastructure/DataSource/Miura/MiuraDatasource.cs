using Dotnet5GUIWithSpringBootLikeDI.Domain.Model.Miura;

namespace Dotnet5GUIWithSpringBootLikeDI.Infrastructure.DataSource.Miura
{
    class MiuraDatasource : IMiuraRepository
    {
        public TheMiura Get()
        {
            // TODO 本来ならここで永続層だったりDBの事情だったりを実装
            return new TheMiura("Kazuhito", "Miura");
        }
    }
}
