﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RxSampleParameter.Recording_modules.Database
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BtnAddEntry recording.
    /// </summary>
    [TestModule("3482b557-4ff1-47f8-a0a1-f7cae8a08622", ModuleType.Recording, 1)]
    public partial class BtnAddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RxSampleParameter.RxSampleParameterRepository repository.
        /// </summary>
        public static global::RxSampleParameter.RxSampleParameterRepository repo = global::RxSampleParameter.RxSampleParameterRepository.Instance;

        static BtnAddEntry instance = new BtnAddEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnAddEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BtnAddEntry Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DatabaseTest.BtnAddPerson' at 58;12.", repo.ApplicationUnderTest.DatabaseTest.BtnAddPersonInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.DatabaseTest.BtnAddPerson.Click("58;12");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
