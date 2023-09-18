﻿using Abstracts;
using JetBrains.Annotations;
using UniRx;
using UnityEngine;


namespace Core
{
    
    public sealed class PCInput : IInput
    {
        
        public IObservableInputProxy<float> Horizontal { get; }
        
        public IObservableInputProxy<float> Vertical { get; }
        
        public IObservableInputProxy<bool> LeftClick { get; }
        
        public IObservableInputProxy<Vector3> MousePosition { get; }
        
        public ISubjectInputProxy<Unit> WeaponFirst { get; }
        
        public ISubjectInputProxy<Unit> WeaponSecond { get; }
        
        public ISubjectInputProxy<Unit> WeaponThird { get; }

        public ISubjectInputProxy<Unit> Explosion { get; }


        public PCInput( [NotNull] InputConfig config )
        {

            Horizontal = new PCInputHorizontal(config);
            Vertical = new PCInputVertical(config);
            LeftClick = new PCAttackInput();
            MousePosition = new PCMousePositionInput();
            WeaponFirst = new PCWeaponFirstInput(config);
            WeaponSecond = new PCWeaponSecondInput(config);
            WeaponThird = new PCWeaponThirdInput(config);
            Explosion = new PCExplosionInput(config);
        }
        
        
    }
}