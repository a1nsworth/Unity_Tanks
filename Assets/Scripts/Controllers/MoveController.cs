using System;
using Entities;
using UnityEngine;

namespace Controllers
{
    public class MoveController : MonoBehaviour
    {
        private Tank _tank;

        private void Processing()
        {
            foreach (Command command in _tank.CommandsAssignment)
            {
                if (Input.GetKey(command.KeyCode))
                    command.Execute(_tank);
            }
        }

        private void Start()
        {
            _tank = GetComponent<Tank>();
        }

        private void Update()
        {
            Processing();
        }
    }
}