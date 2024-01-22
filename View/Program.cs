using Model.BL;
using Model.DAL;
using Model.Model;
using Ninject;
using Ninject.Modules;
using Presenter;
using Shared;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            MainPresenter presenter = ninjectKernel.Get<MainPresenter>();
        }
    }

    class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Employee>>().To<EmployeeRepository>().InSingletonScope();
            Bind<IMainView>().To<Form1>().InSingletonScope();
            Bind<IMainModel>().To<MainModel>().InSingletonScope();

            ExampleContext.ConnectionString = "Data Source=exampledata.db";
        }
    }
}