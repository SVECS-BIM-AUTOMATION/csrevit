Step 1: The Enterprise Background Service (In the Services Folder)

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    public class MyEnterpriseService : IExternalApplication, IcsRevitBackgroundService
    {
        // 1. Expose a static instance so the UI Button can find this service!
        public static MyEnterpriseService Instance { get; private set; }

        // 2. Implement the IcsRevitBackgroundService Contract
        public string ServiceName => "Enterprise Door Updater";
        public string Version => "1.0.0";
        public ServiceState CurrentState { get; private set; } = ServiceState.Offline;

        public Result OnStartup(UIControlledApplication app)
        {
            Instance = this;
            CurrentState = ServiceState.Idle; // Mark as ready
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            CurrentState = ServiceState.Offline;
            return Result.Succeeded;
        }

        // 3. The Execution Payload triggered by the UI Button
        public Result ExecuteTriggerFromUI(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            CurrentState = ServiceState.Processing; // Lock the service so it isn't triggered twice
            
            try
            {
                Document doc = commandData.Application.ActiveUIDocument.Document;
                TaskDialog.Show(ServiceName, "The UI Button successfully triggered the Background Service!");
                
                return Result.Succeeded;
            }
            catch (System.Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
            finally
            {
                CurrentState = ServiceState.Idle; // Unlock the service
            }
        }
    }
}

Step 2: The Clickable Button (In the .pushbutton Folder)

  using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    [Transaction(TransactionMode.Manual)]
    public class TriggerServiceCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // The Button connects to the Interface via the exposed Instance
            IcsRevitBackgroundService myService = MyEnterpriseService.Instance;

            // 1. Ensure it exists and is running
            if (myService == null || myService.CurrentState == ServiceState.Offline)
            {
                message = "The background service is offline. Please restart Revit.";
                return Result.Failed;
            }

            // 2. Prevent Double-Clicking / Thread Crashes
            if (myService.CurrentState == ServiceState.Processing)
            {
                TaskDialog.Show(myService.ServiceName, "Please wait, the service is currently busy processing another task.");
                return Result.Cancelled;
            }

            // 3. Pass the Revit context directly to the Background Service!
            return myService.ExecuteTriggerFromUI(commandData, ref message, elements);
        }
    }
}
