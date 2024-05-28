using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class PlayerManager : MonoBehaviour
    {
        public static PlayerManager Instance;

        private void Awake()
        {
            Instance = this;
        }
    }
}
