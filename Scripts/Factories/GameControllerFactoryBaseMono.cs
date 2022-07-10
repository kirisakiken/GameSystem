using System;
using System.Threading.Tasks;

using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Factories
{
    public abstract class GameControllerFactoryBaseMono : MonoBehaviour, IGameFactory
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
