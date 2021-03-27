using Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Attr;
using Dotnet5GUIWithSpringBootLikeDI.Domain.Model.Miura;

namespace Dotnet5GUIWithSpringBootLikeDI.Infrastructure.DataSource.Miura
{
    [Repository]
    public class MiuraDatasource : IMiuraRepository
    {
        public TheMiura Get()
        {
            // TODO 本来ならここで永続層だったりDBの事情だったりを実装
            return new TheMiura("Kazuhito", "Miura");
        }
    }
}
