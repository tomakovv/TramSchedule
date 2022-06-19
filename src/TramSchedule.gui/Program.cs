using Microsoft.Extensions.DependencyInjection;
using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<TramScheduleContext>();
            services.AddTransient<ITramRepository, TramRepository>();
            services.AddTransient<ITramLineRepository, TramLineRepository>();
            services.AddTransient<ITramStopRepository, TramStopRepository>();
            services.AddTransient<ITramStopCommentsRepository, TramStopCommentsRepository>();
            services.AddTransient<TramViewModel>();
            services.AddTransient<TramLineViewModel>();
            services.AddTransient<TramStopViewModel>();
            services.AddTransient<TramStopCommentViewModel>();
            services.AddTransient<Form1>();
            services.AddTransient<Form2>();
            services.AddTransient<FormAddCommentToStop>();
            services.AddTransient<FormAddNewLine>();
            services.AddTransient<FormAddStopToLine>();

            using var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<Form2>();
            serviceProvider.GetRequiredService<FormAddCommentToStop>();
            serviceProvider.GetRequiredService<FormAddNewLine>();
            serviceProvider.GetRequiredService<FormAddStopToLine>();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}