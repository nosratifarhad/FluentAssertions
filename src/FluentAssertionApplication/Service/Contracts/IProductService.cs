using FluentAssertionApplication.Domain.Entity;
using FluentAssertionApplication.Domain.Enum;

namespace FluentAssertionApplication.Service.Contracts
{
    public interface IProductService
    {
        int NumericTypeIntAssertion();

        int? NumericTypeIntNulableAssertion();

        float NumericTypeFloatAssertion();

        int NumericTypeNegativeAssertion();

        DateTime? NullableTypesAssertion();

        short? NullableTypeShortAssertion();

        int? NullableTypeIntAssertion();

        bool BooleansAssertion();

        string StringEmptyAssertion();
        
        string? StringNullAssertion();

        string StringMailAssertion();

        string StringDynamicAssertion();

        DateTime DateTimeAssertion();

        DateOnly DateOnlyAssertion();

        TimeOnly TimeOnlyAssertion();

        IEnumerable<int> CollectionIntAssertion();

        public List<Product> ListProductIntAssertion();

        List<string> ListStringAssertion();

        Dictionary<int, string> DictionariesAssertion();

        Guid GuidsAssertion();

        EnumForTest EnumsAssertion();

        void ExceptionsAssertion();

        HttpResponseMessage HttpResponseMessagesAssertion();
    }
}
