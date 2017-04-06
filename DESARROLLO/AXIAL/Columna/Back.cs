//////////////////COLUMNA//////////////////////////////////////////////////////////
		
		
		private void LordosisCervicalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.LordosisCervical;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            LordosisCervical.Background = brush;
        }

        private void LordosisCervicalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.LordosisCervical)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                LordosisCervicalComprobacion.Background = brush;
                LordosisCervical.Background = brush;
                LordosisCervical.Label = "Lordosis Cervical";
                LordosisCervical.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CarrillasArticularesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CarrillasArticulares;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            CarrillasArticulares.Background = brush;
        }

        private void CarrillasArticularesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CarrillasArticulares)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CarrillasArticularesComprobacion.Background = brush;
                CarrillasArticulares.Background = brush;
                CarrillasArticulares.Label = "Carrillas Articulares";
                CarrillasArticulares.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CifosisDorsalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CifosisDorsal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            CifosisDorsal.Background = brush;
        }

        private void CifosisDorsalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CifosisDorsal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CifosisDorsalComprobacion.Background = brush;
                CifosisDorsal.Background = brush;
                CifosisDorsal.Label = "Cifosis Dorsal";
                CifosisDorsal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ApofisisEspinosaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ApofisisEspinosa;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ApofisisEspinosa.Background = brush;
        }

        private void ApofisisEspinosaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ApofisisEspinosa)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ApofisisEspinosaComprobacion.Background = brush;
                ApofisisEspinosa.Background = brush;
                ApofisisEspinosa.Label = "Apofisis Espinosa";
                ApofisisEspinosa.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void LordosisLumbarButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.LordosisLumbar;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            LordosisLumbar.Background = brush;
        }

        private void LordosisLumbarComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.LordosisLumbar)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                LordosisLumbarComprobacion.Background = brush;
                LordosisLumbar.Background = brush;
                LordosisLumbar.Label = "Lordosis Lumbar";
                LordosisLumbar.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CifosisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Cifosis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Cifosis.Background = brush;
        }

        private void CifosisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Cifosis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CifosisComprobacion.Background = brush;
                Cifosis.Background = brush;
                Cifosis.Label = "Cifosis";
                Cifosis.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void SacrococigeaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Sacrococigea;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Sacrococigea.Background = brush;
        }

        private void SacrococigeaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Sacrococigea)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SacrococigeaComprobacion.Background = brush;
                Sacrococigea.Background = brush;
                Sacrococigea.Label = "Sacrococigea";
                Sacrococigea.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void SacroButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Sacro;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Sacro.Background = brush;
        }

        private void SacroComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Sacro)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                SacroComprobacion.Background = brush;
                Sacro.Background = brush;
                Sacro.Label = "Sacro";
                Sacro.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AtlasButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Atlas;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Atlas.Background = brush;
        }

        private void AtlasComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Atlas)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AtlasComprobacion.Background = brush;
                Atlas.Background = brush;
                Atlas.Label = "Atlas";
                Atlas.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AxisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Axis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Axis.Background = brush;
        }

        private void AxisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Axis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AxisComprobacion.Background = brush;
                Axis.Background = brush;
                Axis.Label = "Axis";
                Axis.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CoxisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Coxis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Coxis.Background = brush;
        }

        private void CoxisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Coxis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CoxisComprobacion.Background = brush;
                Coxis.Background = brush;
                Coxis.Label = "Coxis";
                Coxis.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		