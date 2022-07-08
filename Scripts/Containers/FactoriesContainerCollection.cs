using System.Collections.Generic;

using KirisakiTechnologies.GameSystem.Scripts.Factories;

using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Containers
{
    public class FactoriesContainerCollection : MonoBehaviour, IFactoriesContainerCollection
    {
        #region IFactoriesContainerCollection Implementation

        public IReadOnlyCollection<IGameFactory> Factories => GetComponentsInChildren<IGameFactory>(false);

        #endregion
    }
}
