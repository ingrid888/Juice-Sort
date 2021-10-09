using UnityEngine;

namespace Assets.Scenes
{
    public class ScripTouch : MonoBehaviour
    {

        public class Toque : MonoBehaviour
        {
            void Update()
            {
                Touch[] touches = Input.touches;
            }
        }
    }
}
