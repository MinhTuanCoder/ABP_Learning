using Acme.BookStore.Samples;
using Xunit;

namespace Acme.BookStore.MongoDB.Domains;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<BookStoreMongoDbTestModule>
{

}
