﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceCommand
{
	internal class StandardOutputReporter : ICommandReporter
	{
		public void Report(string command)
		{
			Console.WriteLine(command);
		}
	}
}
