using UnityEngine;

namespace Configs
{
    public enum Controller
    {
        KeyController,
        MouseController
    }

    [CreateAssetMenu(fileName = "LaunchConfigs", menuName = "App/Launch")]
    public class Configs : ScriptableObject
    {
        public Controller myController;
        public bool camera;
    }
}