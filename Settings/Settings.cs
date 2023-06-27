using System.ComponentModel;

namespace TestSharedProperties.Settings;

public class TestVM : INotifyPropertyChanged
{
    private bool testSwitch;

    public bool TestSwitch
    {
        get => testSwitch;
        set
        {
            if (testSwitch != value)
            {
                testSwitch = value;
                OnPropertyChanged(nameof(TestSwitch));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
public class TestVM2 : INotifyPropertyChanged
{
    //{Binding Source={x:Static local:TestVM.Instance}, Path=TestSwitch}
    private bool testSwitch;
    
    public TestVM2() {}

    public bool TestSwitch
    {
        get => testSwitch;
        set
        {
            if (testSwitch != value)
            {
                testSwitch = value;
                OnPropertyChanged(nameof(TestSwitch));
            }
        }
    }

    private static readonly TestVM2? _instance;

    public static TestVM2 Instance => _instance ?? new TestVM2();

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
