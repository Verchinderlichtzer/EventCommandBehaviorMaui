using CommunityToolkit.Mvvm.Input;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommandBehaviorMaui.ViewModels;
public partial class PersonViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Person> _persons = new();

    [RelayCommand]
    private void AddPerson()
    {
        Persons.Add(new() { Id = 1, Name = "Test", Age = 23 });
    }

    [RelayCommand]
    private void Test()
    {
        // Nothing
    }
}
