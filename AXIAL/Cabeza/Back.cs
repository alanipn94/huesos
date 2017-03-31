
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
        }/////////////////////////APARTIR DE AQUI ENTRO YO//////////////////////////////
		
		private void HuesoNasalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesoNasal;
            hueso = (int)Hueso.HuesoNasal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void HuesoNasalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesoNasal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Hueso Nasal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroInfraorbitarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroInfraorbitario;
            hueso = (int)Hueso.AgujeroInfraorbitario;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AgujeroInfraorbitarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroInfraorbitario)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Agujero Infraorbitario";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MaxilarInferiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarInferior;
            hueso = (int)Hueso.MaxilarInferior;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void MaxilarInferiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MaxilarInferior)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Maxilar Inferior";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroMentonarioButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroMentonario;
            hueso = (int)Hueso.AgujeroMentonario;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AgujeroMentonarioComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroMentonario)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Agujero Mentonario";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MaxilarSuperiorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MaxilarSuperior;
            hueso = (int)Hueso.MaxilarSuperior;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void MaxilarSuperiorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MaxilarSuperior)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Maxilar Superior";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void VomerButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Vomer;
            hueso = (int)Hueso.Vomer;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void VomerComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Vomer)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Vomer";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void OrbitaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Orbita;
            hueso = (int)Hueso.Orbita;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void OrbitaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Orbita)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Orbita";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void EscotaduraSupraorbitariaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EscotaduraSupraorbitaria;
            hueso = (int)Hueso.EscotaduraSupraorbitaria;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void EscotaduraSupraorbitariaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EscotaduraSupraorbitaria)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Escotadura Supraorbitaria";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////