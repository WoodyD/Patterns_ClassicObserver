using System;
using Patterns_ClassicObserver.Agregator;
using Patterns_ClassicObserver.Widgets;

namespace Patterns_ClassicObserver {
	
	class Program {
		
		static void Main(string[] args) {

			IAgregator agregator = new NewsAgregator();
			IObserver ch1Widget = new Chanel1Widget(agregator);
			IObserver ch2Widget = new Chanel2Widget(agregator);

			agregator.NotifyObservers();

			//agregator.RemoveObserver(ch1Widget);
			// or
			ch2Widget.RemoveFromAgregator();

			agregator.NotifyObservers();
			
			Console.ReadLine();
			
		}
	}
}
