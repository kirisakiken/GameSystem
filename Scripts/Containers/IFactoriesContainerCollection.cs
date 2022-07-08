using System.Collections.Generic;

using KirisakiTechnologies.GameSystem.Scripts.Factories;

namespace KirisakiTechnologies.GameSystem.Scripts.Containers
{
    /// <summary>
    ///     Represents a container that holds ownership of modules
    /// </summary>
    public interface IFactoriesContainerCollection
    {
        /// <summary>
        ///     Represents factories collection that belongs to the container
        /// </summary>
        IReadOnlyCollection<IGameFactory> Factories { get; }
    }
}
