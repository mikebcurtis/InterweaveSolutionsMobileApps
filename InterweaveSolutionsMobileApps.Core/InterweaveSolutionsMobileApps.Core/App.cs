using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace InterweaveSolutionsMobileApps.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            //register classes with the IoC layer
            CreatableTypes().EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }
    }
}
