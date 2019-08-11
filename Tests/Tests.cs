using System;
using Godot;

namespace Ship_Project.Tests {
    public class Tests : Control
    {
        // Declare member variables here. Examples:
        // private int a = 2;
        // private string b = "text";

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
        }

        public void RunTestsClicked()
        {
            try
            {
                GD.Print("Running ActorSystem tests");
                var actorSystemTests = new ActorSystemTests();
                actorSystemTests.SetWorldConnectsActorSystemToWorld();
                GD.Print("ActorSystem tests Completed");
            }
            catch (Exception e)
            {
                GD.Print(e.Message);
            }
        }

        //  // Called every frame. 'delta' is the elapsed time since the previous frame.
        //  public override void _Process(float delta)
        //  {
        //      
        //  }
    }
}
