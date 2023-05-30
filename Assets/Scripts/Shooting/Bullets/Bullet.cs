using System;
using UnityEngine;

namespace Shooting.Bullets
{
    [Serializable]
    [RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
    public abstract class Bullet : MonoBehaviour
    {
        [field: SerializeField] public float ForceFlight { get; private set; }

        [field: Range(1, 4)]
        [field: SerializeField]
        public uint Damage { get; private set; }

        public Rigidbody2D Rigidbody2D { get; private set; }

        private void Awake()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }

        protected abstract void OnCollisionEnter2D(Collision2D collision2D);
    }
}