//////////////////COLUMNA//////////////////////////////////////////////////////////
		
		
		private void LordosisCervicalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.LordosisCervical;
            hueso = (int)Hueso.LordosisCervical;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void LordosisCervicalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.LordosisCervical)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Lordosis Cervical";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void CarrillasArticularesButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CarrillasArticulares;
            hueso = (int)Hueso.CarrillasArticulares;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CarrillasArticularesComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CarrillasArticulares)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Carrillas Articulares";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CifosisDorsalButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.CifosisDorsal;
            hueso = (int)Hueso.CifosisDorsal;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CifosisDorsalComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.CifosisDorsal)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Cifosis Dorsal";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		
		private void ApofisisEspinosaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.ApofisisEspinosa;
            hueso = (int)Hueso.ApofisisEspinosa;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void ApofisisEspinosaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.ApofisisEspinosa)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Apofisis Espinosa";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void LordosisLumbarButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.LordosisLumbar;
            hueso = (int)Hueso.LordosisLumbar;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void LordosisLumbarComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.LordosisLumbar)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Lordosis Lumbar";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CifosisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Cifosis;
            hueso = (int)Hueso.Cifosis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CifosisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Cifosis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Cifosis";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void SacrococigeaButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Sacrococigea;
            hueso = (int)Hueso.Sacrococigea;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void SacrococigeaComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Sacrococigea)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Sacrococigea";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void SacroButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Sacro;
            hueso = (int)Hueso.Sacro;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void SacroComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Sacro)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Sacro";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AtlasButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Atlas;
            hueso = (int)Hueso.Atlas;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AtlasComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Atlas)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Atlas";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void AxisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Axis;
            hueso = (int)Hueso.Axis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void AxisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Axis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Axis";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		private void CoxisButton_Click(object sender, RoutedEventArgs e)
        {
            hueso = (int)Hueso.Coxis;
            hueso = (int)Hueso.Coxis;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF52318F");
            HuesoEsfenoides.Background = brush;
        }

        private void CoxisComprobacion_Click(object sender, RoutedEventArgs e)
        {
            if (hueso == (int)HuesoComprobacion.Coxis)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#1CB0F6");
                HuesoEsfenoidesComprobacion.Background = brush;
                HuesoEsfenoides.Background = brush;
                HuesoEsfenoides.Label = "Coxis";
                HuesoEsfenoides.IsEnabled = false;
            }
        }///////////////////////////////////////////////////////
		