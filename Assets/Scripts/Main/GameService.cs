using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.Utilities;
using UnityEngine;

namespace Assets.Scripts.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        [SerializeField] public PlayerScriptableObject playerScriptableObject;
        [SerializeField] private SoundScriptableObject soundScriptableObject;
        [SerializeField] private AudioSource audioEffects;
        [SerializeField] private AudioSource backgroundMusic;

        public SoundService soundService { get; private set; }
        public PlayerService playerService { get; private set; }

        void Start()
        {
            playerService = new PlayerService(playerScriptableObject);
            soundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
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