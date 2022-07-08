using System.Threading.Tasks;

using JetBrains.Annotations;

namespace KirisakiTechnologies.GameSystem.Scripts.Factories
{
    /// <summary>
    ///     Represents a Game Factory that can be used for
    ///     various purposes; e.g. view, action
    /// </summary>
    public interface IGameFactory
    {
        /// <summary>
        ///     Initializes the factory
        /// </summary>
        Task Initialize([NotNull] IGameSystem gameSystem);

        /// <summary>
        ///     Begins the factory
        /// </summary>
        Task Begin([NotNull] IGameSystem gameSystem);
    }
}
