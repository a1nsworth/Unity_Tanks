using System;
using Interfaces;
using UnityEngine;

namespace Entities.Components
{
    [Serializable]
    public class TankMoveComponent : IMovable
    {
        [field: SerializeField] public float MovementSpeed { get; private set; } = 0.05f;
        [field: SerializeField] public float AngleRotation { get; private set; } = 3f;
        public Tank Tank { get; private set; }

        public TankMoveComponent(Tank tank) => Tank = tank;

        public void Spin(Vector3 eulers) => Tank.transform.Rotate(eulers * (AngleRotation * Time.deltaTime));

        public void Move(Vector3 direct) =>
            Tank.transform.Translate(direct * (MovementSpeed * Time.fixedDeltaTime), Space.World);

        public void MoveForward() => Move(Vector3.Normalize(Tank.transform.up));

        public void MoveBackward() => Move(Vector3.Normalize(-Tank.transform.up));

        public void SpinClockWise() => Spin(Vector3.forward);

        public void SpinAntiClockWise() => Spin(-Vector3.forward);
    }
}