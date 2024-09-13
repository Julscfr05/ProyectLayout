namespace ProyectLayout // Ajusta el espacio de nombres si es diferente
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AbsoluteLayoutPage), typeof(AbsoluteLayoutPage));
            Routing.RegisterRoute(nameof(BindableLayoutPage), typeof(BindableLayoutPage));
            Routing.RegisterRoute(nameof(FlexLayoutPage), typeof(FlexLayoutPage));
            Routing.RegisterRoute(nameof(GridLayoutPage), typeof(GridLayoutPage));
            Routing.RegisterRoute(nameof(HorizontalStackLayoutPage), typeof(HorizontalStackLayoutPage));
            Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
            Routing.RegisterRoute(nameof(VerticalStackLayoutPage), typeof(VerticalStackLayoutPage));
        }
    }
}
