using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            IView view = new ConsoleView();
            Presenter presenter = new Presenter(model, view);

            presenter.LoadAndDisplayData();
        }
    }

    public class ConsoleView : IView
    {
        public void DisplayData(string data)
        {
            Console.WriteLine($"Data from model: {data}");
        }
    
    }
}