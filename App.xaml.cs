namespace slunaSIIITC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //NavigationPage para navegacion
            return new Window(new NavigationPage (new Views.vLista1()));
        }
    }
}