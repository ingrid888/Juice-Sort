using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace corcor
{
    public class InformacoesGerais : MonoBehaviour
    {
        public static List<Color> cores = new List<Color>() {new Color(0, 255, 255), new Color(255, 0 , 0)};
        public static int[] coresUsadas = new int[2];
        public static int numeroDeCopos = 3;
    }
  
}
