using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Data;
using System.Security.Cryptography;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService {
    public string Authentication(User user) {
        string uname = "SOF/20/B1/33";
        string pw = "madhushika";
        string hashedPw = getMD5(pw);
        string error;

        if (user.UName.Trim() != string.Empty && user.Pw.Trim() != string.Empty) {
            if (user.UName.Trim() == uname && getMD5(user.Pw.Trim()) == hashedPw) {
                error = "";
            } else {
                error = "Username and Password doesn't match!";
            }
        } else if (user.UName.Trim() == string.Empty && user.Pw.Trim() != string.Empty) {
            error = "Username field is empty!";
        } else if (user.UName.Trim() != string.Empty && user.Pw.Trim() == string.Empty) {
            error = "Password field is empty!";
        } else {
            error = "Username and Password fields are empty!";
        }
        return error;
    }

    public static string getMD5(string input) {

        byte[] encodedPassword = new UTF8Encoding().GetBytes(@input);
        byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
        string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        return encoded;
    }

    public List<List<string>> PizzaList() {
        var list = new List<List<string>> {
            new List<string>{ "Tandoori Chicken", "Tandoori oven baked shredded chicken breasts, onions and capsicum", "1839", "1.jpg"},
            new List<string>{ "Hot Chili Chicken", "Quick fried hot chili chicken, capsicum, onion, red paprika slices and devil sauce", "1839", "2.jpg"},
            new List<string>{ "Chicken Pepperoni", "Delicious Chicken Pepperoni fused with Mozzarella Cheese and Tomato Sauce.", "1679", "3.jpg"},
        };
        return list;
    }
}
