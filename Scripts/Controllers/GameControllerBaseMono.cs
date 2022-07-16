using System;

using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Controllers
{
    public abstract class GameControllerBaseMono : MonoBehaviour, IGameController
    {
        public virtual void Initialize(IGameSystem gameSystem)
        {
            if (gameSystem == null)
                throw new ArgumentNullException(nameof(gameSystem));
        }

        public virtual void Begin(IGameSystem gameSystem)
        {
            if (gameSystem == null)
                throw new ArgumentNullException(nameof(gameSystem));
        }
    }
}
