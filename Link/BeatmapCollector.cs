using Zenject;

namespace Link
{
    internal class BeatmapCollector : IInitializable, ILateDisposable
    {
        private readonly BeatmapLevel _difficultyBeatmap;
        private readonly IBeatmapStateManager _beatmapStateManager;

        public BeatmapCollector(BeatmapLevel difficultyBeatmap, IBeatmapStateManager beatmapStateManager)
        {
            _difficultyBeatmap = difficultyBeatmap;
            _beatmapStateManager = beatmapStateManager;
        }

        public void Initialize()
        {
            _beatmapStateManager.ActiveBeatmap = _difficultyBeatmap;
            _beatmapStateManager.LastBeatmap = null;
        }

        public void LateDispose()
        {
            _beatmapStateManager.LastBeatmap = _difficultyBeatmap;
            _beatmapStateManager.ActiveBeatmap = null;
        }
    }
}