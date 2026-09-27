namespace Reviolet;

public class Navigator
{
	private Backend _backend;
	private Frontend _frontend;

	public Navigator(Backend backend, Frontend frontend)
	{
		_backend = backend;
		_frontend = frontend;
	}
}