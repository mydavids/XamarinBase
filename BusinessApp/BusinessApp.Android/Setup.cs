using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using BusinessApp.Contracts.Repositories;
using BusinessApp;
using BusinessApp.Repositories;
using BusinessApp.Models;

namespace BusinessApp.Droid
{
    /// <summary>
    /// Every MvvmCross UI project needs a setup class.
    /// For Android, inherit from MvxAndroidSetup
    /// 
    /// Initializes:
    /// - IoC system
    /// - MvvmCross data binding
    /// - App class and collection of ViewModels
    /// - UI project and collection of Views
    /// </summary>
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var dbConn = FileAccessHelper.GetLocalFilePath("BusinessApp.db3");
            Mvx.RegisterSingleton(new BaseRepository<User>());
            return new App();
        }
    }
}