using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Providers.Entities
{
    public class EntitiesProvider : GameProviderBaseMono, IEntitiesProvider
    {
        #region IEntitiesProvider Implementation

        public Task<List<IEntity>> LoadEntities()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}