using System;

namespace KirisakiTechnologies.GameSystem.Scripts.Entities
{
    /// <summary>
    ///     Represents an Entity
    /// </summary>
    public interface IEntity : IDisposable
    {
        /// <summary>
        ///     Id of the entity
        /// </summary>
        int Id { get; }
    }
}