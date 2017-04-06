/////////////////BRAZO///////////////////////////////////////////////////////////EscrituraCamello
		
		
		private void ClaviculaBrazoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ClaviculaBrazo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ClaviculaBrazo.Background = brush;
        }

        private void ClaviculaBrazoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ClaviculaBrazo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ClaviculaBrazoComprobacion.Background = brush;
                ClaviculaBrazo.Background = brush;
                ClaviculaBrazo.Label = "Clavicula";
                ClaviculaBrazo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void EscapulaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Escapula;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Escapula.Background = brush;
        }

        private void EscapulaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Escapula)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EscapulaComprobacion.Background = brush;
                Escapula.Background = brush;
                Escapula.Label = "Escapula";
                Escapula.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HumeroButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Humero;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Humero.Background = brush;
        }

        private void HumeroComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Humero)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HumeroComprobacion.Background = brush;
                Humero.Background = brush;
                Humero.Label = "Humero";
                Humero.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Radio;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Radio.Background = brush;
        }

        private void RadioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Radio)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                RadioComprobacion.Background = brush;
                Radio.Background = brush;
                Radio.Label = "Radio";
                Radio.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CubitoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Cubito;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Cubito.Background = brush;
        }

        private void CubitoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Cubito)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CubitoComprobacion.Background = brush;
                Cubito.Background = brush;
                Cubito.Label = "Cubito";
                Cubito.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MuñecaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Muñeca;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Muñeca.Background = brush;
        }

        private void MuñecaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Muñeca)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MuñecaComprobacion.Background = brush;
                Muñeca.Background = brush;
                Muñeca.Label = "Muñeca";
                Muñeca.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HuesosCarpianosButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesosCarpianos;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesosCarpianos.Background = brush;
        }

        private void HuesosCarpianosComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesosCarpianos)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesosCarpianosComprobacion.Background = brush;
                HuesosCarpianos.Background = brush;
                HuesosCarpianos.Label = "Huesos Carpianos";
                HuesosCarpianos.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MetacarpianosBrazoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MetacarpianosBrazo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MetacarpianosBrazo.Background = brush;
        }

        private void MetacarpianosBrazoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MetacarpianosBrazo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MetacarpianosBrazoComprobacion.Background = brush;
                MetacarpianosBrazo.Background = brush;
                MetacarpianosBrazo.Label = "Metacarpianos";
                MetacarpianosBrazo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void FalangesBrazoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.FalangesBrazo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            FalangesBrazo.Background = brush;
        }

        private void FalangesBrazoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.FalangesBrazo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                FalangesBrazoComprobacion.Background = brush;
                FalangesBrazo.Background = brush;
                FalangesBrazo.Label = "Falanges";
                FalangesBrazo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		