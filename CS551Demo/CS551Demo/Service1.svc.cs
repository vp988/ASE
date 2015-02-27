using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CS551Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }



    [WebInvoke(Method = "GET",ResponseFormat = WebMessageFormat.Json,UriTemplate = "data/{id}")]

        public String GetDetails(string id)
        {
           return string.Format("you entered:{0}",id);    
        // lookup person with the requested id 
           /* return new Person()
            {
                id = Convert.ToInt32(id),
                
                
                name = "Student"+id
                
            };*/
        }



    }

    
        public class Person
        {

            public int id { get; set; }

            public string name { get; set; }

        }
}
