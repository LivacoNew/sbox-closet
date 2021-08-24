using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using Sandbox.UI.Tests;
using sbox_closet.code.playerpawn;

namespace sbox_closet.code.ui {
    public class SelectionPanel : Panel {
        // private VirtualScrollPanel virtualScrollPanel;
        private readonly Panel scrollyBoi;
        public List<String> Data {get; set;}
        public string Title {get; set;}
        public Action<string> Callback {get; set;}

        public SelectionPanel() {
            // virtualScrollPanel = AddChild<VirtualScrollPanel<Button>>();

            scrollyBoi = Add.Panel("scroll");
        }

        // Since Data isn't set until after the construction this is the best I can do.
        public void PerformLayout() {
            scrollyBoi.Add.Label(Title, "selectionTitle");

            foreach(string str in Data) {
                // fuckin hell 
                Button button = new(str, "", delegate() {
                    Callback(str);
                });
                button.AddClass("selectionButton");
                // button.Style.Set("height: 50px; background-color: black; color: black;");
                scrollyBoi.AddChild(button);
            }
        }
    }
}