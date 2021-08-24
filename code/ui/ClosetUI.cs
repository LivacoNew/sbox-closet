using System;
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using sbox_closet.code.playerpawn;

namespace sbox_closet.code.ui {
    public class ClosetUI : HudEntity<RootPanel> {
        public ClosetUI() {
            if (!IsClient) return;

            RootPanel.StyleSheet.Load("/ui/ClosetUI.scss");

            // Side Panel
            Panel panel = RootPanel.Add.Panel("side_panel");

            // Selection stuff
            // I gave the fuck up trying to get the flexboxes working here so enjoy this clusterfuck
            Panel selectionPanel = panel.Add.Panel("selection_panel");

            Panel rowOne = selectionPanel.Add.Panel("selectionRow");
            // Hats
            SelectionPanel hatSlectionPanel = new() {
                Title = "Hats",
                Data = GameConfig.hats,
                Callback = delegate(string str) {
                    (Local.Pawn as PlayerPawn).SetHat(str);
                }
            };
            hatSlectionPanel.PerformLayout();
            rowOne.AddChild(hatSlectionPanel);
            
            // Jackets
            SelectionPanel jacketSlectionPanel = new() {
                Title = "Jackets",
                Data = GameConfig.jackets,
                Callback = delegate(string str) {
                    (Local.Pawn as PlayerPawn).SetJacket(str);
                }
            };
            jacketSlectionPanel.PerformLayout();
            rowOne.AddChild(jacketSlectionPanel);

            Panel rowTwo = selectionPanel.Add.Panel("selectionRow");
            // Pants (or Trousers if your bri*sh)
            SelectionPanel pantsSlectionPanel = new() {
                Title = "Pants",
                Data = GameConfig.pants,
                Callback = delegate(string str) {
                    (Local.Pawn as PlayerPawn).SetPants(str);
                }
            };
            pantsSlectionPanel.PerformLayout();
            rowTwo.AddChild(pantsSlectionPanel);
            // Shoes
            SelectionPanel shoesSlectionPanel = new() {
                Title = "Shoes",
                Data = GameConfig.shoes,
                Callback = delegate(string str) {
                    (Local.Pawn as PlayerPawn).SetShoes(str);
                }
            };
            shoesSlectionPanel.PerformLayout();
            rowTwo.AddChild(shoesSlectionPanel);
            

            // Buttons
            Panel buttonPanel = panel.Add.Panel("button_panel");
            buttonPanel.AddChild(RootPanel.Add.Button("Random Outfit", "button", delegate() {
                (Local.Pawn as PlayerPawn).RandomDress();
            }));
            RootPanel.AddChild(panel);


            Log.Info("UI Loaded.");
        }
    }
}