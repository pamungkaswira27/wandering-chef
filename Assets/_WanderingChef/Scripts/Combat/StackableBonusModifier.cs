using NaughtyAttributes;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class StackableBonusModifier : MonoBehaviour
    {
        [Header("Bonus Attribute")]
        [SerializeField]
        private BonusAttribute _attribute;

        [ShowIf("_attribute", BonusAttribute.DamagePercentage)]
        [SerializeField]
        private float _damagePercentage;

        [Header("Stack Size")]
        [SerializeField]
        private int _maxStackSize;

        private int _currentStackSize = 1;

        [System.Serializable]
        public enum BonusAttribute
        {
            AttackPoints,
            DefensePoints,
            Damage,
            DamagePercentage
        }

        public void IncreaseStackSize()
        {
            _currentStackSize++;

            if (_currentStackSize >= _maxStackSize)
            {
                _currentStackSize = _maxStackSize;
            }
        }

        public float GetTotalBonusDamagePercentage()
        {
            return (_damagePercentage / 100) * _currentStackSize;
        }
    }
}
