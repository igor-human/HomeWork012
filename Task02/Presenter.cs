using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    public class Presenter
    {
        private readonly Model _model;
        private readonly IView _view;

        public Presenter(Model model, IView view)
        {
            _model = model;
            _view = view;
        }

        public void LoadAndDisplayData()
        {
            _model.LoadData();
            _view.DisplayData(_model.Data);
        }
    }
}