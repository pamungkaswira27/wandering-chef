using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class PlayerAttribute : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField]
        private float _healthPoints;
        [SerializeField]
        private float _attackPoints;
        [SerializeField]
        private float _defensePoints;

        public float HealthPoints => _healthPoints;
        public float AttackPoints => _attackPoints;
        public float DefensePoints => _defensePoints;
    }
}
