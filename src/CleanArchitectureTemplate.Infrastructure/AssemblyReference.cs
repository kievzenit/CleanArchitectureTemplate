using System.Reflection;

namespace CleanArchitectureTemplate.Infrastructure;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
    public static string? Namespace = typeof(AssemblyReference).Namespace;
}
