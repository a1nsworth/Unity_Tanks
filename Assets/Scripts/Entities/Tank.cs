using System.Collections.Generic;
using Controllers;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entities
{
    public class Tank : MonoBehaviour, ISpinnable, IMovable
    {
        private uint Health { get; set; } = 5;

        [field: SerializeField] private float MovementSpeed { get; set; } = 0.001f;
        [field: SerializeField] private float AngleRotation { get; set; } = 0.1f;

        private Transform _transform;

        [SerializeField] private KeyCode moveUpKeyCode;
        [SerializeField] private KeyCode moveDownKeyCode;
        [SerializeField] private KeyCode spinClockwiseKeyCode;
        [SerializeField] private KeyCode spinAntiClockwiseKeyCode;

        public CommandsAssignment CommandsAssignment { get; private set; }

        void Start()
        {
            CommandsAssignment = new CommandsAssignment(new List<Command>
            {
                new MoveForwardCommand(moveUpKeyCode), new MoveBackwardCommand(moveDownKeyCode),
                new SpinClockwiseCommand(spinClockwiseKeyCode), new SpinAntiClockwiseCommand(spinAntiClockwiseKeyCode)
            });
            _transform = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void Spin(Vector3 eulers)
        {
            _transform.Rotate(eulers * angleRotation);
        }

        public void Move(Vector3 direct)
        {
            _transform.Translate(direct * movementSpeed, Space.World);
        }

        public void MoveForward()
        {
            Move(Vector3.Normalize(_transform.up));
        }

        public void MoveBackward()
        {
            Move(Vector3.Normalize(-_transform.up));
        }

        public void SpinClockWise()
        {
            Spin(Vector3.forward);
        }

        public void SpinAntiClockWise()
        {
            Spin(-Vector3.forward);
        }
    }
}