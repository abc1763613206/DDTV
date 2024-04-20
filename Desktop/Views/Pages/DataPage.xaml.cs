// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Desktop.Models;
using Wpf.Ui.Controls;

namespace Desktop.Views.Pages;

/// <summary>
/// Interaction logic for DataView.xaml
/// </summary>
public partial class DataPage
{
    public static ObservableCollection<DataCard> CardsCollection { get; private set; } = [];

    public DataPage()
    {
        InitializeData();
        InitializeComponent();

        CardsItemsControl.ItemsSource = CardsCollection;
    }

    private void InitializeData()
    {

    }
}
