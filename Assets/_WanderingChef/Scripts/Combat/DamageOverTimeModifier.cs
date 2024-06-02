using NaughtyAttributes;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class DamageOverTimeModifier : MonoBehaviour
    {
        [Header("Damage Based On")]
        [SerializeField]
        private BaseDamage _baseDamage;

        [ShowIf("_baseDamage", BaseDamage.HealthPercentage)]
        [SerializeField]
        private float _healthPercentage;

        [System.Serializable]
        public enum BaseDamage
        {
            AttackPoints,
            Damage,
            HealthPercentage,
        }

        public BaseDamage DamageBasedOn => _baseDamage;

        public float GetHealthPercentage()
        {
            return (_healthPercentage / 100);
        }
    }
}
