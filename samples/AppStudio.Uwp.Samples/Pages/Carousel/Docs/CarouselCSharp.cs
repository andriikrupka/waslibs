﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using AppStudio.Uwp.Samples;

namespace AppStudio.Uwp.Samples
{
    public sealed partial class CarouselSample : Page
    {
        public CarouselSample()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public ObservableCollection<object> Items
        {
            get { return (ObservableCollection<object>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty = DependencyProperty
            .Register("Items", typeof(ObservableCollection<object>), typeof(CarouselSample), new PropertyMetadata(null));

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Initialize items collection
            this.Items = new ObservableCollection<object>(Items);
        }

        private IEnumerable<object> Items
        {
            get
            {
                yield return new DeviceDataItem("Surface Pro 4", "/Images/SurfacePro4.jpg");
                yield return new DeviceDataItem("Surface Book", "/Images/SurfaceBook.jpg");
                yield return new DeviceDataItem("Lumia 950", "/Images/Lumia950.jpg");
                // ...
            }
        }
    }
}
