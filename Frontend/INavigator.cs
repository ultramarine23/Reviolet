namespace Reviolet;

public enum SceneName
{
	TASKLIST,
	SETTINGS
}

public interface INavigation
{
	public SceneControl? CurrentScene { get; }
	
	public void NavigateToScene(SceneName destination);
}