using System;
using Commands.TankCommands.Enums;
using UnityEngine;

namespace Commands.TankCommands
{
    public static class SimpleFactoryTankCommands
    {
        public static TankCommand CreateTankCommand(TypeTankCommandAndKeyCode typeTankCommandAndKeyCode)
        {
            switch (typeTankCommandAndKeyCode.TypeTankCommand)
            {
                case TypeTankCommand.MoveForward:
                    return new MoveForwardTankCommand(typeTankCommandAndKeyCode.KeyCode);
                case TypeTankCommand.MoveBackward:
                    return new MoveBackwardTankCommand(typeTankCommandAndKeyCode.KeyCode);
                case TypeTankCommand.SpinClockwise:
                    return new SpinClockwiseTankCommand(typeTankCommandAndKeyCode.KeyCode);
                case TypeTankCommand.SpinAntiClockwise:
                    return new SpinAntiClockwiseTankCommand(typeTankCommandAndKeyCode.KeyCode);
                default:
                    throw new ArgumentOutOfRangeException(
                        $"Not exist {typeTankCommandAndKeyCode.TypeTankCommand} command");
            }
        }
    }
}