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
            global::MessyCore.Mod.Capabilities.Set("road.elevation-tools", global::MessyCore.Mod.Settings.EnableRoadElevationTools ? "enabled" : "disabled");
            global::MessyCore.Mod.Diagnostics.SetState("road.module", "ready");
        }

        protected override void OnUpdate()
        {
            if (!global::MessyCore.Mod.Settings.RoadToolsModuleEnabled)
            {
                global::MessyCore.Mod.Diagnostics.SetState("road.runtime", "disabled");
                return;
            }
            global::MessyCore.Mod.Capabilities.Set("road.runtime", "active");
            global::MessyCore.Mod.Diagnostics.SetState("road.runtime", global::MessyCore.Mod.Settings.EnableRoadElevationTools ? "elevation-active" : "active");
        }
    }
}
