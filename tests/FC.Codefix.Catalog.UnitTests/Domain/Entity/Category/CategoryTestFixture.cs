using Xunit;
using DomainEntity = FC.Codefix.Catalog.Domain.Entity;

namespace FC.Codefix.Catalog.UnitTests.Domain.Entity.Category
{
    public class CategoryTestFixture
    {
        public DomainEntity.Category GetValidCategory() 
            => new("Category Name", "Category Description");
    }

    [CollectionDefinition(nameof(CategoryTestFixture))]
    public class CategoryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
    {

    }
}
