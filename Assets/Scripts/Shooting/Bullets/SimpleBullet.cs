using Interfaces;
using UnityEngine;

namespace Shooting.Bullets
{
    public class SimpleBullet : Bullet
    {
        protected override void OnCollisionEnter2D(Collision2D collision2D)
        {
            collision2D.gameObject.GetComponent<IHittable>()?.TakeDamage(Damage);
            
            Destroy(gameObject);
        }
    }
}