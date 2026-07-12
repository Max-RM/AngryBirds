namespace PerformanceMeasuring.GameDebugTools;

public interface IDebugEchoListner
{
	void Echo(DebugCommandMessage messageType, string text);
}
