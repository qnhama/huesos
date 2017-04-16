using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Kinect_Jigsaw1.Model.Entities
{
    
    public partial class Cabeza 
    {
        public int complete = 11;
        public void huesoUnselectAll(MainWindow mnw)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF939597");
            mnw.HuesoFrontal.Background = brush;
            mnw.HuesoNasal.Background = brush;
            mnw.AgujeroInfraorbitario.Background = brush;
            mnw.MaxilarInferior.Background = brush;
            mnw.AgujeroMentonario.Background = brush;
            mnw.MaxilarSuperior.Background = brush;
            mnw.Vomer.Background = brush;
            mnw.Orbita.Background = brush;
            mnw.HuesoEsfenoides.Background = brush;
            mnw.HuesoParietal.Background = brush;
            mnw.EscotaduraSupraorbitaria.Background = brush;
        }

        public void isEnable(MainWindow mnw)
        {
            mnw.HuesoFrontal.IsEnabled = true;
            mnw.HuesoNasal.IsEnabled = true;
            mnw.AgujeroInfraorbitario.IsEnabled = true;
            mnw.MaxilarInferior.IsEnabled = true;
            mnw.AgujeroMentonario.IsEnabled = true;
            mnw.MaxilarSuperior.IsEnabled = true;
            mnw.Vomer.IsEnabled = true;
            mnw.Orbita.IsEnabled = true;
            mnw.HuesoEsfenoides.IsEnabled = true;
            mnw.HuesoParietal.IsEnabled = true;
            mnw.EscotaduraSupraorbitaria.IsEnabled = true;
        }

        public void toDisable(MainWindow mnw)
        {
            mnw.HuesoFrontal.IsEnabled = false;
            mnw.HuesoNasal.IsEnabled = false;
            mnw.AgujeroInfraorbitario.IsEnabled = false;
            mnw.MaxilarInferior.IsEnabled = false;
            mnw.AgujeroMentonario.IsEnabled = false;
            mnw.MaxilarSuperior.IsEnabled = false;
            mnw.Vomer.IsEnabled = false;
            mnw.Orbita.IsEnabled = false;
            mnw.HuesoEsfenoides.IsEnabled = false;
            mnw.HuesoParietal.IsEnabled = false;
            mnw.EscotaduraSupraorbitaria.IsEnabled = false;
        }

        public void huesoClick(MainWindow mnw)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var select = (Brush)converter.ConvertFromString("#FF52318F");
            huesoUnselectAll(mnw);
            switch (mnw.hueso)
            {
                //Cabeza
                case 1:
                    mnw.HuesoFrontal.Background = select;
                    break;
                case 2:
                    mnw.HuesoParietal.Background = select;
                    break;
                case 3:
                    mnw.HuesoEsfenoides.Background = select;
                    break;
                case 4:
                    mnw.HuesoNasal.Background = select;
                    break;
                case 5:
                    mnw.AgujeroInfraorbitario.Background = select;
                    break;
                case 6:
                    mnw.MaxilarInferior.Background = select;
                    break;
                case 7:
                    mnw.AgujeroMentonario.Background = select;
                    break;
                case 8:
                    mnw.MaxilarSuperior.Background = select;
                    break;
                case 9:
                    mnw.Vomer.Background = select;
                    break;
                case 10:
                    mnw.Orbita.Background = select;
                    break;
                case 11:
                    mnw.EscotaduraSupraorbitaria.Background = select;
                    break;
                default:
                    break;
            }
        }

        public enum Hueso
        {
            ninguno,
            HuesoFrontal,
            HuesoParietal,
            HuesoEsfenoides,
            HuesoNasal,
            AgujeroInfraorbitario,
            MaxilarInferior,
            AgujeroMentonario,
            MaxilarSuperior,
            Vomer,
            Orbita,
            EscotaduraSupraorbitaria
        }

        public enum HuesoComprobacion
        {
            ninguno,
            HuesoFrontal,
            HuesoParietal,
            HuesoEsfenoides,
            HuesoNasal,
            AgujeroInfraorbitario,
            MaxilarInferior,
            AgujeroMentonario,
            MaxilarSuperior,
            Vomer,
            Orbita,
            EscotaduraSupraorbitaria
        }
    }
}
