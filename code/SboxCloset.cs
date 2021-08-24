using Sandbox;
using sbox_closet.code.ui;
using sbox_closet.code.playerpawn;

namespace sbox_closet.code {
    public partial class SboxCloset : Game {
        public SboxCloset() {
            Log.Info("Closet starting.");

            if(IsServer) {
                new ClosetUI();
            }
        }

        public override void ClientJoined(Client cl) {
            base.ClientJoined(cl);

            PlayerPawn pawn = new();
            cl.Pawn = pawn;
            pawn.Respawn();
        }
    }
}
