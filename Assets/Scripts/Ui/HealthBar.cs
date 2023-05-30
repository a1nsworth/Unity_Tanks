using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Ui
{
    public class HealthBar : MonoBehaviour
    {
        [FormerlySerializedAs("Bars")] [SerializeField]
        private List<Sprite> bars;

        private Image _image;
        private const uint BaseHealth = 4;
        private uint _health = 4;

        private void Start()
        {
            _image = GetComponent<Image>();
        }

        public void OnDamageTakenHandler(uint damage)
        {
            if (_health >= damage)
            {
                _health -= damage;
                _image.sprite = bars[(int)_health];
            }
        }
    }
}