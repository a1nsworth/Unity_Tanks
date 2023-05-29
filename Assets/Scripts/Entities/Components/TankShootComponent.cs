using System;
using Shooting.BulletSpawners;
using UnityEngine;

namespace Entities.Components
{
    [Serializable]
    public class TankShootComponent
    {
        private float _lastShotTime;

        public Tank Tank { get; private set; }
        [field: SerializeField] public BulletShooter BulletShooter { get; private set; }
        [field: SerializeField] private float Duration { get; set; } = 1.0f;

        public TankShootComponent(Tank tank)
        {
            Tank = tank;
        }

        public void Shoot()
        {
            if (Time.time > _lastShotTime)
            {
                _lastShotTime = Time.time + Duration;
                BulletShooter.Shoot();
            }
        }
    }
}