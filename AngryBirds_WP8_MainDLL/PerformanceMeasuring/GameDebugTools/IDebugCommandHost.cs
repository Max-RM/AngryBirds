namespace PerformanceMeasuring.GameDebugTools;

public interface IDebugCommandHost : IDebugEchoListner, IDebugCommandExecutioner
{
	void RegisterCommand(string command, string description, DebugCommandExecute callback);

	void UnregisterCommand(string command);

	void Echo(string text);

	void EchoWarning(string text);

	void EchoError(string text);

	void RegisterEchoListner(IDebugEchoListner listner);

	void UnregisterEchoListner(IDebugEchoListner listner);

	void PushExecutioner(IDebugCommandExecutioner executioner);

	void PopExecutioner();
}
