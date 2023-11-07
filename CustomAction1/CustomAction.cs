using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAction1
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            // System.Diagnostics.Debugger.Launch();
            session["Property1"] = "Truely";
            session.Log("Begin CustomAction1 ----------");
           
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult GetTimeZone(Session session)
        {
            //System.Diagnostics.Debugger.Launch();
            string timeZoneName =
            TimeZone.CurrentTimeZone.StandardName;
            // store the time zone in a property
            session["TIME_ZONE"] = timeZoneName;
            return ActionResult.Success;
        }
    }
}
