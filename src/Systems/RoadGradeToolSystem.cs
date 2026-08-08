using Game;
using MessyCore;

namespace MessyRoadTools.Systems
{
    public partial class RoadGradeToolSystem : GameSystemBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            global::MessyCore.Mod.Log.Info("RoadGradeToolSystem ready");
            global::MessyCore.Mod.Capabilities.Set("road.module", "ready");
            global::MessyCore.Mod.Capabilities.Set("road.grade-assist", global::MessyCore.Mod.Settings.UseGradeAssist ? "enabled" : "disabled");
        }

        protected override void OnUpdate()
        {
            if (!global::MessyCore.Mod.Settings.RoadToolsModuleEnabled) return;
            global::MessyCore.Mod.Capabilities.Set("road.runtime", "active");
        }
    }
}

