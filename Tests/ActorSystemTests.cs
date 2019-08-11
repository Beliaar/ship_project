using Ship_Project.Scripts;
using Ship_Project_Tests.test_helpers;
using Shouldly;
using Xunit;

namespace Ship_Project.Tests
{
    public class ActorSystemTests
    {
        [Fact]
        public void SetWorldConnectsActorSystemToWorld()
        {
            var world = new GameWorldMock();
            var actorSystem = new ActorSystem();
            actorSystem.SetWorld(world);
            world.IsConnected(nameof(GameWorldMock.object_added), actorSystem, nameof(ActorSystem.HandleGameObjectAdded)).ShouldBeTrue();
            world.IsConnected(nameof(GameWorldMock.object_removed), actorSystem, nameof(ActorSystem.HandleGameObjectRemoved)).ShouldBeTrue();
        }
    }
}