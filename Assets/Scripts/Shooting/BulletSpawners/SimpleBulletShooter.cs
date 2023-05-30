using Shooting.Bullets;
using UnityEngine;

namespace Shooting.BulletSpawners
{
    public class SimpleBulletShooter : BulletShooter
    {
        public override void Shoot()
        {
            var bullet = Instantiate(Bullet.gameObject, FirePoint.position, FirePoint.rotation).GetComponent<Bullet>();
            bullet.GetComponent<Rigidbody2D>()
                .AddForce(FirePoint.up * (Bullet.FlightSpeed * Time.deltaTime), ForceMode2D.Impulse);
        }
    }
}