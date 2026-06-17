using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API; // Required for SettingsManager

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Auto Dimension")]
    public class AutoDimToggleCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Read the state that the user just toggled to
            string currentState = SettingsManager.ReadSetting("ToggleStates", "Auto Dimension", "Off");

            if (currentState == "On")
            {
                TaskDialog.Show("Toggle", "Auto Dimensioning is now ENABLED.");
            }
            else
            {
                TaskDialog.Show("Toggle", "Auto Dimensioning is now DISABLED.");
            }

            return Result.Succeeded;
        }
    }
}
