namespace DebugUI
{
    public sealed class DebugWindowOptions : IDebugUIOptions
    {
        public string Title { get; set; } = "Debug";
        public bool Draggable { get; set; } = true;
        public bool Foldout { get; set; } = true;
    }
}