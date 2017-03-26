
        private void huesoFrontalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoFrontal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoFrontal.Background = brush;
        }

        private void HuesoFrontalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso== (int)HuesoComprobacion.HuesoFrontal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoFrontalComprobacion.Background = brush;
                HuesoFrontal.Background = brush;
                HuesoFrontal.Label = "HUESO FRONTAL";
                HuesoFrontal.IsEnabled = false;
            }
        }

        private void HuesoParietalsButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoParietal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoParietal.Background = brush;
        }

        private void HuesoParietalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesoParietal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoParietalComprobacion.Background = brush;
                HuesoParietal.Background = brush;
                HuesoParietal.Label = "Hueso Parietal";
                HuesoParietal.IsEnabled = false;
            }
        }

        private void HuesoEsfenoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoEsfenoides;
            hueso = (int)Hueso.HuesoParietal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void HuesoEsfenoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesoEsfenoides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Hueso Esfenoides";
                HuesoEsfenoides.IsEnabled = false;
            }
        }
