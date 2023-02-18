using NameProfilerAPI.Core.Controllers;
using NUnit.Framework;
using Moq;
using NameProfilerAPI.Core;
using Microsoft.AspNetCore.Mvc;
using NameProfilerAPI.Core.Model;
using FluentAssertions;

namespace NameProfilerAPI.Tests;

public class NameProfilerAPIControllerTests
{
    NameProfilerController _nameProfilerController;
    Mock<INameProfilerService> _nameProfilerServiceMock;

    [SetUp]
    public void Setup()
    {
        _nameProfilerServiceMock = new Mock<INameProfilerService>();
        _nameProfilerController = new NameProfilerController(_nameProfilerServiceMock.Object);
    }

    [Test]
    public void Convert_Name_To_Soul_Plan_Numbers_Method_Should_Return_Soul_Plan_Numbers_Given_Name()
    {
        var name = "Paz Sonagara";
        var soulPlanNumbers = new SoulPlanNumbers { WorldlyChallenges = "11 - 2" };

        _nameProfilerServiceMock.Setup(x => x.GenerateSoulPlanNumbers(name)).Returns(soulPlanNumbers);

        ActionResult<SoulPlanNumbers> spn = _nameProfilerController.ConvertNameToSoulPlanNumbers(name);

        spn.Should().BeOfType(typeof(ActionResult<SoulPlanNumbers>));
        spn.Value.Should().BeEquivalentTo(new SoulPlanNumbers { WorldlyChallenges = "11 - 2" });
    }
}
