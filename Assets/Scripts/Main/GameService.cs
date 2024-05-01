using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using UnityEngine;

namespace Assets.Scripts.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        public SoundService soundService { get; private set; }
        public PlayerService playerService { get; private set; }
        public UIService uiService => _uiService;

        [SerializeField] public PlayerScriptableObject playerScriptableObject;
        [SerializeField] private SoundScriptableObject soundScriptableObject;
        [SerializeField] private AudioSource audioEffects;
        [SerializeField] private AudioSource backgroundMusic;
        [SerializeField] private UIService _uiService;



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