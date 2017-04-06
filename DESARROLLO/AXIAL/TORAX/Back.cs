//////////////////TORAX//////////////////////////////////////////////////////////
		
		
		private void ClaviculaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Clavicula;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Clavicula.Background = brush;
        }

        private void ClaviculaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Clavicula)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ClaviculaComprobacion.Background = brush;
                Clavicula.Background = brush;
                Clavicula.Label = "Clavicula";
                Clavicula.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EsternonButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Esternon;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Esternon.Background = brush;
        }

        private void EsternonComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Esternon)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EsternonComprobacion.Background = brush;
                Esternon.Background = brush;
                Esternon.Label = "Esternon";
                Esternon.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void ApofisisXifoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ApofisisXifoides;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ApofisisXifoides.Background = brush;
        }

        private void ApofisisXifoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ApofisisXifoides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ApofisisXifoidesComprobacion.Background = brush;
                ApofisisXifoides.Background = brush;
                ApofisisXifoides.Label = "Apofisis Xifoides";
                ApofisisXifoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EscotaduraClavicularButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EscotaduraClavicular;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            EscotaduraClavicular.Background = brush;
        }

        private void EscotaduraClavicularComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EscotaduraClavicular)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EscotaduraClavicularComprobacion.Background = brush;
                EscotaduraClavicular.Background = brush;
                EscotaduraClavicular.Label = "EscotaduraClavicular";
                EscotaduraClavicular.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void OmoplatoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Omoplato;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Omoplato.Background = brush;
        }

        private void OmoplatoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Omoplato)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                OmoplatoComprobacion.Background = brush;
                Omoplato.Background = brush;
                Omoplato.Label = "Omoplato";
                Omoplato.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AnguloEsternalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AnguloEsternal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            AnguloEsternal.Background = brush;
        }

        private void AnguloEsternalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AnguloEsternal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AnguloEsternalComprobacion.Background = brush;
                AnguloEsternal.Background = brush;
                AnguloEsternal.Label = "Angulo Esternal";
                AnguloEsternal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CartilagoCostalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CartilagoCostal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            CartilagoCostal.Background = brush;
        }

        private void CartilagoCostalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CartilagoCostal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CartilagoCostalComprobacion.Background = brush;
                CartilagoCostal.Background = brush;
                CartilagoCostal.Label = "Cartilago Costal";
                CartilagoCostal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EspacioIntercostalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EspacioIntercostal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            EspacioIntercostal.Background = brush;
        }

        private void EspacioIntercostalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EspacioIntercostal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EspacioIntercostalComprobacion.Background = brush;
                EspacioIntercostal.Background = brush;
                EspacioIntercostal.Label = "EspacioIntercostal";
                EspacioIntercostal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////