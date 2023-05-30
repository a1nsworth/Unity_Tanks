using System;
using Ui;
using UnityEngine;

namespace Entities.Components
{
    [Serializable]
    public class TankHealthBarComponent
    {
        [field: SerializeField] public HealthBar HealthBar { get; private set; }
    }
}