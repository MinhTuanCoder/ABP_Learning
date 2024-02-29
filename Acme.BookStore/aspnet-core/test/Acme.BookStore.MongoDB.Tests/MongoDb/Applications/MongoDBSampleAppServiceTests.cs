using Acme.BookStore.MongoDB;
using Acme.BookStore.Samples;
using Xunit;

namespace Acme.BookStore.MongoDb.Applications;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<BookStoreMongoDbTestModule>
{

}
