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

namespace MyTest7
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("22ff96fe-6e72-40b5-a991-02e9f2ab6ec2", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest7Repository repository.
        /// </summary>
        public static MyTest7Repository repo = MyTest7Repository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
            testColVar = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _testColVar;

        /// <summary>
        /// Gets or sets the value of variable testColVar.
        /// </summary>
        [TestVariable("34a34e12-bb12-4581-8d04-cc788a340eb7")]
        public string testColVar
        {
            get { return _testColVar; }
            set { _testColVar = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
