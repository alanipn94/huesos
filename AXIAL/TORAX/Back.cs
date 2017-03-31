//////////////////TORAX//////////////////////////////////////////////////////////
		
		
		private void ClaviculaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Clavicula;
            hueso = (int)Hueso.Clavicula;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void ClaviculaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Clavicula)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Clavicula";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EsternonButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Esternon;
            hueso = (int)Hueso.Esternon;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void EsternonComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Esternon)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Esternon";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void ApofisisXifoidesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ApofisisXifoides;
            hueso = (int)Hueso.ApofisisXifoides;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void ApofisisXifoidesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ApofisisXifoides)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Apofisis Xifoides";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EscotaduraClavicularButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EscotaduraClavicular;
            hueso = (int)Hueso.EscotaduraClavicular;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void EscotaduraClavicularComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EscotaduraClavicular)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "EscotaduraClavicular";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void OmoplatoButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Omoplato;
            hueso = (int)Hueso.Omoplato;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void OmoplatoComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Omoplato)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Omoplato";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AnguloEsternalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.AnguloEsternal;
            hueso = (int)Hueso.AnguloEsternal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AnguloEsternalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.AnguloEsternal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Angulo Esternal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CartilagoCostalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CartilagoCostal;
            hueso = (int)Hueso.CartilagoCostal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CartilagoCostalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CartilagoCostal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Cartilago Costal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void EspacioIntercostalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.EspacioIntercostal;
            hueso = (int)Hueso.EspacioIntercostal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void EspacioIntercostalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.EspacioIntercostal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "EspacioIntercostal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////