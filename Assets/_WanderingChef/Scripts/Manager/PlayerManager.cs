using MoreMountains.TopDownEngine;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class PlayerManager : MonoBehaviour
    {
        public static PlayerManager Instance;

        private PlayerAttribute _playerAttribute;

        public PlayerAttribute PlayerAttribute => _playerAttribute;

        private void Awake()
        {
            Instance = this;
        }

        public void SetupPlayer(Character player)
        {
            _playerAttribute = player.GetComponent<PlayerAttribute>();
        }
    }
}
