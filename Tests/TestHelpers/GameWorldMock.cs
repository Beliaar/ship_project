using Godot;

namespace Ship_Project_Tests.test_helpers
{
    internal class GameWorldMock : Resource
    {
        [Signal]
        // ReSharper disable once InconsistentNaming / Needs to mimic a GDScript class.
        public delegate void object_added(Godot.Object id);
        [Signal]
        // ReSharper disable once InconsistentNaming / Needs to mimic a GDScript class.
        public delegate void object_removed(Godot.Object id);
    }    
}
