//////////////////PIERNA//////////////////////////////////////////////////////////EscrituraCamello
		
		
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
		
		private void SacroPiernaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.SacroPierna;
            hueso = (int)Hueso.SacroPierna;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void SacroPiernaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.SacroPierna)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Sacro";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CabezaFemoralButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CabezaFemoral;
            hueso = (int)Hueso.CabezaFemoral;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CabezaFemoralComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CabezaFemoral)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Cabeza Femoral";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TrocanterMayorButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.TrocanterMayor;
            hueso = (int)Hueso.TrocanterMayor;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void TrocanterMayorComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.TrocanterMayor)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Trocanter Mayor";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void FemurButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Femur;
            hueso = (int)Hueso.Femur;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void FemurComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Femur)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Femur";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void RotulaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Rotula;
            hueso = (int)Hueso.Rotula;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void RotulaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Rotula)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Rotula";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void TibiaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Tibia;
            hueso = (int)Hueso.Tibia;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void TibiaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Tibia)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Tibia";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void PeroneButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Perone;
            hueso = (int)Hueso.Perone;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void PeroneComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Perone)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Perone";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void HuesosDelTarsoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.HuesosDelTarso;
            hueso = (int)Hueso.HuesosDelTarso;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void HuesosDelTarsoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.HuesosDelTarso)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Huesos Del Tarso";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void MetatarsianosPiernaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.MetatarsianosPierna;
            hueso = (int)Hueso.MetatarsianosPierna;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void MetatarsianosPiernaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.MetatarsianosPierna)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Metatarsianos";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void FalangesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Falanges;
            hueso = (int)Hueso.Falanges;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void FalangesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Falanges)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Falanges";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		