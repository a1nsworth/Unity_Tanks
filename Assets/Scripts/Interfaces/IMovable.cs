using UnityEngine;

namespace Interfaces
{
    public interface IMovable
    {
        public void Move(Vector3 direct);
        public void Spin(Vector3 eulers);
    }
}