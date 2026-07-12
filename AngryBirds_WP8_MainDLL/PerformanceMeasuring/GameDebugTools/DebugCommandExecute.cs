using System.Collections.Generic;

namespace PerformanceMeasuring.GameDebugTools;

public delegate void DebugCommandExecute(IDebugCommandHost host, string command, IList<string> arguments);
