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

    public readonly struct ReadonlyEntitiesTransaction
    {
        #region Constructors

        public ReadonlyEntitiesTransaction(EntitiesTransaction transaction)
        {
            AddedEntities = transaction.AddedEntities;
            ModifiedEntities = transaction.ModifiedEntities;
            RemovedEntities = transaction.RemovedEntities;
        }

        public ReadonlyEntitiesTransaction(IReadOnlyList<IEntity> addedEntities, IReadOnlyList<IEntity> modifiedEntities, IReadOnlyList<IEntity> removedEntities)
        {
            AddedEntities = addedEntities;
            ModifiedEntities = modifiedEntities;
            RemovedEntities = removedEntities;
        }

        #endregion

        #region Public

        public IReadOnlyList<IEntity> AddedEntities { get; }
        public IReadOnlyList<IEntity> ModifiedEntities { get; }
        public IReadOnlyList<IEntity> RemovedEntities { get; }

        #endregion
    }
}