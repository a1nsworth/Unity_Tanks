using System;
using Commands.TankCommands;
using Entities;
using UnityEngine;

namespace Controllers
{
    public class TankCommandsController : MonoBehaviour
    {
        private Tank _tank;

        private void Processing()
        {
            foreach (TankCommand command in _tank.TankCommandsAssignmentComponent.TankCommandsAssignment ??
                                            throw new NullReferenceException(nameof(_tank
                                                .TankCommandsAssignmentComponent.TankCommandsAssignment)))
            {
                if (Input.GetKey(command.KeyCode))
                {
                    command.Execute(_tank);
                }
            }
        }

        private void Start()
        {
            _tank = GetComponent<Tank>();
        }

        private void FixedUpdate()
        {
            Processing();
        }
    }
}