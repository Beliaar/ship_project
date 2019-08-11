using System;
using System.Reflection;
using Godot;
using Xunit.Runners;

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
                GD.Print("Tests starting");
                AssemblyRunner runner = Xunit.Runners.AssemblyRunner.WithoutAppDomain(Assembly.GetExecutingAssembly().Location);
                runner.OnTestStarting = info =>
                {
                    GD.Print($"Running {info.TestDisplayName}");
                };
                runner.OnTestPassed = info =>
                {
                    GD.Print($"{info.TestDisplayName} passed");
                };
                runner.OnTestFailed = info =>
                {
                    GD.Print($"{info.TestDisplayName} failed");
                };
                runner.OnTestOutput = info =>
                {
                    GD.Print($"{info.TestDisplayName}: {info.Output}");
                };
                runner.OnExecutionComplete = info =>
                {
                    GD.Print($"Tests completed in {info.ExecutionTime}");
                    GD.Print($"Total tests: {info.TotalTests}");
                    GD.Print($"Failed tests: {info.TestsFailed}");
                    GD.Print($"Skipped tests: {info.TestsSkipped}");
                };
                runner.Start();
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
