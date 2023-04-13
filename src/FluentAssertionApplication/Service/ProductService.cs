using FluentAssertionApplication.Domain.Enum;
using FluentAssertionApplication.Service.Contracts;

namespace FluentAssertionApplication.Service
{
    public class ProductService : IProductService
    {

        #region [ Nullable Types ]

        public int NullableTypeIntAssertion()
        {
            throw new NotImplementedException();
        }

        public void NullableTypesAssertion()
        {
            throw new NotImplementedException();
        }

        public short NullableTypeShortAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Nullable Types ]

        #region [ Booleans ]

        public bool BooleansAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Booleans ]

        #region [ Strings ]

        public string StringsAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Strings ]

        #region [ DateTime ]

        public TimeOnly TimeOnlyAssertion()
        {
            throw new NotImplementedException();
        }

        public DateOnly DateOnlyAssertion()
        {
            throw new NotImplementedException();
        }

        public DateTime DateTimeAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ DateTime ]

        #region [ Collection ]

        public int[] ArrayIntAssertion()
        {
            throw new NotImplementedException();
        }

        public int[]? ArrayNulableAssertion()
        {
            throw new NotImplementedException();
        }

        public string[] ArrayStringAssertion()
        {
            throw new NotImplementedException();
        }

        public ICollection<int> CollectionIntAssertion()
        {
            throw new NotImplementedException();
        }

        public ICollection<int> CollectionStringAssertion()
        {
            throw new NotImplementedException();
        }

        public List<int> ListIntAssertion()
        {
            throw new NotImplementedException();
        }

        public List<string> ListStringAssertion()
        {
            throw new NotImplementedException();
        }


        #endregion [ Collection ]

        #region [ Dictionarys ]

        public Dictionary<int, string> DictionariesAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Dictionarys ]

        #region [ Guid ]

        public Guid? GuidNulableAssertion()
        {
            throw new NotImplementedException();
        }

        public Guid GuidsAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Guid ]

        #region [ Enum ]

        public EnumForTest EnumsAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Enum ]

        #region [ Event Monitoring ]

        public void EventMonitoringAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Event Monitoring ]

        #region [ Assembly References ]

        public void AssemblyReferencesAssertion()
        {
            throw new NotImplementedException();
        }
        #endregion [ Assembly References ]

        #region [ HttpResponseMessages ]

        public void HttpResponseMessagesAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ HttpResponseMessages ]

        #region [ Exceptions ]

        public void ExceptionsAssertion()
        {
            throw new NotImplementedException();
        }

        public void ExecutionTimeAssertion()
        {
            throw new NotImplementedException();
        }

        #endregion [ Exceptions ]
    }
}
