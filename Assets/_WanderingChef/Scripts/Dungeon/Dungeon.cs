using MoreMountains.Tools;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class Dungeon : MonoBehaviour, MMEventListener<MMGameEvent>
    {
        private int _enemyCountOnThisFloor;

        private void OnEnable()
        {
            this.MMEventStartListening<MMGameEvent>();
        }

        private void OnDisable()
        {
            this.MMEventStopListening<MMGameEvent>();
        }

        public void OnMMEvent(MMGameEvent eventType)
        {
            if (eventType.EventName == "OnDungeonGenerated")
            {
                CalculateEnemyOnThisFloor();
            }

            if (eventType.EventName == "OnEnemyDeath")
            {
                DecreaseEnemyCount();
            }
        }

        private void CalculateEnemyOnThisFloor()
        {
            Floor[] floors = GetComponentsInChildren<Floor>();
            _enemyCountOnThisFloor = 0;

            foreach (Floor floor in floors)
            {
                _enemyCountOnThisFloor += floor.GetEnemyCount();
            }

            Debug.Log($"Initial Enemy Count: {_enemyCountOnThisFloor}");
        }

        private void DecreaseEnemyCount()
        {
            _enemyCountOnThisFloor--;

            if (_enemyCountOnThisFloor <= 0)
            {
                _enemyCountOnThisFloor = 0;
                MMGameEvent.Trigger("OnEnemiesCleared");
            }

            Debug.Log($"Current Enemy Count: {_enemyCountOnThisFloor}");
        }
    }
}
