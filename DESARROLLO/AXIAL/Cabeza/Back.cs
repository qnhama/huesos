
        private void HuesoFrontalButton_Click(object sender, RoutedEventArgs e)
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
///////////////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////////////
        private void HuesoEsfenoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoEsfenoides;
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
        }/////////////////////////APARTIR DE AQUI ENTRO YO//////////////////////////////
		
		private void HuesoNasalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoNasal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoNasal.Background = brush;
        }

        private void HuesoNasalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesoNasal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoNasalComprobacion.Background = brush;
                HuesoNasal.Background = brush;
                HuesoNasal.Label = "Hueso Nasal";
                HuesoNasal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroInfraorbitarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroInfraorbitario;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            AgujeroInfraorbitario.Background = brush;
        }

        private void AgujeroInfraorbitarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroInfraorbitario)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AgujeroInfraorbitarioComprobacion.Background = brush;
                AgujeroInfraorbitario.Background = brush;
                AgujeroInfraorbitario.Label = "Agujero Infraorbitario";
                AgujeroInfraorbitario.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MaxilarInferiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarInferior;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MaxilarInferior.Background = brush;
        }

        private void MaxilarInferiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MaxilarInferior)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MaxilarInferiorComprobacion.Background = brush;
                MaxilarInferior.Background = brush;
                MaxilarInferior.Label = "Maxilar Inferior";
                MaxilarInferior.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroMentonarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroMentonario;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            AgujeroMentonario.Background = brush;
        }

        private void AgujeroMentonarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroMentonario)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AgujeroMentonarioComprobacion.Background = brush;
                AgujeroMentonario.Background = brush;
                AgujeroMentonario.Label = "Agujero Mentonario";
                AgujeroMentonario.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MaxilarSuperiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarSuperior;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MaxilarSuperior.Background = brush;
        }

        private void MaxilarSuperiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MaxilarSuperior)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MaxilarSuperiorComprobacion.Background = brush;
                MaxilarSuperior.Background = brush;
                MaxilarSuperior.Label = "Maxilar Superior";
                MaxilarSuperior.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void VomerButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Vomer;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Vomer.Background = brush;
        }

        private void VomerComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Vomer)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                VomerComprobacion.Background = brush;
                Vomer.Background = brush;
                Vomer.Label = "Vomer";
                Vomer.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void OrbitaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Orbita;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Orbita.Background = brush;
        }

        private void OrbitaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Orbita)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                OrbitaComprobacion.Background = brush;
                Orbita.Background = brush;
                Orbita.Label = "Orbita";
                Orbita.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void EscotaduraSupraorbitariaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EscotaduraSupraorbitaria;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            EscotaduraSupraorbitaria.Background = brush;
        }

        private void EscotaduraSupraorbitariaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EscotaduraSupraorbitaria)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EscotaduraSupraorbitariaComprobacion.Background = brush;
                EscotaduraSupraorbitaria.Background = brush;
                EscotaduraSupraorbitaria.Label = "Escotadura Supraorbitaria";
                EscotaduraSupraorbitaria.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////