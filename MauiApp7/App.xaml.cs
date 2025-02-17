namespace MauiApp7;
public partial class App : Application
{
    public static PersonRepository PersonRepo { get; private set; }

    public App()
    {
        InitializeComponent();
        PersonRepo = repo;

    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell());
    }
}