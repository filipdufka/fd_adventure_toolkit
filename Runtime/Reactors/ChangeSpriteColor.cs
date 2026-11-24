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
            if (sp == null) {
                return;
            }
            sp.color = colorList[colorIndex];
        }
    }
}
