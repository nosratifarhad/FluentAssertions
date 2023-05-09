using FluentAssertionApplication.Domain.Entity;
using FluentAssertionApplication.Domain.Enum;
using FluentAssertionApplication.Service.Contracts;

namespace FluentAssertionApplication.Service
{
    public class ProductService : IProductService
    {
        #region [ Numeric Type ]

        public int NumericTypeIntService()
        {
            return 5;
        }

        public int? NumericTypeIntNulableService()
        {
            return 3;
        }

        public float NumericTypeFloatService()
        {
            return 3.1415927F;
        }

        public int NumericTypeNegativeService()
        {
            return -8;
        }

        #endregion [ Numeric Type ]

        #region [ Nullable Types ]

        public int? NullableTypeIntService()
        {
            return 3;
        }

        public DateTime? NullableTypeService()
        {
            return null;
        }

        public short? NullableTypeShortService()
        {
            return null;
        }

        #endregion [ Nullable Types ]

        #region [ Booleans ]

        public bool BooleanService()
        {
            return true;
        }

        #endregion [ Booleans ]

        #region [ Strings ]

        public string StringEmptyService()
        {
            return "";
        }

        public string? StringNullService()
        {
            return null;
        }

        public string StringMailService()
        {
            return "nosratifarhad01@gmail.com";
        }

        public string StringDynamicService()
        {
            DateTime dateTime = DateTime.Now;
            var second = dateTime.Second;
            if (second > 30)
                return string.Empty;

            return "this is dynamic method";
        }

        #endregion [ Strings ]

        #region [ DateTime ]

        public TimeOnly TimeOnlyService()
        {
            return new TimeOnly();
        }

        public DateOnly DateOnlyService()
        {
            return new DateOnly();
        }

        public DateTime DateTimeService()
        {
            return DateTime.Now;
        }

        #endregion [ DateTime ]

        #region [ Collection ]

        public IEnumerable<int> CollectionIntService()
        {
            return new[] { 1, 2, 5, 8 };
        }

        public List<string> ListStringService()
        {
            return new List<string> { "one", "two", "three" };
        }

        public List<Product> ListProductIntService()
            => new List<Product>()
            {
                new()
                {
                    ProductId = 1,
                    ProductName = "ProductName 1"
                },
                new()
                {
                    ProductId = 2,
                    ProductName = "ProductName 2"
                },

            };

        #endregion [ Collection ]

        #region [ Dictionarys ]

        public Dictionary<int, string> DictionaryService()
        {
            return new Dictionary<int, string>()
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" }
            };
        }

        #endregion [ Dictionarys ]

        #region [ Guid ]

        public Guid GuidService()
        {
            return Guid.NewGuid();
        }

        #endregion [ Guid ]

        #region [ Enum ]

        public EnumForTest EnumService()
        {
            return EnumForTest.None;
        }

        #endregion [ Enum ]

        #region [ HttpResponseMessages ]

        public HttpResponseMessage HttpResponseMessageService()
        {
            return new HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                RequestMessage = new HttpRequestMessage()
                {

                },
            };
        }

        #endregion [ HttpResponseMessages ]

        #region [ Exceptions ]

        public void ExceptionService()
        {
            throw new ArgumentException("Assertion For Exception.");
        }

        #endregion [ Exceptions ]
    }
}
