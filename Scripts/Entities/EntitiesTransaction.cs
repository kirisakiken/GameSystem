using System.Collections.Generic;

namespace KirisakiTechnologies.GameSystem.Scripts.Entities
{
    /// <summary>
    ///     Represents transaction of entities e.g.
    ///     Added, Modified and Removed entities
    /// </summary>
    public class EntitiesTransaction
    {
        #region Public

        public List<IEntity> AddedEntities { get; } = new List<IEntity>();
        public List<IEntity> ModifiedEntities { get; } = new List<IEntity>();
        public List<IEntity> RemovedEntities { get; } = new List<IEntity>();

        #endregion
    }
}