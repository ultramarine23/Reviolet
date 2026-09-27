using System;
using Avalonia.Controls.ApplicationLifetimes;
using Reviolet.Scenes;
using Reviolet.Views;

namespace Reviolet;

public class Frontend : INavigation
{
	// frontend is dependent on backend to function. 
	// backend doesn't even know frontend exists.
	// many such cases
	private Backend _backend;
	private MainWindow? _mainWindow;

	public SceneControl? CurrentScene { get; private set; }
	public event Action<SceneName>? SceneChanged;

	// Two-stage initialization {o}
	public Frontend(Backend backend)
	{
		_backend = backend;
	}

	// called by App after framework init, to start presentation
	public void GenerateMainWindow(IClassicDesktopStyleApplicationLifetime desktop)
	{
		// initialize an empty main window
		var initScene = new TasklistScene();
		var sidebar = new SidebarView(this);
		_mainWindow = new MainWindow(sidebar, initScene);
		SceneChanged?.Invoke(SceneName.TASKLIST);

		// set MainWindow as the actual window of the app
		desktop.MainWindow = _mainWindow;
	}


	// Navigation interface implementation {g}
	public void NavigateToScene(SceneName destination)
	{
		if (_mainWindow == null)
		{
			Console.WriteLine("[ERR] Request to switch scenes, but main window is missing");
			return;
		}

		SceneControl newScene;
		switch (destination)
		{
			case SceneName.TASKLIST:
				newScene = new TasklistScene();
				break;
			case SceneName.SETTINGS:
				newScene = new SettingsScene();
				break;
			default:
				Console.WriteLine("[ERR] Attempt to switch scenes but scene name is undefined.");
				return;
		}

		_mainWindow.SwitchScene(newScene);
		CurrentScene = newScene;
		SceneChanged?.Invoke(destination);
	}
}