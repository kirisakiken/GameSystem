﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using KirisakiTechnologies.GameSystem.Scripts.Entities;
using KirisakiTechnologies.PhoenixNetworking.Scripts.Entities.Player;
using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Modules.Entities
{
    // TODO: this is shared between Server<>Client. Find a way to separate. (e.g. have multiple entities module, ServerEntitiesModule, ClientEntitiesModule) or (e.g. Separate repos)
    public class EntitiesModule : GameModuleBaseMono, IEntitiesModule
    {
        #region IEntitiesModule Implementation

        public event OnEntitiesChanged OnEntitiesChanged;

        public T GetEntity<T>(int id) where T : IEntity
        {
            return _Entities.FirstOrDefault((e) => e.Id == id) is T t
                ? t
                : default;
        }

        public int GetNextEntityId()
        {
            if (_Entities.Count == 0)
                return 1;

            var id = _Entities.Max((e) => e.Id);
            return id + 1;
        }

        public Task UpdateEntities(EntitiesTransaction transaction)
        {
            foreach (var entity in transaction.AddedEntities)
            {
                if (!_Entities.Add(entity))
                {
                    Debug.LogWarning($"Entity with id: {entity.Id} already exists in the module collection!");
                    continue;
                }

                OnEntitiesChanged?.Invoke(entity);
            }

            foreach (var entity in transaction.ModifiedEntities)
            {
                throw new NotImplementedException();
            }

            foreach (var entity in transaction.RemovedEntities)
            {
                if (!_Entities.Contains(entity))
                    continue;

                _Entities.Remove(entity);
                OnEntitiesChanged?.Invoke(entity);
            }

            return Task.CompletedTask;
        }

        #endregion

        #region Private

        private readonly HashSet<IEntity> _Entities = new HashSet<IEntity>();

        #endregion
    }
}