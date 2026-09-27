using Avalonia.Controls.ApplicationLifetimes;
using Reviolet.Scenes;

namespace Reviolet;

public class Frontend
{
	// replace later! this is supposed to be Navigator's job
	private IScene _currentScene;
	private MainWindow? _mainWindow;

	public Frontend()
	{
		_currentScene = new TasklistScene();
	}

	// called by App after framework init, to start presentation
	public void GenerateMainWindow(IClassicDesktopStyleApplicationLifetime desktop)
	{
		// initialize a MainWindow and a MainVM
		_mainWindow = new MainWindow(_currentScene);

		// set MainWindow as the actual window of the app
		desktop.MainWindow = _mainWindow;
	}
}