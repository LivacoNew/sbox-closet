using Sandbox;
using Sandbox.ScreenShake;
using System;
using System.Collections;
using System.ComponentModel;

namespace sbox_closet.code.playerpawn {
    public partial class PlayerPawn : Player {
        ModelEntity hat;
        ModelEntity jacket;
        ModelEntity pants;
        ModelEntity shoes;

        public override void Respawn() {
            SetModel("models/citizen/citizen.vmdl");

            Controller = new PawnStaticController();
            Animator = new PawnStaticAnimation();
            // Camera = new ThirdPersonCamera(); // TODO
            Camera = new PawnStaticCamera(); 

            EnableDrawing = true;

            base.Respawn();
        }

        public void RandomDress() {
            // just put on a random hat for now
            System.Random rand = new();
            
            SetHat(GameConfig.hats[rand.Next(GameConfig.hats.Count)]);
            SetJacket(GameConfig.jackets[rand.Next(GameConfig.jackets.Count)]);
            SetPants(GameConfig.pants[rand.Next(GameConfig.pants.Count)]);
            SetShoes(GameConfig.shoes[rand.Next(GameConfig.shoes.Count)]);
        }

        // yes all 4 of these are copy and pasted
        public void SetHat(string model) {
            // this is probably bad. oh well.
            if(hat != null) hat.Delete();

            hat = new ModelEntity();
            hat.SetModel(model);
            hat.SetParent(this, true);
        }
        public void SetJacket(string model) {
            // this is probably bad. oh well.
            if(jacket != null) jacket.Delete();

            jacket = new ModelEntity();
            jacket.SetModel(model);
            jacket.SetParent(this, true);
        }
        public void SetPants(string model) {
            // this is probably bad. oh well.
            if(pants != null) pants.Delete();

            pants = new ModelEntity();
            pants.SetModel(model);
            pants.SetParent(this, true);
        }
        public void SetShoes(string model) {
            // this is probably bad. oh well.
            if(shoes != null) shoes.Delete();

            shoes = new ModelEntity();
            shoes.SetModel(model);
            shoes.SetParent(this, true);
        }
    }
}