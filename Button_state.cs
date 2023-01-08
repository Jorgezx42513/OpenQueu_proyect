using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace OpenQueu
{
    class Button_state
    {
        Color on = (Color)ColorConverter.ConvertFromString("#86e3e5");
        Color off = (Color)ColorConverter.ConvertFromString("#ff0f9b");
        public Button_state(Button button, bool type)
        {
            if (type == true)
            {
                button.Background = new SolidColorBrush(Colors.Transparent);
                button.Foreground = new SolidColorBrush(off);
                button.BorderBrush= new SolidColorBrush(off);
                button.Content = "Stop";
            }
            else
            {
                button.Background = new SolidColorBrush(off);
                button.Foreground = new SolidColorBrush(Colors.White);
                button.BorderBrush = new SolidColorBrush(Colors.Transparent);
                button.Content = "Start";
            }               
        }
    }
}
