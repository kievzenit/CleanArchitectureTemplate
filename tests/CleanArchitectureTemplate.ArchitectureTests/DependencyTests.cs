using System.Reflection;

namespace CleanArchitectureTemplate.ArchitectureTests;

public class DependencyTests
{
    private static readonly Assembly DomainAssembly = Domain.AssemblyReference.Assembly;
    private static readonly Assembly ApplicationAssembly = Application.AssemblyReference.Assembly;
    private static readonly Assembly InfrastructureAssembly = Infrastructure.AssemblyReference.Assembly;
    private static readonly Assembly PresentationAssembly = Presentation.AssemblyReference.Assembly;
    private static readonly Assembly ApiAssembly = Api.AssemblyReference.Assembly;

    private static readonly string? DomainNamespace = Domain.AssemblyReference.Namespace;
    private static readonly string? ApplicationNamespace = Application.AssemblyReference.Namespace;
    private static readonly string? InfrastructureNamespace = Infrastructure.AssemblyReference.Namespace;
    private static readonly string? PresentationNamespace = Presentation.AssemblyReference.Namespace;
    private static readonly string? ApiNamespace = Api.AssemblyReference.Namespace;

    [Fact]
    public void Domain_ShouldHaveDependencyOnOtherProjects()
    {
        // Arrange
        var otherProjects = new[]
        {
            ApplicationNamespace,
            InfrastructureNamespace,
            PresentationNamespace,
            ApiNamespace
        };

        // Act
        var result = Types.InAssembly(DomainAssembly)
            .Should()
            .NotHaveDependencyOnAll(otherProjects)
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Application_ShouldHaveDependencyOnOtherProjects()
    {
        // Arrange
        var otherProjects = new[]
        {
            InfrastructureNamespace,
            PresentationNamespace,
            ApiNamespace
        };

        // Act
        var result = Types.InAssembly(ApplicationAssembly)
            .Should()
            .NotHaveDependencyOnAll(otherProjects)
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Infrastructure_ShouldHaveDependencyOnOtherProjects()
    {
        // Arrange
        var otherProjects = new[]
        {
            PresentationNamespace,
            ApiNamespace
        };

        // Act
        var result = Types.InAssembly(InfrastructureAssembly)
            .Should()
            .NotHaveDependencyOnAll(otherProjects)
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Presentation_ShouldHaveDependencyOnOtherProjects()
    {
        // Arrange
        var otherProjects = new[]
        {
            InfrastructureNamespace,
            ApiNamespace
        };

        // Act
        var result = Types.InAssembly(PresentationAssembly)
            .Should()
            .NotHaveDependencyOnAll(otherProjects)
            .GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
