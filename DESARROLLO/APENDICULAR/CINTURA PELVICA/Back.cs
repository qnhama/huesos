//////////////////CINTURA//////////////////////////////////////////////////////////EscrituraCamello

		
		private void CoxalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Coxal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Coxal.Background = brush;
        }

        private void CoxalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Coxal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CoxalComprobacion.Background = brush;
                Coxal.Background = brush;
                Coxal.Label = "Coxal";
                Coxal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SacroCinturaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SacroCintura;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            SacroCintura.Background = brush;
        }

        private void SacroCinturaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SacroCintura)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SacroCinturaComprobacion.Background = brush;
                SacroCintura.Background = brush;
                SacroCintura.Label = "Sacro";
                SacroCintura.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CoxisCinturaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CoxisCintura;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            CoxisCintura.Background = brush;
        }

        private void CoxisCinturaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CoxisCintura)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CoxisCinturaComprobacion.Background = brush;
                CoxisCintura.Background = brush;
                CoxisCintura.Label = "Coxis";
                CoxisCintura.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SinfisisPubicaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SinfisisPubica;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            SinfisisPubica.Background = brush;
        }

        private void SinfisisPubicaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SinfisisPubica)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SinfisisPubicaComprobacion.Background = brush;
                SinfisisPubica.Background = brush;
                SinfisisPubica.Label = "Sinfisis Pubica";
                SinfisisPubica.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AcetabuloButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Acetabulo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Acetabulo.Background = brush;
        }

        private void AcetabuloComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Acetabulo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AcetabuloComprobacion.Background = brush;
                Acetabulo.Background = brush;
                Acetabulo.Label = "Acetabulo";
                Acetabulo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void EsquionButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Esquion;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Esquion.Background = brush;
        }

        private void EsquionComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Esquion)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EsquionComprobacion.Background = brush;
                Esquion.Background = brush;
                Esquion.Label = "Esquion";
                Esquion.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PubisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Pubis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Pubis.Background = brush;
        }

        private void PubisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Pubis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                PubisComprobacion.Background = brush;
                Pubis.Background = brush;
                Pubis.Label = "Pubis";
                Pubis.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroObturadorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroObturador;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            AgujeroObturador.Background = brush;
        }

        private void AgujeroObturadorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroObturador)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AgujeroObturadorComprobacion.Background = brush;
                AgujeroObturador.Background = brush;
                AgujeroObturador.Label = "Agujero Obturador";
                AgujeroObturador.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		