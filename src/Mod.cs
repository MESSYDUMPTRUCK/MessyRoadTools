using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using MessyCore;

namespace MessyRoadTools
{
    public class Mod : IMod
    {
        public const string ModName = "MessyRoadTools";
        public const string ModVersion = "0.1.0-beta";
        public static ILog Log = LogManager.GetLogger(ModName).SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            MessyCore.Mod.Registry.Register(ModName);
            updateSystem.UpdateAt<Systems.RoadGradeToolSystem>(SystemUpdatePhase.GameSimulation);
            Log.Info($"{ModName} loaded");
        }

        public void OnDispose() { Log.Info($"{ModName} disposed"); }
    }
}
