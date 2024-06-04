using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    public class Model
    {
        public string Data { get; set; }

        public void LoadData()
        {
            // Логика загрузки данных
            Data = "Sample Data";
        }
    }
}