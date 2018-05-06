using System;
using Patterns_ClassicObserver.Agregator;
using Patterns_ClassicObserver.Widgets;

namespace Patterns_ClassicObserver {
	
	class Program {
		
		static void Main(string[] args) {

			NewsAgregator agregator = new NewsAgregator();
			Chanel1Widget ch1Widget = new Chanel1Widget(agregator);
			Chanel2Widget ch2Widget = new Chanel2Widget(agregator);

			agregator.NewNewsAwailable();

			//agregator.RemoveObserver(ch1Widget);
			// or
			ch2Widget.RemoveFromAgregator();

			agregator.NewNewsAwailable();
			
			Console.ReadLine();
			
		}
	}
}
