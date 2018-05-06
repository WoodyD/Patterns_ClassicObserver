namespace Patterns_ClassicObserver.Widgets {
	
	public interface IObserver {

		void Update(string chanel1News, string chanel2News);
		void RemoveFromAgregator();
	
	}
}
