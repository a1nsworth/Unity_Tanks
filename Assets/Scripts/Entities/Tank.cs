using System;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using Entities.Components;

namespace Entities
{
    [Serializable]
    public class Tank : MonoBehaviour, IHittable
    {
        public Tank()
        {
            TankMoveComponent = new TankMoveComponent(this);
            TankShootComponent = new TankShootComponent(this);
            TankCommandsAssignmentComponent = new TankCommandsAssignmentComponent();
        }

        private uint Health { get; set; } = 5;

        [field: SerializeField] public TankMoveComponent TankMoveComponent { get; private set; }

        [field: SerializeField] public TankShootComponent TankShootComponent { get; private set; }

        [field: SerializeField]
        public TankCommandsAssignmentComponent TankCommandsAssignmentComponent { get; private set; }

        private void Start()
        {
            TankCommandsAssignmentComponent.TankCommandsAssignment.FillCommands(TankCommandsAssignmentComponent
                .TypeTankCommandAndKeyCodes);
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void TakeDamage(uint damage)
        {
            if (Health != 0)
            {
                if (Health - (int)damage > 0)
                {
                    Health -= damage;
                }
                else
                {
                    Health = 0;
                }
            }
        }

        public void MoveForward() => TankMoveComponent.MoveForward();
        public void MoveBackward() => TankMoveComponent.MoveBackward();
        public void SpinClockWise() => TankMoveComponent.SpinClockWise();
        public void SpinAntiClockWise() => TankMoveComponent.SpinAntiClockWise();
        public void Shoot() => TankShootComponent.Shoot();
    }
}