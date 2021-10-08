using UnityEngine;

namespace Assets.Scenes
{
    public class Scriptouch : MonoBehaviour
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
