using ServiceLocator.Player;
using ServiceLocator.Utilities;
using UnityEngine;

namespace Assets.Scripts.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        [SerializeField] public PlayerScriptableObject playerScriptableObject;

        public PlayerService playerService { get; private set; }

        void Start()
        {
            playerService = new PlayerService(playerScriptableObject);
        }

        public void Update()
        {
            if (playerService != null)
            {
                playerService.CheckForInput();
            }
        }
    }
}