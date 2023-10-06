namespace CleanArchitectureTemplate.IntegrationTests;

[CollectionDefinition("Db collection")]
public sealed class SharedTestCollection : ICollectionFixture<CleanArchitectureTemplateFactory> { }
