using System.Collections.Generic;
using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Providers.Entities
{
    /// <summary>
    ///     Responsible of providing entities
    /// </summary>
    public interface IEntitiesProvider : IGameProvider
    {
        /// <summary>
        ///     Loads entities
        /// </summary>
        /// <returns></returns>
        Task<List<IEntity>> LoadEntities();
    }
}