using System;
using System.Threading.Tasks;

using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Factories
{
    /// <summary>
    ///     Represents the base class for view factories
    ///     that has Mono Behaviour
    /// </summary>
    public abstract class GameViewFactoryBaseMono : MonoBehaviour, IGameViewFactory
    {
        #region IGameFactory Implementation

        public virtual Task Initialize(IGameSystem gameSystem)
        {
            if (gameSystem == null)
                throw new ArgumentNullException(nameof(gameSystem));

            return Task.CompletedTask;
        }

        public virtual Task Begin(IGameSystem gameSystem)
        {
            if (gameSystem == null)
                throw new ArgumentNullException(nameof(gameSystem));

            return Task.CompletedTask;
        }

        #endregion
    }
}
