//using System.Windows;
//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using MessageBox = System.Windows.MessageBox;

//namespace WpfApp1;

//[ObservableObject]
//public partial class MainWindow : Window
//{
//    [ObservableProperty]
//    //[NotifyCanExecuteChangedFor(nameof(SaveAutomationCommand))]
//    //[NotifyCanExecuteChangedFor(nameof(DeleteAutomationCommand))]
//    //[NotifyCanExecuteChangedFor(nameof(UpdateAutomationCommand))]
//    private bool _automationIsSaved;

//    [ObservableProperty]
//    [NotifyCanExecuteChangedFor(nameof(UpdateAutomationCommand))]
//    private bool _automationHasUnsavedChanges;

//    private MyOption _option;

//    public MainWindow()
//    {
//        InitializeComponent();
//        DataContext = this;
//        AutomationIsSaved = false;
//        AutomationHasUnsavedChanges = true;
//    }

//    public enum MyOption
//    {
//        Option1,
//        Option2,
//        Option3,
//    }

//    public MyOption Option
//    {
//        get => _option;
//        set
//        {
//            _option = value;
//            OnPropertyChanged();
//            //AutomationHasUnsavedChanges = true;
//        }
//    }

//    private string _myPath;

//    public string MyPath
//    {
//        get => _myPath;
//        set
//        {
//            _myPath = value;
//            OnPropertyChanged();
//            AutomationHasUnsavedChanges = true;
//        }
//    }

//    [RelayCommand]
//    private void ChangeData()
//    {
//        AutomationHasUnsavedChanges = true;
//    }

//    [RelayCommand(CanExecute = nameof(CanSaveAutomation))]
//    private void SaveAutomation()
//    {
//        AutomationIsSaved = true;
//        AutomationHasUnsavedChanges = false;
//    }

//    [RelayCommand(CanExecute = nameof(CanDeleteAutomation))]
//    private void DeleteAutomation()
//    {
//        AutomationIsSaved = false;
//        AutomationHasUnsavedChanges = true;
//    }

//    [RelayCommand(CanExecute = nameof(CanUpdateAutomation))]
//    private void UpdateAutomation()
//    {
//        AutomationHasUnsavedChanges = false;
//    }

//    private bool CanSaveAutomation() => !AutomationIsSaved;

//    //private bool CanUpdateAutomation() => AutomationIsSaved && AutomationHasUnsavedChanges;
//    private bool CanUpdateAutomation() => AutomationHasUnsavedChanges;

//    private bool CanDeleteAutomation() => AutomationIsSaved;

//    private void Toggle_OnClick(object sender, RoutedEventArgs e) { }

//    /*private ObservableCollection<string> _textBoxData = ["Item 1", "Item 2"];

//    public MainWindow()
//    {
//        InitializeComponent();
//        DataContext = this;
//    }

//    public event PropertyChangedEventHandler? PropertyChanged;

//    public ObservableCollection<string> TextBoxData
//    {
//        get => _textBoxData;
//        set
//        {
//            _textBoxData = value;
//            OnPropertyChanged();
//        }
//    }

//    private void OnPropertyChanged([CallerMemberName] string? name = null)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }

//    private void Btn_ChangeCollection_OnClick(object sender, RoutedEventArgs e)
//    {
//        TextBoxData.Add("Item 3");
//    }*/
//}

// <copyright file="MatchAssortment.xaml.cs" company="Acosta, Inc">
// Copyright (c) Acosta, Inc. All rights reserved.
// </copyright>

using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp1;

[ObservableObject]
public partial class MainWindow : Window
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(UpdateAutomationCommand))]
    private bool _automationHasUnsavedChanges;

    public MainWindow()
    {
        DataContext = this;
        InitializeComponent();
        AutomationHasUnsavedChanges = true;
    }

    private bool CanUpdateAutomation() => AutomationHasUnsavedChanges;

    [RelayCommand(CanExecute = nameof(CanUpdateAutomation))]
    private void UpdateAutomation(bool silentUpdate = false)
    {
        // insert updates here
        AutomationHasUnsavedChanges = false;
    }
}
