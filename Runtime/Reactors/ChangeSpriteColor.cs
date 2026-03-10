using System.Collections.Generic;
using UnityEngine;

namespace FD.AdventureToolkit {
    public class ChangeSpriteColor : MonoBehaviour {
        SpriteRenderer sp;
        public List<Color> colorList;
        private void Awake() {
            sp = GetComponent<SpriteRenderer>();
        }

        public void SetColor(int colorIndex) {
            sp.color = colorList[colorIndex];
        }
    }
}
