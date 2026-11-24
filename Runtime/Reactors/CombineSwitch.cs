using UnityEngine;

namespace FD.AdventureToolkit {
    public class CombineSwitch : Switch {
        public Switch switchA;
        public bool desiredAState = true;
        public Switch switchB;
        public bool desiredBState = true;

        protected override void Awake() {
            // DO NOTHING
        }

        override protected void Start() {
            switchA.whenOn.AddListener(UpdateSwitchCombination);
            switchA.whenOff.AddListener(UpdateSwitchCombination);
            switchB.whenOn.AddListener(UpdateSwitchCombination);
            switchB.whenOff.AddListener(UpdateSwitchCombination);

            UpdateSwitchCombination();
        }

        protected virtual void UpdateSwitchCombination() {
            bool oldState = on;
            on = CheckCombination();
            ChangeCheck(on, oldState);

            RepaintEditor();
        }

        protected virtual bool CheckCombination() {
            return switchA.on == desiredAState && switchB.on == desiredBState;
        }

        public override void Set(bool newSwitched) {
            // DO NOTHING
            Debug.LogWarning("Set Function shouldn't be used directly on Combine Switch");
        }

        public override void Toggle() {
            // DO NOTHING
            Debug.LogWarning("Toggle Function shouldn't be used directly on Combine Switch");
        }
    }
}
