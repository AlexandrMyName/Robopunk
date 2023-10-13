using Abstracts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;


namespace Core
{

    public class EnemyBossDistantAttackSystem : BaseSystem, IDisposable
    {

        private IGameComponents _gameComponents;
        private IEnemyBossComponent _enemyBossComponent;
        private ConcurrentQueue<SeekerOfEnemies> _seekers = new();
        private List<IDisposable> _disposables = new();
        private TrailRenderer _trailInstance;
        private Transform _playerTransform;
        private IPlayer _player;


        public EnemyBossDistantAttackSystem(IEnemyBossComponent bossComponent, Transform playerTransform)
        {

             _playerTransform = playerTransform;
            _enemyBossComponent = bossComponent;
        }


        protected override void Awake(IGameComponents components)
        {

            _gameComponents = components;
            _player = _playerTransform.GetComponent<IPlayer>();
        }


        protected override void Update()
        {

            if (Vector3.Distance(_gameComponents.BaseTransform.position,
              _playerTransform.position) < 15)
            {

                var trail = SetActiveTrail(true);
                trail.AddPosition(_playerTransform.position);
                GameObject.Destroy(trail, 15);
                _player.ComponentsStore.Attackable.TakeDamage(Time.deltaTime * 6);
            }
        }

        private TrailRenderer SetActiveTrail(bool isActive)
        {
             
               var trailInstance 
                = GameObject.Instantiate(_enemyBossComponent.HealTrail,
                       _gameComponents.BaseTransform );

            trailInstance.transform.localPosition = Vector3.zero;
            trailInstance.emitting = isActive;
            return trailInstance;
        }
         
        public void Dispose() { }
    }
}