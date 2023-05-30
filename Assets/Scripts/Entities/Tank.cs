using System;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using Entities.Components;
using Unity.VisualScripting;

namespace Entities
{
    [Serializable]
    public class Tank : MonoBehaviour, IHittable
    {
        [field: SerializeField] public TankMoveComponent TankMoveComponent { get; private set; }
        [field: SerializeField] public TankShootComponent TankShootComponent { get; private set; }

        [field: SerializeField]
        public TankCommandsAssignmentComponent TankCommandsAssignmentComponent { get; private set; }

        [field: SerializeField] public TankHealthBarComponent TankHealthBarComponent { get; private set; }
        public TankHealthComponent TankHealthComponent { get; private set; }

        public Tank()
        {
            TankMoveComponent = new TankMoveComponent(this);
            TankShootComponent = new TankShootComponent(this);
            TankCommandsAssignmentComponent = new TankCommandsAssignmentComponent();
            TankHealthComponent = new TankHealthComponent();
            TankHealthBarComponent = new TankHealthBarComponent();
        }

        private void Awake()
        {
            TankHealthComponent.OnDamageTaken += TankHealthBarComponent.HealthBar.OnDamageTakenHandler;
        }

        private void Start()
        {
            TankCommandsAssignmentComponent.TankCommandsAssignment.FillCommands(TankCommandsAssignmentComponent
                .TypeTankCommandAndKeyCodes);
        }


        public void TakeDamage(uint damage)
        {
            TankHealthComponent.TakeDamage(damage);
        }

        public void MoveForward() => TankMoveComponent.MoveForward();
        public void MoveBackward() => TankMoveComponent.MoveBackward();
        public void SpinClockWise() => TankMoveComponent.SpinClockWise();
        public void SpinAntiClockWise() => TankMoveComponent.SpinAntiClockWise();
        public void Shoot() => TankShootComponent.Shoot();

        private void OnDestroy()
        {
            TankHealthComponent.OnDamageTaken -= TankHealthBarComponent.HealthBar.OnDamageTakenHandler;
        }
    }
}