﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest.Forms.Sample.Specflow
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Test
    {
        protected IApp app;
        protected Platform platform;

        public Test(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        //public void AppLaunches()
        //{
        //    app.Screenshot("First screen.");
        //}
    }
}
