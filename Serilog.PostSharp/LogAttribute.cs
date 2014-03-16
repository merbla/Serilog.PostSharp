using System;
using PostSharp.Aspects;

namespace Serilog.PostSharp
{
    [Serializable]
    public class LogAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Log.Debug("Method");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
            Log.Debug("Method");
        }
    }
}