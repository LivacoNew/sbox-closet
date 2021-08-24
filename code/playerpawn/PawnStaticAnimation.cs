using Sandbox;

namespace sbox_closet.code.playerpawn {
    public class PawnStaticAnimation : PawnAnimator {
        public override void Simulate() {
            SetParam("b_grounded", true); // Force ourselves to be grounded

            Vector3 aimPos = new Vector3(-50, 0, -30);
            SetLookAt("lookat_pos", aimPos);
            SetLookAt("aimat_pos", aimPos);
            SetLookAt("aim_eyes", aimPos);
            SetLookAt("aim_head", aimPos);
            SetLookAt("aim_body", aimPos);
        }
    }
}