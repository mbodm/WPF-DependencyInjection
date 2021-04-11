# WPF-DependencyInjection
Some .NET 5 WPF DI samples

### The samples

* Sample1: Using Host and DI (*Microsoft.Extensions.Hosting* and *Microsoft.Extensions.DependencyInjection*)
* Sample2: Using solely IServiceCollection/IServiceProvider (*Microsoft.Extensions.DependencyInjection*)
* Sample3: Using new WindowsCommunityToolkit MVVM package (*Microsoft.Toolkit.Mvvm*)

### Quick overview

* Folder "*BusinessLogic*" contains a simple pseudo BL, so we can make use of DI.
* Folder "*Services*" contains 2 simple pseudo services, so we can make use of DI.
* Folder "*ViewModels*" contains the ViewModel for our one and only view.
* Folder "*Views*" contains our one and only view.
* Folder "*Helpers*" in Sample1 and Sample2 contains our own MVVM helpers for
  * RelayCommand/ICommand
  * ObservableModel/INotifyPropertyChanged
* Info: We just use a single view, cause we don´t wanna use a DialogService/Messenger, just to keep these samples simple.

### So, whats going on ?

All interessting stuff happens in file "*App.xaml.cs*". All the stuff explained above is just there for the simple reason that we need anything to make use of our DI. I am not sure, what the best practice is. Either using Microsofts Host, as they demonstrate in a Console Application sample on MSDN, or by just using the DI without their Host stuff. Nonetheless, all the different variants are set up in "*App.xaml.cs*" whereas all the other files are just there for demonstration purposes.

Have fun.
