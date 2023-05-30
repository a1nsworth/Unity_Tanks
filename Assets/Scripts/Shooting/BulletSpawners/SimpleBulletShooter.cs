using Shooting.Bullets;
using UnityEngine;

namespace Shooting.BulletSpawners
{
    public class SimpleBulletShooter : BulletShooter
    {
        // TODO Rigidbody2D to Bullet 
        public override void Shoot()
        {
            var bullet = Instantiate(Bullet.gameObject, FirePoint.position, FirePoint.rotation).GetComponent<Bullet>();
            bullet.Rigidbody2D.AddForce(FirePoint.up * (Bullet.ForceFlight * Time.fixedDeltaTime), ForceMode2D.Impulse);
        }
    }
}