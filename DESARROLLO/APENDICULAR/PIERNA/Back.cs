//////////////////PIERNA//////////////////////////////////////////////////////////EscrituraCamello
		
		
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
		
		private void SacroPiernaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SacroPierna;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            SacroPierna.Background = brush;
        }

        private void SacroPiernaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SacroPierna)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SacroPiernaComprobacion.Background = brush;
                SacroPierna.Background = brush;
                SacroPierna.Label = "Sacro";
                SacroPierna.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CabezaFemoralButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CabezaFemoral;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            CabezaFemoral.Background = brush;
        }

        private void CabezaFemoralComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CabezaFemoral)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CabezaFemoralComprobacion.Background = brush;
                CabezaFemoral.Background = brush;
                CabezaFemoral.Label = "Cabeza Femoral";
                CabezaFemoral.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TrocanterMayorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.TrocanterMayor;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            TrocanterMayor.Background = brush;
        }

        private void TrocanterMayorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.TrocanterMayor)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                TrocanterMayorComprobacion.Background = brush;
                TrocanterMayor.Background = brush;
                TrocanterMayor.Label = "Trocanter Mayor";
                TrocanterMayor.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void FemurButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Femur;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Femur.Background = brush;
        }

        private void FemurComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Femur)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                FemurComprobacion.Background = brush;
                Femur.Background = brush;
                Femur.Label = "Femur";
                Femur.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void RotulaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Rotula;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Rotula.Background = brush;
        }

        private void RotulaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Rotula)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                RotulaComprobacion.Background = brush;
                Rotula.Background = brush;
                Rotula.Label = "Rotula";
                Rotula.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TibiaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Tibia;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Tibia.Background = brush;
        }

        private void TibiaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Tibia)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                TibiaComprobacion.Background = brush;
                Tibia.Background = brush;
                Tibia.Label = "Tibia";
                Tibia.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PeroneButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Perone;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Perone.Background = brush;
        }

        private void PeroneComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Perone)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                PeroneComprobacion.Background = brush;
                Perone.Background = brush;
                Perone.Label = "Perone";
                Perone.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HuesosDelTarsoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesosDelTarso;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesosDelTarso.Background = brush;
        }

        private void HuesosDelTarsoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesosDelTarso)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesosDelTarsoComprobacion.Background = brush;
                HuesosDelTarso.Background = brush;
                HuesosDelTarso.Label = "Huesos Del Tarso";
                HuesosDelTarso.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MetatarsianosPiernaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MetatarsianosPierna;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MetatarsianosPierna.Background = brush;
        }

        private void MetatarsianosPiernaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MetatarsianosPierna)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MetatarsianosPiernaComprobacion.Background = brush;
                MetatarsianosPierna.Background = brush;
                MetatarsianosPierna.Label = "Metatarsianos";
                MetatarsianosPierna.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void FalangesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Falanges;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Falanges.Background = brush;
        }

        private void FalangesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Falanges)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                FalangesComprobacion.Background = brush;
                Falanges.Background = brush;
                Falanges.Label = "Falanges";
                Falanges.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		