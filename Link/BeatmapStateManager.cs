namespace Link
{
    internal interface IBeatmapStateManager
    {
        BeatmapLevel? LastBeatmap { get; set; }
        BeatmapLevel? ActiveBeatmap { get; set; }
    }

    internal class BeatmapStateManager : IBeatmapStateManager
    {
        public BeatmapLevel? LastBeatmap { get; set; }
        public BeatmapLevel? ActiveBeatmap { get; set; }
    }
}