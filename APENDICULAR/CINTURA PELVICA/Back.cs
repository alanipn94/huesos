//////////////////CINTURA//////////////////////////////////////////////////////////EscrituraCamello

		
		private void CoxalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Coxal;
            hueso = (int)Hueso.Coxal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CoxalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Coxal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Coxal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SacroCinturaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SacroCintura;
            hueso = (int)Hueso.SacroCintura;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void SacroCinturaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SacroCintura)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Sacro";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CoxisCinturaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CoxisCintura;
            hueso = (int)Hueso.CoxisCintura;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CoxisCinturaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CoxisCintura)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Coxis";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void SinfisisPubicaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SinfisisPubica;
            hueso = (int)Hueso.SinfisisPubica;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void SinfisisPubicaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SinfisisPubica)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Sinfisis Pubica";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AcetabuloButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Acetabulo;
            hueso = (int)Hueso.Acetabulo;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AcetabuloComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Acetabulo)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Acetabulo";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void EsquionButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Esquion;
            hueso = (int)Hueso.Esquion;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void EsquionComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Esquion)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Esquion";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PubisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Pubis;
            hueso = (int)Hueso.Pubis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void PubisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Pubis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Pubis";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void AgujeroObturadorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AgujeroObturador;
            hueso = (int)Hueso.AgujeroObturador;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AgujeroObturadorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AgujeroObturador)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Agujero Obturador";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		