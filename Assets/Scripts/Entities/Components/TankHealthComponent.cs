using System;

namespace Entities.Components
{
    public class TankHealthComponent
    {
        private uint Health { get; set; } = 4;

        public event Action<uint> OnDamageTaken;

        public void TakeDamage(uint damage)
        {
            if (Health >= (int)damage)
                Health -= damage;
            else
                Health = 0;

            OnDamageTaken?.Invoke(damage);
        }
    }
}