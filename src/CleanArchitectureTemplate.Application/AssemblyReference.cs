using System.Reflection;

namespace CleanArchitectureTemplate.Application;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
    public static string? Namespace = typeof(AssemblyReference).Namespace;
}
