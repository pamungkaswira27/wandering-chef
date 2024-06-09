using Edgar.Unity;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using UnityEngine;

namespace ParaPejuang.WanderingChef
{
    public class DungeonManager : MonoBehaviour, MMEventListener<MMGameEvent>
    {
        [Header("Dungeon Generator")]
        [SerializeField]
        private DungeonGeneratorGrid2D _generator;
        [SerializeField]
        private MMF_Player _onDungeonGeneratedFeedback;

        private void OnEnable()
        {
            this.MMEventStartListening<MMGameEvent>();
        }

        private void Start()
        {
            GenerateDungeon();
        }

        private void OnDisable()
        {
            this.MMEventStopListening<MMGameEvent>();
        }

        public void GenerateDungeon()
        {
            _generator.Generate();
            _onDungeonGeneratedFeedback.PlayFeedbacks();
        }

        public void OnMMEvent(MMGameEvent eventType)
        {
            if (eventType.EventName == "OnEnemiesCleared")
            {
                GenerateDungeon();
            }
        }
    }
}
