using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using TankControllers;
using Commands.TankCommands;

namespace Entities
{
    public class Tank : MonoBehaviour, ISpinnable, IMovable
    {
        private uint Health { get; set; } = 5;

        [field: SerializeField] private float MovementSpeed { get; set; } = 0.05f;
        [field: SerializeField] private float AngleRotation { get; set; } = 3f;

        private Transform _transform;

        [FormerlySerializedAs("TypeTankCommandAndKeyCodes")] [SerializeField]
        private List<TypeTankCommandAndKeyCode> typeTankCommandAndKeyCodes;

        public TankCommandsAssignment TankCommandsAssignment { get; private set; }

        private void Start()
        {
            TankCommandsAssignment = new TankCommandsAssignment(typeTankCommandAndKeyCodes);
            _transform = GetComponent<Transform>();
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void Spin(Vector3 eulers) => _transform.Rotate(eulers * AngleRotation);

        public void Move(Vector3 direct) => _transform.Translate(direct * MovementSpeed, Space.World);

        public void MoveForward() => Move(Vector3.Normalize(_transform.up));

        public void MoveBackward() => Move(Vector3.Normalize(-_transform.up));

        public void SpinClockWise() => Spin(Vector3.forward);

        public void SpinAntiClockWise() => Spin(-Vector3.forward);
    }
}