using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class Floor : MonoBehaviour
    {
        [Header("Floor Properties")]
        [SerializeField]
        private Character[] _enemies;

        public int GetEnemyCount()
        {
            _enemies = GetComponentsInChildren<Character>();
            return _enemies.Length;
        }
    }
}
