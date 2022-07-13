using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;

namespace KirisakiTechnologies.GameSystem.Scripts.Modules.Entities
{
    // TODO: this is shared between Server<>Client. Find a way to separate. (e.g. have multiple entities module, ServerEntitiesModule, ClientEntitiesModule) or (e.g. Separate repos)
    public class EntitiesModule : GameModuleBaseMono, IEntitiesModule
    {
        #region IEntitiesModule Implementation

        public event OnEntitiesChanged OnEntitiesChanged;
        public event OnEntityModified OnEntityModified;

        public T GetEntity<T>(int id) where T : IEntity
        {
            if (!_Entities.ContainsKey(id))
                return default;

            var entity = _Entities[id];
            if (!(entity is T t))
                throw new Exception($"Unable to cast Entity[{id}] to type: {nameof(T)}");

            return t;
        }

        public int GetNextEntityId()
        {
            if (_Entities.Count == 0)
                return 1;

            var keys = _Entities.Keys;
            return keys.Max() + 1;
        }

        public Task UpdateEntities(EntitiesTransaction transaction)
        {
            foreach (var entity in transaction.AddedEntities)
            {
                if (_Entities.ContainsKey(entity.Id))
                    throw new Exception($"Entity[{entity.Id}] already exists in collection {nameof(_Entities)}");

                _Entities.Add(entity.Id, entity);
            }

            foreach (var entity in transaction.ModifiedEntities)
            {
                if (!_Entities.ContainsKey(entity.Id))
                    throw new Exception($"Unable to find Entity[{entity.Id}] in collection {nameof(_Entities)}");

                _Entities[entity.Id] = entity;
            }

            foreach (var entity in transaction.RemovedEntities)
            {
                if (!_Entities.ContainsKey(entity.Id))
                    throw new Exception($"Unable to find Entity[{entity.Id}] in collection {nameof(_Entities)}");

                _Entities.Remove(entity.Id);
            }

            OnEntitiesChanged?.Invoke(new ReadonlyEntitiesTransaction(transaction));
            return Task.CompletedTask;
        }

        #endregion

        #region Private

        private readonly Dictionary<int, IEntity> _Entities = new Dictionary<int, IEntity>();

        #endregion
    }
}