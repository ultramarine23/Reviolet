using System;

namespace Reviolet;

public enum SceneName
{
	TASKLIST,
	SETTINGS
}

public interface INavigation
{
	public SceneControl? CurrentScene { get; }
	public event Action<SceneName>? SceneChanged;
	
	public void NavigateToScene(SceneName destination);
}