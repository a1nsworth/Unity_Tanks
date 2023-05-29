using System;
using System.Collections.Generic;
using Commands.TankCommands;
using TankControllers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entities.Components
{
    [Serializable]
    public class TankCommandsAssignmentComponent
    {
        [field: SerializeField] public List<TypeTankCommandAndKeyCode> TypeTankCommandAndKeyCodes { get; private set; }

        public TankCommandsAssignment TankCommandsAssignment { get; private set; }

        public TankCommandsAssignmentComponent()
        {
            TypeTankCommandAndKeyCodes = new List<TypeTankCommandAndKeyCode>();
            TankCommandsAssignment = new TankCommandsAssignment();
        }
    }
}