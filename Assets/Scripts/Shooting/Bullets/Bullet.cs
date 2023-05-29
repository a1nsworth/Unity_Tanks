using System;
using UnityEngine;

namespace Shooting.Bullets
{
    [Serializable]
    [RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
    public abstract class Bullet : MonoBehaviour
    {
        private void Start()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public Rigidbody2D Rigidbody2D { get; private set; }
        [field: SerializeField] public float FlightSpeed { get; private set; }
        [field: SerializeField] public uint Damage { get; private set; }

        protected abstract void OnCollisionEnter2D(Collision2D collision2D);
    }
}