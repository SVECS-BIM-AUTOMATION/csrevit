using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API; // The Central csRevit API is readily available!

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Quick Format")]
    [Description("Formats the active view.")]
    public class QuickFormatCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            
            try
            {
                // YOUR LOGIC HERE
                return Result.Succeeded; 
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed; // Automatically launches the csRevit Debug Console
            }
        }
    }
}
