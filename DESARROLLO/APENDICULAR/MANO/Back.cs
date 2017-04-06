//////////////////MANO//////////////////////////////////////////////////////////EscrituraCamello
		
		private void EscafoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Escafoides;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Escafoides.Background = brush;
        }

        private void EscafoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Escafoides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EscafoidesComprobacion.Background = brush;
                Escafoides.Background = brush;
                Escafoides.Label = "Escafoides";
                Escafoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TrapecioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Trapecio;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Trapecio.Background = brush;
        }

        private void TrapecioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Trapecio)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                TrapecioComprobacion.Background = brush;
                Trapecio.Background = brush;
                Trapecio.Label = "Trapecio";
                Trapecio.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void GrandeButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Grande;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Grande.Background = brush;
        }

        private void GrandeComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Grande)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                GrandeComprobacion.Background = brush;
                Grande.Background = brush;
                Grande.Label = "Grande";
                Grande.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TrapezoideButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Trapezoide;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Trapezoide.Background = brush;
        }

        private void TrapezoideComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Trapezoide)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                TrapezoideComprobacion.Background = brush;
                Trapezoide.Background = brush;
                Trapezoide.Label = "Trapezoide";
                Trapezoide.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SesamoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Sesamoides;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Sesamoides.Background = brush;
        }

        private void SesamoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Sesamoides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SesamoidesComprobacion.Background = brush;
                Sesamoides.Background = brush;
                Sesamoides.Label = "Sesamoides";
                Sesamoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SemilunarButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Semilunar;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Semilunar.Background = brush;
        }

        private void SemilunarComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Semilunar)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SemilunarComprobacion.Background = brush;
                Semilunar.Background = brush;
                Semilunar.Label = "Semilunar";
                Semilunar.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PisiformeButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Pisiforme;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Pisiforme.Background = brush;
        }

        private void PisiformeComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Pisiforme)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                PisiformeComprobacion.Background = brush;
                Pisiforme.Background = brush;
                Pisiforme.Label = "Pisiforme";
                Pisiforme.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PiramidalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Piramidal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Piramidal.Background = brush;
        }

        private void PiramidalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Piramidal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                PiramidalComprobacion.Background = brush;
                Piramidal.Background = brush;
                Piramidal.Label = "Piramidal";
                Piramidal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void GanchosoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Ganchoso;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Ganchoso.Background = brush;
        }

        private void GanchosoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Ganchoso)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                GanchosoComprobacion.Background = brush;
                Ganchoso.Background = brush;
                Ganchoso.Label = "Ganchoso";
                Ganchoso.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MetacarpianosButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Metacarpianos;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Metacarpianos.Background = brush;
        }

        private void MetacarpianosComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Metacarpianos)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MetacarpianosComprobacion.Background = brush;
                Metacarpianos.Background = brush;
                Metacarpianos.Label = "Metacarpianos";
                Metacarpianos.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ProximalManoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ProximalMano;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ProximalMano.Background = brush;
        }

        private void ProximalManoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ProximalMano)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ProximalManoComprobacion.Background = brush;
                ProximalMano.Background = brush;
                ProximalMano.Label = "Proximal";
                ProximalMano.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MediaManoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MediaMano;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MediaMano.Background = brush;
        }

        private void MediaManoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MediaMano)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MediaManoComprobacion.Background = brush;
                MediaMano.Background = brush;
                MediaMano.Label = "Media";
                MediaMano.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void DistalManoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.DistalMano;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            DistalMano.Background = brush;
        }

        private void DistalManoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.DistalMano)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                DistalManoComprobacion.Background = brush;
                DistalMano.Background = brush;
                DistalMano.Label = "Distal";
                DistalMano.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		