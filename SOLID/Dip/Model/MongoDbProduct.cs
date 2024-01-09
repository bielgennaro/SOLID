namespace Dip.Model
{
    public class MongoDbProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDb: Exibindo dados do produto {id}";
        }
    }
}