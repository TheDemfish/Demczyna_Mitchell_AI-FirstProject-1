using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

    [Category("Movement")]
    public class Pain : ActionTask<Transform> {

        public BBParameter<float> pain = 5f;

        protected override void OnUpdate() {
            // Shrink the cube based on "pain"
            agent.localScale -= Vector3.one * pain.value * Time.deltaTime;

            // Prevent scale from going negative or inside-out
            if (agent.localScale.x < 0.01f) {
                agent.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            }
        }
    }
}





