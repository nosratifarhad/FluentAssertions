using FluentAssertionApplication.Domain.Entity;
using FluentAssertionApplication.Domain.Enum;

namespace FluentAssertionApplication.Service.Contracts
{
    public interface IProductService
    {
        int NumericTypeIntService();

        int? NumericTypeIntNulableService();

        float NumericTypeFloatService();

        int NumericTypeNegativeService();

        DateTime? NullableTypeService();

        short? NullableTypeShortService();

        int? NullableTypeIntService();

        bool BooleanService();

        string StringEmptyService();
        
        string? StringNullService();

        string StringMailService();

        string StringDynamicService();

        DateTime DateTimeService();

        DateOnly DateOnlyService();

        TimeOnly TimeOnlyService();

        IEnumerable<int> CollectionIntService();

        public List<Product> ListProductIntService();

        List<string> ListStringService();

        Dictionary<int, string> DictionaryService();

        Guid GuidService();

        EnumForTest EnumService();

        void ExceptionService();

        HttpResponseMessage HttpResponseMessageService();
    }
}
