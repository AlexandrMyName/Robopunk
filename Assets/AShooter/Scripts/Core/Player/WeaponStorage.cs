using Abstracts;
using Core.DTO;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using User;
using Zenject;


namespace Core
{

    public class WeaponStorage : IWeaponStorage
    {

        [Inject] public WeaponState WeaponState { get; private set; }
        [Inject] public List<WeaponConfig> WeaponConfigs { get; private set; }
        
        public Dictionary<WeaponType, IWeapon> Weapons { get; }

        private Camera _camera;
        private Transform _weaponContainer;
        
        
        public WeaponStorage()
        { 
            Weapons = new Dictionary<WeaponType, IWeapon>();
            _camera = Camera.main;
        }


        public void InitializeWeapons(Transform weaponContainer)
        {

            _weaponContainer = weaponContainer;

            for (int i = 0; i < WeaponConfigs.Count; i++)
            {
                var config = WeaponConfigs[i];

                switch (config.WeaponType)
                {
                    case WeaponType.Sword:
                        Weapons[WeaponType.Sword] = SwordInit(config);
                        break;
                    case WeaponType.Pistol:
                        Weapons[WeaponType.Pistol] = PistolInit(config);
                        break;
                    case WeaponType.Shotgun:
                        Weapons[WeaponType.Shotgun] = ShotgunInit(config);
                        break;
                    case WeaponType.RocketLauncher:
                        Weapons[WeaponType.RocketLauncher] = RocketLauncherInit(config);
                        break;
                }
            }
        }


        private IWeapon SwordInit(WeaponConfig config)
        {
            var swordObject = GameObject.Instantiate(config.WeaponObject, _weaponContainer);
            swordObject.SetActive(false);
            return new Sword(
                config.WeaponId,
                swordObject,
                config.WeaponIcon,
                config.WeaponType,
                config.Damage,
                config.LayerMask,
                config.Effect,
                config.EffectDestroyDelay,
                config.ShootSpeed);
        }


        private IWeapon PistolInit(WeaponConfig config)
        {
            var pistolObject = GameObject.Instantiate(config.WeaponObject, _weaponContainer);
            pistolObject.SetActive(false);
            return new Pistol(
                config.WeaponId,
                pistolObject,
                config.WeaponIcon,
                null,
                config.WeaponType,
                config.Damage,
                config.ClipSize,
                new ReactiveProperty<int>(config.LeftPatronsCount),
                config.ReloadTime,
                config.ShootDistance,
                config.ShootSpeed,
                config.FireSpread,
                config.LayerMask,
                config.MuzzleEffect,
                config.Effect,
                config.EffectDestroyDelay,
                _camera
                );
        }


        private IWeapon ShotgunInit(WeaponConfig config)
        {
            var shotgunObject = GameObject.Instantiate(config.WeaponObject, _weaponContainer);
            shotgunObject.SetActive(false);
            return new Shotgun(
                config.WeaponId,
                shotgunObject,
                config.WeaponIcon,
                null,
                config.WeaponType,
                config.Damage,
                config.ClipSize,
                new ReactiveProperty<int>(config.LeftPatronsCount),
                config.ReloadTime,
                config.ShootDistance,
                config.ShootSpeed,
                config.FireSpread,
                config.SpreadFactor,
                config.LayerMask,
                config.MuzzleEffect,
                config.Effect,
                config.EffectDestroyDelay,
                _camera);
        }


        private IWeapon RocketLauncherInit(WeaponConfig config)
        {
            var rocketLauncherObject = GameObject.Instantiate(config.WeaponObject, _weaponContainer);
            rocketLauncherObject.SetActive(false);
            return new RocketLauncher(
                config.WeaponId,
                rocketLauncherObject,
                config.WeaponIcon,
                config.ProjectileObject,
                config.ProjectileForce,
                config.WeaponType,
                config.Damage,
                config.ClipSize,
                new ReactiveProperty<int>(config.LeftPatronsCount),
                config.ReloadTime,
                config.ShootDistance,
                config.ShootSpeed,
                config.FireSpread,
                config.LayerMask,
                config.MuzzleEffect,
                config.Effect,
                config.EffectDestroyDelay,
                _camera);
        }

        
    }
}