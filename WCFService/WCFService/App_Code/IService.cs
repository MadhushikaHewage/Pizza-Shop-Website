using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService {

    [OperationContract]
    string Authentication(User user);

    [OperationContract]
    List<List<string>> PizzaList();
}

[DataContract]
public class User {
    string uname, pw;

    [DataMember]
    public string UName {
        get { return uname; }
        set { uname = value; }
    }

    [DataMember]
    public string Pw {
        get { return pw; }
        set { pw = value; }
    }
}