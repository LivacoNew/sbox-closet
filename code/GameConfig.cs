using System;
using System.Collections.Generic;

namespace sbox_closet.code {
    public class GameConfig {
        // This file defines all the config stuff for the game.
        // I know this is really shitty, as far as I know S&Box doesn't have any "config" system yet.
        // If I'm wrong with that lemme know and I'll get rid of this lol


        // This file lists all the possible models for the hats, jackets, pants and shoes the player
        // can have - this was all ripped from the Sandbox Player.Clothes.cs file:
        // https://github.com/Facepunch/sandbox/blob/master/code/Player.Clothes.cs


        // Hats
        public readonly static List<String> hats = new() {
            "models/citizen_clothes/hat/hat_hardhat.vmdl",
            "models/citizen_clothes/hat/hat_woolly.vmdl",
            "models/citizen_clothes/hat/hat_securityhelmet.vmdl",
            "models/citizen_clothes/hair/hair_malestyle02.vmdl",
            "models/citizen_clothes/hair/hair_femalebun.black.vmdl",
            "models/citizen_clothes/hat/hat_beret.red.vmdl",
            "models/citizen_clothes/hat/hat.tophat.vmdl",
            "models/citizen_clothes/hat/hat_beret.black.vmdl",
            "models/citizen_clothes/hat/hat_cap.vmdl",
            "models/citizen_clothes/hat/hat_leathercap.vmdl",
            "models/citizen_clothes/hat/hat_leathercapnobadge.vmdl",
            "models/citizen_clothes/hat/hat_securityhelmetnostrap.vmdl",
            "models/citizen_clothes/hat/hat_service.vmdl",
            "models/citizen_clothes/hat/hat_uniform.police.vmdl",
            "models/citizen_clothes/hat/hat_woollybobble.vmdl",
        };

        // Jackets
        public readonly static List<String> jackets = new() {
            "models/citizen_clothes/jacket/labcoat.vmdl",
            "models/citizen_clothes/jacket/jacket.red.vmdl",
            "models/citizen_clothes/jacket/jacket.tuxedo.vmdl",
            "models/citizen_clothes/jacket/jacket_heavy.vmdl",
        };

        // Pants
        public readonly static List<String> pants = new() {
            "models/citizen_clothes/trousers/trousers.jeans.vmdl",
            "models/citizen_clothes/trousers/trousers.lab.vmdl",
            "models/citizen_clothes/trousers/trousers.police.vmdl",
            "models/citizen_clothes/trousers/trousers.smart.vmdl",
            "models/citizen_clothes/trousers/trousers.smarttan.vmdl",
            "models/citizen_clothes/trousers/trousers_tracksuitblue.vmdl",
            "models/citizen_clothes/trousers/trousers_tracksuit.vmdl",
            "models/citizen_clothes/shoes/shorts.cargo.vmdl", // wtf lol
        };

        // Shoes
        public readonly static List<String> shoes = new() {
            "models/citizen_clothes/shoes/trainers.vmdl",
            "models/citizen_clothes/shoes/shoes.workboots.vmdl"
        };
    }
}