using Godot;

namespace Ship_Project.Scripts {
    public class ActorSystem : Reference
    {
        private Resource world;

        public ActorSystem()
        {
        }

        public void HandleGameObjectAdded(Godot.Object gameObjectId)
        {
        }

        public void HandleGameObjectRemoved(Godot.Object gameObjectId)
        {
        }

        public void SetWorld(Resource resource)
        {
            world = resource;
            resource.Connect("object_added", this, nameof(HandleGameObjectAdded));
            resource.Connect("object_removed", this, nameof(HandleGameObjectRemoved));
        }
    }
}
