using System;
using NameProfilerAPI.Core.Model;

namespace NameProfilerAPI.Core
{
	public interface INameProfilerService
	{
		public SoulPlanNumbers GenerateSoulPlanNumbers(string name);
	}
}

