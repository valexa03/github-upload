/*
 * Created by Ranorex
 * User: pkudrys
 * Date: 16. 6. 2021
 * Time: 14:13
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace MyTest7
{
	/// <summary>
	/// Description of UserCodeModule1.
	/// </summary>
	[TestModule("3AD36A29-B43B-43F6-B7C3-D2F7B6676C2A", ModuleType.UserCode, 1)]
	public class UserCodeModule1 : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public UserCodeModule1()
		{
			// Do not delete - a parameterless constructor is required!
		}

string _testColVar = "";
[TestVariable("6c3d4175-4ab7-4a84-926e-cbb12e342a1e")]
public string testColVar
{
	get { return _testColVar; }
	set { _testColVar = value; }
}

string _testParamVar = "";
[TestVariable("a37a54cc-c216-4c70-8f6b-08ec95a5cfab")]
public string testParamVar
{
	get { return _testParamVar; }
	set { _testParamVar = value; }
}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			testParamVar = testColVar;
		}
	}
}
