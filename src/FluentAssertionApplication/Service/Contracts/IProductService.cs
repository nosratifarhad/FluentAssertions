using FluentAssertionApplication.Domain.Enum;

namespace FluentAssertionApplication.Service.Contracts
{
    public interface IProductService
    {
        void NullableTypesAssertion();

        short NullableTypeShortAssertion();

        int NullableTypeIntAssertion();

        bool BooleansAssertion();

        string StringsAssertion();

        DateTime DateTimeAssertion();

        DateOnly DateOnlyAssertion();

        TimeOnly TimeOnlyAssertion();

        ICollection<int> CollectionIntAssertion();

        ICollection<int> CollectionStringAssertion();

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

        void EventMonitoringAssertion();

        void AssemblyReferencesAssertion();

        void HttpResponseMessagesAssertion();

        void ExecutionTimeAssertion();

    }
}
