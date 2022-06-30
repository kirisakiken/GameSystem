using System.Collections.Generic;

using KirisakiTechnologies.GameSystem.Scripts.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Modules.Entities
{
    /// <summary>
    ///     Holds ownership of entities
    /// </summary>
    public interface IEntitiesModule : IGameModule
    {
        /// <summary>
        ///     Collection of entities
        /// </summary>
        IReadOnlyList<IEntity> Entities { get; }
    }
}