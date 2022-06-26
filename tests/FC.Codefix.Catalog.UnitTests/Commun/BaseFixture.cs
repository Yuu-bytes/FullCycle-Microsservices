using Bogus;

namespace FC.Codeflix.Catalog.UnitTests.Commun
{
    public abstract class BaseFixture
    {
        public Faker Faker { get; set; }

        protected BaseFixture()
        {
            Faker = new Faker("pt_BR");
        }

    }
}
