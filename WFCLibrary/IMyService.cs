using System.ServiceModel;

namespace WCFLibrary
{

    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string Method1(string x);
        [OperationContract]
        string Method2(string x);
    }
}