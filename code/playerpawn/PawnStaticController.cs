using Sandbox;
using Sandbox.UI;

namespace sbox_closet.code.playerpawn {
    public class PawnStaticController : BasePlayerController {
        public override void Simulate() {
            Position = new Vector3(100, -30, -8);
            // Log.Info(Input.Rotation);
            Rotation rot = new Rotation {
                x = -0.03909f,
                y = 0.00493f,
                z = 0.89f,
                w = 0.12497f
            };
            Rotation = rot;
        }
    }
}