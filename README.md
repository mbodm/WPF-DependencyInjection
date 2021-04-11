# WPF-DependencyInjection
Some .NET 5 WPF DI samples

### The samples

* Sample1: Using Host and DI (*Microsoft.Extensions.Hosting* and *Microsoft.Extensions.DependencyInjection*)
* Sample2: Using solely IServiceCollection/IServiceProvider (*Microsoft.Extensions.DependencyInjection*)
* Sample3: Using new WindowsCommunityToolkit MVVM package (*Microsoft.Toolkit.Mvvm*)

### Quick overview:

* Folder "BusinessLogic" contains a simple pseudo BL, so we can make use of DI.
* Folder "Services" contains 2 simple pseudo services, so we can make use of DI.
* Folder "ViewModels" contains the ViewModel for our one and only View.
* Folder "Views" contains our one and only View.
* Folder "Helpers" in Sample1 and Sample2 contains our own MVVM Helpers for RelayCommand/ICommand and ObjeservableModel/INotifyPropertyChanged.
* Background: We just use solely one View, cause we do not wanna use a DialogService/Messenger, just to keep the samples simple.

All interessting stuff happens in file "App.xaml.cs". Above stuff is just there, so we can use our DI somewhere.

Have fun.
