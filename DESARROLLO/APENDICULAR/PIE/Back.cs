//////////////////PIE//////////////////////////////////////////////////////////EscrituraCamello
		
		private void MaleoloLateralButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaleoloLateral;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            MaleoloLateral.Background = brush;
        }

        private void MaleoloLateralComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MaleoloLateral)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MaleoloLateralComprobacion.Background = brush;
                MaleoloLateral.Background = brush;
                MaleoloLateral.Label = "Maleolo Lateral";
                MaleoloLateral.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CuboidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Cuboides;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Cuboides.Background = brush;
        }

        private void CuboidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Cuboides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CuboidesComprobacion.Background = brush;
                Cuboides.Background = brush;
                Cuboides.Label = "Cuboides";
                Cuboides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CalcaneoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Calcaneo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Calcaneo.Background = brush;
        }

        private void CalcaneoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Calcaneo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                CalcaneoComprobacion.Background = brush;
                Calcaneo.Background = brush;
                Calcaneo.Label = "Calcaneo";
                Calcaneo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ArcoTransversoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ArcoTransverso;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ArcoTransverso.Background = brush;
        }

        private void ArcoTransversoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ArcoTransverso)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ArcoTransversoComprobacion.Background = brush;
                ArcoTransverso.Background = brush;
                ArcoTransverso.Label = "Arco Transverso";
                ArcoTransverso.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ArcoLongitudinalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ArcoLongitudinal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            ArcoLongitudinal.Background = brush;
        }

        private void ArcoLongitudinalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ArcoLongitudinal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ArcoLongitudinalComprobacion.Background = brush;
                ArcoLongitudinal.Background = brush;
                ArcoLongitudinal.Label = "Arco Longitudinal";
                ArcoLongitudinal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AstragaloButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Astragalo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Astragalo.Background = brush;
        }

        private void AstragaloComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Astragalo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AstragaloComprobacion.Background = brush;
                Astragalo.Background = brush;
                Astragalo.Label = "Astragalo";
                Astragalo.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HuesoNavicularButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoNavicular;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoNavicular.Background = brush;
        }

        private void HuesoNavicularComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesoNavicular)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoNavicularComprobacion.Background = brush;
                HuesoNavicular.Background = brush;
                HuesoNavicular.Label = "Hueso Navicular";
                HuesoNavicular.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HuesosCuneiformesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesosCuneiformes;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesosCuneiformes.Background = brush;
        }

        private void HuesosCuneiformesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesosCuneiformes)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesosCuneiformesComprobacion.Background = brush;
                HuesosCuneiformes.Background = brush;
                HuesosCuneiformes.Label = "Huesos Cuneiformes";
                HuesosCuneiformes.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MetatarsianosButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Metatarsianos;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Metatarsianos.Background = brush;
        }

        private void MetatarsianosComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Metatarsianos)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MetatarsianosComprobacion.Background = brush;
                Metatarsianos.Background = brush;
                Metatarsianos.Label = "Metatarsianos";
                Metatarsianos.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ProximalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Proximal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Proximal.Background = brush;
        }

        private void ProximalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Proximal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                ProximalComprobacion.Background = brush;
                Proximal.Background = brush;
                Proximal.Label = "Proximal";
                Proximal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MediaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Media;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Media.Background = brush;
        }

        private void MediaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Media)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MediaComprobacion.Background = brush;
                Media.Background = brush;
                Media.Label = "Media";
                Media.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void DistalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Distal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            Distal.Background = brush;
        }

        private void DistalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Distal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                DistalComprobacion.Background = brush;
                Distal.Background = brush;
                Distal.Label = "Distal";
                Distal.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		