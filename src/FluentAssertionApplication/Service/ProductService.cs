using FluentAssertionApplication.Domain.Enum;
using FluentAssertionApplication.Service.Contracts;
using Microsoft.VisualBasic;
using System.Net.Http;
using System.Threading;

namespace FluentAssertionApplication.Service
{
    public class ProductService : IProductService
    {
        #region [ Numeric Type ]

        public int NumericTypeIntAssertion()
        {
            return 5;
        }

        public int? NumericTypeIntNulableAssertion()
        {
            return 3;
        }

        public float NumericTypeFloatAssertion()
        {
            return 3.1415927F;
        }

        #endregion [ Numeric Type ]

        #region [ Nullable Types ]

        public int? NullableTypeIntAssertion()
        {
            return 3;
        }

        public DateTime? NullableTypesAssertion()
        {
            return null;
        }

        public short? NullableTypeShortAssertion()
        {
            return null;
        }

        #endregion [ Nullable Types ]

        #region [ Booleans ]

        public bool BooleansAssertion()
        {
            return true;
        }

        #endregion [ Booleans ]

        #region [ Strings ]

        public string StringEmptyAssertion()
        {
            return "";
        }

        public string? StringNullAssertion()
        {
            return null;
        }

        public string StringMailAssertion()
        {
            return "nosratifarhad01@gmail.com";
        }

        public string StringDynamicAssertion()
        {
            DateTime dateTime = DateTime.Now;
            var second = dateTime.Second;
            if (second > 30)
                return string.Empty;

            return "this is dynamic method";
        }

        #endregion [ Strings ]

        #region [ DateTime ]

        public TimeOnly TimeOnlyAssertion()
        {
            return new TimeOnly();
        }

        public DateOnly DateOnlyAssertion()
        {
            return new DateOnly();
        }

        public DateTime DateTimeAssertion()
        {
            return DateTime.Now;
        }

        #endregion [ DateTime ]

        #region [ Collection ]

        public int[] ArrayIntAssertion()
        {
            return new int[3] { 1, 2, 4 };
        }

        public int[]? ArrayNulableAssertion()
        {
            DateTime dateTime = DateTime.Now;
            var second = dateTime.Second;
            if (second > 30)
                return null;

            return new int[3] { 1, 2, 4 };
        }

        public string[] ArrayStringAssertion()
        {
            return new string[3] { "one", "two", "three" };
        }

        public ICollection<int> CollectionIntAssertion()
        {
            return (ICollection<int>)new int[3] { 1, 2, 4 };
        }

        public ICollection<string> CollectionStringAssertion()
        {
            return (ICollection<string>)new string[3] { "one", "two", "three" };
        }

        public List<int> ListIntAssertion()
        {
            return new List<int> { 1, 2, 4 };
        }

        public List<string> ListStringAssertion()
        {
            return new List<string> { "one", "two", "three" };
        }

        #endregion [ Collection ]

        #region [ Dictionarys ]

        public Dictionary<int, string> DictionariesAssertion()
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

        public Guid? GuidNulableAssertion()
        {
            DateTime dateTime = DateTime.Now;
            var second = dateTime.Second;
            if (second > 30)
                return null;

            return Guid.NewGuid();
        }

        public Guid GuidsAssertion()
        {
            return Guid.NewGuid();
        }

        #endregion [ Guid ]

        #region [ Enum ]

        public EnumForTest EnumsAssertion()
        {
            return EnumForTest.None;
        }

        #endregion [ Enum ]

        #region [ HttpResponseMessages ]

        public HttpResponseMessage HttpResponseMessagesAssertion()
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

        public void ExceptionsAssertion()
        {
            throw new ArgumentException("Assertion For Exception.");
        }

        #endregion [ Exceptions ]
    }
}
