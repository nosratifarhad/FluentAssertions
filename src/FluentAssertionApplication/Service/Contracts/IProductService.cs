using FluentAssertionApplication.Domain.Enum;
using System.Net.Http;

namespace FluentAssertionApplication.Service.Contracts
{
    public interface IProductService
    {
        int NumericTypeIntAssertion();

        int? NumericTypeIntNulableAssertion();

        float NumericTypeFloatAssertion();

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

        ICollection<int> CollectionIntAssertion();

        ICollection<string> CollectionStringAssertion();

        int[] ArrayIntAssertion();

        string[] ArrayStringAssertion();

        int[]? ArrayNulableAssertion();

        List<int> ListIntAssertion();

        List<string> ListStringAssertion();

        Dictionary<int, string> DictionariesAssertion();

        Guid GuidsAssertion();

        Guid? GuidNulableAssertion();

        EnumForTest EnumsAssertion();

        void ExceptionsAssertion();

        HttpResponseMessage HttpResponseMessagesAssertion();
    }
}
