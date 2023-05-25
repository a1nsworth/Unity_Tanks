using System;
using Commands.TankCommands.Enums;
using UnityEngine;

namespace Commands.TankCommands
{
    [Serializable]
    public struct TypeTankCommandAndKeyCode
    {
        [field: SerializeField] public TypeTankCommand TypeTankCommand { get; set; }
        [field: SerializeField] public KeyCode KeyCode { get; set; }
    }
}