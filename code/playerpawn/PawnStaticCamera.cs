using Sandbox;

namespace sbox_closet.code.playerpawn {
    public class PawnStaticCamera : Camera {
        public override void Update() {
            Pos = new Vector3(-25, 20, 30);
            Rot = new Rotation();

            FieldOfView = 54;
        }
    }
}