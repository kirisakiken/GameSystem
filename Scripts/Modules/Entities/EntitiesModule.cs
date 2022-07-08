using System.Collections.Generic;
using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;
using KirisakiTechnologies.GameSystem.Scripts.Extensions;
using KirisakiTechnologies.GameSystem.Scripts.Providers.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Modules.Entities
{
    // TODO: this is shared between Server<>Client. Find a way to separate. (e.g. have multiple entities module, ServerEntitiesModule, ClientEntitiesModule) or (e.g. Separate repos)
    public class EntitiesModule : GameModuleBaseMono, IEntitiesModule
    {
        #region IEntitiesModule Implementation

        public IReadOnlyList<IEntity> Entities => _Entities;

        #endregion

        #region Overrides

        public override async Task Begin(IGameSystem gameSystem)
        {
            _EntitiesProvider = gameSystem.GetProvider<IEntitiesProvider>();
            _Entities.AddRange(await _EntitiesProvider.LoadEntities());

            await base.Begin(gameSystem);
        }

        #endregion

        #region Private

        private readonly List<IEntity> _Entities = new List<IEntity>();

        private IEntitiesProvider _EntitiesProvider;

        #endregion
    }
}