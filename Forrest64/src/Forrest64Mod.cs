using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Forrest64
{
    [BepInPlugin("raicuparta.forrest64", "Forrest64", "1.0.0")]
    public class Forrest64Mod : BaseUnityPlugin
    {
        private const string testSceneName = "TestByrnes";
        private vgSuperByrnesMode byrnesMode;
        
        private void Awake()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
        {
            PreventDestruction(transform);

            if (!byrnesMode)
            {
                byrnesMode = FindObjectOfType<vgSuperByrnesMode>();
                if (!byrnesMode) return;
            }

            if (scene.name == testSceneName)
            {
                PreventDestruction(byrnesMode.transform);
            }
        }

        private void PreventDestruction(Transform targetTransform)
        {
            var onlyLoadOnce = GameObject.Find("_OnlyLoadOnce");
            if (!onlyLoadOnce) return;
            targetTransform.SetParent(onlyLoadOnce.transform);
            targetTransform.tag = "MAIN";
        }

        private void ToggleByrnesMode()
        {
            if (!byrnesMode) return;

            
            if (byrnesMode.enabled)
            {
                byrnesMode.enabled = false;
            }
            else
            {
                var normalPlayer = FindObjectOfType<vgPlayerController>().transform;
                var superPlayer = byrnesMode.GetComponentInChildren<SuperCharacterController>(true);
                byrnesMode.transform.position = normalPlayer.position;
                superPlayer.transform.position = normalPlayer.transform.position;
                superPlayer.currentGround = new SuperCharacterController.Ground();
                byrnesMode.enabled = true;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SceneManager.LoadScene(testSceneName);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                ToggleByrnesMode();
            }
        }
    }
}
