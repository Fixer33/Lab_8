//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Lab_8.Views.AfterTomorrowPage.xaml", "Views/AfterTomorrowPage.xaml", typeof(global::Lab_8.Views.AfterTomorrowPage))]

namespace Lab_8.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\AfterTomorrowPage.xaml")]
    public partial class AfterTomorrowPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Lab_8.Controls.WeatherView morningInfo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Lab_8.Controls.WeatherView dayInfo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Lab_8.Controls.WeatherView eveningInfo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AfterTomorrowPage));
            morningInfo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Lab_8.Controls.WeatherView>(this, "morningInfo");
            dayInfo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Lab_8.Controls.WeatherView>(this, "dayInfo");
            eveningInfo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Lab_8.Controls.WeatherView>(this, "eveningInfo");
        }
    }
}
