﻿using Abstracts;
using UniRx;
using UnityEngine;
using Zenject;


namespace Core.Components
{
    
    public sealed class PlayerMoveComponent : IMovable
    {

        [Inject(Id = "PlayerSpeed")] public ReactiveProperty<float> Speed { get; }
        
        private Rigidbody _rigidbody;
        
        public void Move(Vector3 direction)
        {
            _rigidbody.velocity = direction * Speed.Value;
        }
        
        public void InitComponent(Rigidbody rb)
        {
            _rigidbody = rb;
        }
        
    }
}