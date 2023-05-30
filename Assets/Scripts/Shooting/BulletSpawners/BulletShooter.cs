using System;
using Shooting.Bullets;
using UnityEngine;

namespace Shooting.BulletSpawners
{
    [Serializable]
    public abstract class BulletShooter : MonoBehaviour
    {
        [field: SerializeField] public Transform FirePoint { get; private set; }
        [field: SerializeField] public Bullet Bullet { get; private set; }

        public abstract void Shoot();
    }
}