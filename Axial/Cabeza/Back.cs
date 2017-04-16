
        private void HuesoFrontalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Cabeza.Hueso.HuesoFrontal;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void HuesoFrontalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)Cabeza.HuesoComprobacion.HuesoFrontal)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoFrontalComprobacion.Background = brush;
                HuesoFrontal.Background = brush;
                HuesoFrontal.Label = "HUESO FRONTAL";
                HuesoFrontal.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();
            }
        }

        private void HuesoParietalsButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoParietal;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void HuesoParietalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)Cabeza.HuesoComprobacion.HuesoParietal)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoParietalComprobacion.Background = brush;
                HuesoParietal.Background = brush;
                HuesoParietal.Label = "Hueso Parietal";
                HuesoParietal.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();

            }
        }

        private void HuesoEsfenoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoEsfenoides;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void HuesoEsfenoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.HuesoEsfenoides)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Hueso Esfenoides";
                HuesoEsfenoides.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();


            }
        }/////////////////////////APARTIR DE AQUI ENTRO YO//////////////////////////////

        private void HuesoNasalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoNasal;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void HuesoNasalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.HuesoNasal)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoNasalComprobacion.Background = brush;
                HuesoNasal.Background = brush;
                HuesoNasal.Label = "Hueso Nasal";
                HuesoNasal.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();


            }
        }///////////////////////////////////////////////////////

        private void AgujeroInfraorbitarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroInfraorbitario;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void AgujeroInfraorbitarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.AgujeroInfraorbitario)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AgujeroInfraorbitarioComprobacion.Background = brush;
                AgujeroInfraorbitario.Background = brush;
                AgujeroInfraorbitario.Label = "Agujero Infraorbitario";
                AgujeroInfraorbitario.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();


            }
        }///////////////////////////////////////////////////////

        private void MaxilarInferiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarInferior;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void MaxilarInferiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.MaxilarInferior)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MaxilarInferiorComprobacion.Background = brush;
                MaxilarInferior.Background = brush;
                MaxilarInferior.Label = "Maxilar Inferior";
                MaxilarInferior.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();
            }
        }///////////////////////////////////////////////////////

        private void AgujeroMentonarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroMentonario;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void AgujeroMentonarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.AgujeroMentonario)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                AgujeroMentonarioComprobacion.Background = brush;
                AgujeroMentonario.Background = brush;
                AgujeroMentonario.Label = "Agujero Mentonario";
                AgujeroMentonario.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();


            }
        }///////////////////////////////////////////////////////

        private void MaxilarSuperiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarSuperior;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void MaxilarSuperiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.MaxilarSuperior)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                MaxilarSuperiorComprobacion.Background = brush;
                MaxilarSuperior.Background = brush;
                MaxilarSuperior.Label = "Maxilar Superior";
                MaxilarSuperior.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();


            }
        }///////////////////////////////////////////////////////

        private void VomerButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Vomer;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void VomerComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.Vomer)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;

            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                VomerComprobacion.Background = brush;
                Vomer.Background = brush;
                Vomer.Label = "Vomer";
                Vomer.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();

            }
        }///////////////////////////////////////////////////////

        private void OrbitaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Orbita;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void OrbitaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.Orbita)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                OrbitaComprobacion.Background = brush;
                Orbita.Background = brush;
                Orbita.Label = "Orbita";
                Orbita.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();

            }
        }///////////////////////////////////////////////////////

        private void EscotaduraSupraorbitariaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EscotaduraSupraorbitaria;
            cabeza.huesoClick(this);
            datosCabeza.IsEnabled = true;
        }

        private void EscotaduraSupraorbitariaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso != (int)HuesoComprobacion.EscotaduraSupraorbitaria)
            {
                cabeza.huesoUnselectAll(this);
                oportunidades += 1;
                verificarOportunidades();
                datosCabeza.IsEnabled = false;
            }
            else {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                EscotaduraSupraorbitariaComprobacion.Background = brush;
                EscotaduraSupraorbitaria.Background = brush;
                EscotaduraSupraorbitaria.Label = "Escotadura Supraorbitaria";
                EscotaduraSupraorbitaria.IsEnabled = false;
                oportunidades = 0;
                datosCabeza.IsEnabled = false;
                estructuraCompletada += 1;
                huesoCompletado.Label = estructuraCompletada;
                IsEstructuraCompletada();

            }
        }
