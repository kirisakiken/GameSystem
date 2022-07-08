using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Modules.Entities
{
    public delegate void OnEntitiesChanged(IEntity entity);

    /// <summary>
    ///     Holds ownership of entities
    /// </summary>
    public interface IEntitiesModule : IGameModule
    {
        /// <summary>
        ///     Invoked whenever an entity added, modified or removed
        /// </summary>
        event OnEntitiesChanged OnEntitiesChanged;

        /// <summary>
        ///     Returns requested entity by id
        ///     returns null if not found
        /// </summary>
        T GetEntity<T>(int id) where T : IEntity;

        /// <summary>
        ///     Returns next available entity id
        ///     (max + 1)
        /// </summary>
        /// <returns></returns>
        int GetNextEntityId();

        /// <summary>
        ///     Updates entities with given transaction
        /// </summary>
        Task UpdateEntities(EntitiesTransaction transaction);
    }
}