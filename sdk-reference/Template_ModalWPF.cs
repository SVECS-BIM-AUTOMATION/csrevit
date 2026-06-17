using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API;

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    public class LaunchModalCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // 1. Create your WPF Window
            MyWpfWindow window = new MyWpfWindow(commandData.Application.ActiveUIDocument.Document);

            // 2. Set Revit as the parent window so it centers properly
            var helper = new System.Windows.Interop.WindowInteropHelper(window);
            helper.Owner = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            // 3. Launch it Modally (Locks Revit until closed)
            window.ShowDialog();

            return Result.Succeeded;
        }
    }
}
