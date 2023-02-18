using System;
using NameProfilerAPI.Core.Model;

namespace NameProfilerAPI.Core.Service
{
	public class NameProfilerService : INameProfilerService
	{
		public NameProfilerService()
		{
		}

        public SoulPlanNumbers GenerateSoulPlanNumbers(string name)
        {
            return new SoulPlanNumbers { WorldlyChallenges = "13 - 4" };
        }
    }
}

